using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.constants;

namespace TN_CSDLPT.views
{
    public partial class FormClass : DevExpress.XtraEditors.XtraForm
    {

        private bool checkThem = false;
        private bool checkXoa = false;
        private bool checkSua = false;
        private bool checkThemSV = false;
        private bool checkXoaSV = false;
        private bool checkChuyenLop = false;
        private bool checkSuaSV = false;
        public static bool checkSave = true;

        ArrayList undoCommands = new ArrayList();

        public FormClass()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsClass.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.KHOA' table. You can move, or remove it, as needed.
            this.taDepartment.Fill(this.DataSet.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.taStudent.Fill(this.DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Fill(this.DataSet.LOP);

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                bdsStudent.AddNew();
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { });

                pcClass.Enabled = false;
                pcStudent.Enabled = true;

                gcClass.Enabled = gcStudent.Enabled = false;
                FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem> {
                    btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent, btnSaveStudent, btnUndoStudent, btnRefreshStudent
                });
                teStudentId.Enabled = teLastName.Enabled = teFirstName.Enabled = deBirthDate.Enabled
                    = teAddress.Enabled = true;

                cbxStudentClass.Enabled = false;
                checkThemSV = true;

                //cbbTenLop.SelectedValue = edtMaLop.Text;
                SetCbxStudentClass(teClassId.Text);
                teStudentClassId.Text = ((DataRowView)this.bdsClass.Current).Row["MALOP"].ToString();
                checkSave = false;

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, $"Couldn't add new student\n{ex.Message}");
            }
        }

        private void SetCbxStudentClass(string classId)
        {
            int position = bdsClass.Find("MALOP", classId);
            cbxStudentClass.SelectedIndex = position;
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Column)
            {
                GridViewColumnMenu menu = e.Menu as GridViewColumnMenu;
                menu.Items.Clear();
                if (menu.Column != null)
                {
                    menu.Items.Add(CreateCheckItem("Lock this column", menu.Column, null));
                }
            }
        }

        DXMenuCheckItem CreateCheckItem(string caption, GridColumn column, Image image)
        {
            DXMenuCheckItem item = new DXMenuCheckItem(caption,
              !column.OptionsColumn.AllowMove, image, new EventHandler(OnCanMoveItemClick));
            item.Tag = new MenuColumnInfo(column);
            return item;
        }

        // Menu item click handler.
        void OnCanMoveItemClick(object sender, EventArgs e)
        {
            DXMenuCheckItem item = sender as DXMenuCheckItem;
            MenuColumnInfo info = item.Tag as MenuColumnInfo;
            if (info == null) return;
            info.Column.OptionsColumn.AllowMove = !item.Checked;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                lOPGridControl.Enabled = sINHVIENGridControl.Enabled = false;
                bdsClass.AddNew();

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { btnNew, btnEdit, btnDelete });
                ctxMenu.Enabled = false;

                //Fill data cho bdsKhoa
                taDepartment.Connection.ConnectionString = Program.connstr;
                taDepartment.Fill(DataSet.KHOA);

                cbxDepartment.SelectedIndex = 0;
                // teDeparmentId.Text = cbxDepartment.SelectedValue.ToString();
                teClassId.Enabled = teClassName.Enabled = true;
                //checkThem = true;
                //panelTimGV.Enabled = false;
                //checkSave = false;

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, $"Failed to add new Class\n{ex.Message}");
            }
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsClass.Count == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._infomationTitle, "No Class available!");
                btnEdit.Enabled = false;
            }
            else
            {
                teClassId.Enabled = false;
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { btnNew, btnEdit, btnDelete });
                ctxMenu.Enabled = false;
                pcClass.Enabled = true;
                gcClass.Enabled = gcStudent.Enabled = false;

                //Fill data cho bdsKhoa
                taDepartment.Connection.ConnectionString = Program.connstr;
                taDepartment.Fill(DataSet.KHOA);
                //this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);

                //cbbTenKhoa.SelectedValue = ((DataRowView)this.bdsLop.Current).Row["MAKH"].ToString();
                //edtMaKH.Text = cbbTenKhoa.SelectedValue.ToString();
                //checkSua = true;
                //panelTimGV.Enabled = false;
                //checkSave = false;
            }
        }

        private void btnCommit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (checkThem)
            {
                if (ValidateClassInput())
                {
                    WriteDB();
                    checkThem = false;
                }

            }
            else if (checkSua)
            {
                if (ValidateClassInput())
                {
                    WriteDB();
                    checkSua = false;
                }
            }
            else
            {
                WriteDB();
                checkSua = false;
                checkThem = false;
            }

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (bdsClass.Count == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, "No Class available to delete");
            }

            else
            {
                if (bdsStudent.Count > 0)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, "Class couldn't be deleted, already have students");
                    return;
                }

                //if (bdsGiaoVienDK.Count > 0)
                //{
                //    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, "Class couldn't be deleted, already have teacher");
                //    return;
                //}
                string className = ((DataRowView)this.bdsClass.Current).Row["TENLOP"].ToString();
                string warningDeleteMsg = $"Are you sure to delete this class {className}";
                if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, Translation._warningTitle, warningDeleteMsg) == DialogResult.Yes)
                {
                    try
                    {
                        //phải chạy lệnh del from where mới chính xác
                        bdsClass.RemoveCurrent();
                        //đẩy dữ liệu về adapter
                        this.taClass.Update(this.DataSet.LOP);
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, $"Unable to delete class\n{ex.Message}");
                    }
                }

            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.KHOA' table. You can move, or remove it, as needed.
            this.taDepartment.Fill(this.DataSet.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.taStudent.Fill(this.DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Fill(this.DataSet.LOP);
        }

        private bool ValidateClassInput()
        {
            bool isValidated = true;
            if (teClassId.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Class ID"));
                isValidated = false;
                return isValidated;
            }

            if (teClassName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Class Name"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private bool WriteDB()
        {
            bool isSuccessully = true;

            try
            {
                bdsClass.EndEdit();
                //lấy dữ liệu hiện tại của control phía dưới lưu lên bên trên
                bdsClass.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                taClass.Update(DataSet.LOP);

                //FormUtils.DisableMatrixBarMangagerItems(barManager1, new List<BarItem> { 

                //});

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
            });

                pcClass.Enabled = pcStudent.Enabled = false;
                gcClass.Enabled = gcStudent.Enabled = true;
                checkThem = checkSua = checkXoa = false;

                ctxMenu.Enabled = true;

                FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
            {
                btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent, btnSaveStudent, btnUndoStudent, btnRefreshStudent
            });

                checkSave = true;
                isSuccessully = true;
            }
            catch (Exception ex)
            {

                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, $"Couldn't save class\n{ex.Message}");

            }

            return isSuccessully;
        }

        private bool WriteStudent()
        {
            bool isSucessfully = false;
            //string query = $"EXEC SP_INSERT_STUDENT '{teClassId}', ''"
            try
            {
                bdsStudent.EndEdit();
                bdsStudent.ResetCurrentItem();

                //ghi dữ liệu tạm về server, fill là ghi tạm, update là ghi thật
                // lệnh này sẽ lưu tất cả các giáo viên có thay đổi thông tin về server
                this.taStudent.Update(this.DataSet.SINHVIEN);

                this.taStudent.Connection.ConnectionString = Program.connstr;
                this.taStudent.Fill(this.DataSet.SINHVIEN);
                // TODO: This line of code loads data into the 'tNDataSet.DSKHOA' table. You can move, or remove it, as needed.
                this.taDepartment.Connection.ConnectionString = Program.connstr;
                //this.taDepartment.Fill(this.DataSet.DSKHOA);

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
                });

                pcClass.Enabled = pcStudent.Enabled = false;
                gcClass.Enabled = gcStudent.Enabled = true;
                checkThemSV = checkSuaSV = checkXoaSV = false;

                FormUtils.EnableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
                {
                    btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent, btnSaveStudent, btnUndoStudent, btnRefreshStudent
                });

                checkSave = true;

                isSucessfully = true;
            }
            catch (Exception ex)
            {
                checkSave = false;
                isSucessfully = false;
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._errorTitle, $"Couldn't save student\n{ex.Message}");
            }
            return isSucessfully;
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (bdsStudent.Count == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION,
                    Translation._infomationTitle, string.Format(Translation._argsNotEmptyMsg, "No student available!"));
            }
            else
            {
                string query = $"EXEC SP_DELETE_STUDENT N'{teStudentId}'";
                int result = Program.ExecSqlNonQuery(query);
                if (result == -1)
                {

                }
                else
                {
                    btnRefreshStudent.PerformClick();
                }

            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (bdsStudent.Count == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION,
                     Translation._infomationTitle, string.Format(Translation._argsNotEmptyMsg, "No student available!"));

            }
            else
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
                });

                pcClass.Enabled = false;
                pcStudent.Enabled = true;
                gcClass.Enabled = gcStudent.Enabled = false;

                FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
                {
                    btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent
                });

                teFirstName.Enabled = teLastName.Enabled = deBirthDate.Enabled = teAddress.Enabled = true;
                cbxStudentClass.Enabled = false;

                checkSuaSV = true;
                checkSave = false;

            }
        }

        private bool ValidateStudentInput()
        {
            bool isValidated = true;
            if (teStudentId.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Student ID"));
                isValidated = false;
                return isValidated;
            }

            if (teFirstName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "First Name"));
                isValidated = false;
                return isValidated;
            }
            if (teLastName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Last Name"));
                isValidated = false;
                return isValidated;
            }
            if (deBirthDate.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Birth Date"));
                isValidated = false;
                return isValidated;
            }
            if (teAddress.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Address"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private void btnSaveStudent_Click(object sender, EventArgs e)
        {
            if (checkThemSV == true)
            {
                if (ValidateStudentInput())
                {
                    WriteStudent();
                }
            }
            else if (checkSuaSV)
            {
                if (ValidateStudentInput())
                {
                    checkSuaSV = false;
                    WriteStudent();
                }
            }
            else if (checkChuyenLop)
            {
                string query = $"EXEC SP_CHANGE_CLASS N'{teStudentClassId.Text.Trim()}', N'{teStudentId.Text.Trim()}'";
                int result = Program.ExecSqlNonQuery(query);
                if (result == 1)
                {

                    FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                    {
                        btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
                    });

                    pcClass.Enabled = pcStudent.Enabled = false;
                    gcClass.Enabled = gcStudent.Enabled = true;
                    checkThemSV = checkSuaSV = checkXoaSV = false;

                    FormUtils.EnableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
                    {
                        btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent, btnSaveStudent, btnUndoStudent, btnRefreshStudent
                    });

                    checkChuyenLop = false;
                    btnRefresh.PerformClick();
                }
                else
                {
                    WriteStudent();
                }
            }
        }

        private void btnMoveStudent_Click(object sender, EventArgs e)
        {
            if (bdsStudent.Count == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION,
                     Translation._infomationTitle, string.Format(Translation._argsNotEmptyMsg, "No student available!"));

            }
            else
            {
                if (cbxStudentClass.Properties.Items.Count == 0)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION,
                        Translation._infomationTitle, string.Format(Translation._argsNotEmptyMsg, "No class available to change"));

                }
                else
                {
                    FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                    {
                        btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
                    });

                    pcClass.Enabled = false;
                    pcStudent.Enabled = true;
                    gcClass.Enabled = gcStudent.Enabled = false;

                    FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
                    {
                        btnAddStudent, btnEditStudent, btnMoveStudent, btnDeleteStudent
                    });

                    teFirstName.Enabled = teLastName.Enabled = deBirthDate.Enabled = teAddress.Enabled = false;
                    cbxStudentClass.Enabled = false;

                    checkChuyenLop = true;
                    checkSave = false;
                }
            }
        }

        private void cbxStudentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int position = cbxStudentClass.SelectedIndex;
                teStudentClassId.Text = ((DataRowView)this.bdsClass[position]).Row["MALOP"].ToString();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, 
                    Translation._errorTitle, $"cbxStudentClass\n{ex.Message}");
            }
        }

        private void deBirthDate_EditValueChanged(object sender, EventArgs e)
        {

        }
    }




    class MenuColumnInfo
    {
        public MenuColumnInfo(GridColumn column)
        {
            this.Column = column;
        }
        public GridColumn Column;
    }
}