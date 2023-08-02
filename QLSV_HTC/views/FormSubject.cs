using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.utils;
using TracNghiem_CSDLPT.Share;
using TracNghiem_CSDLPT.SupportForm;

namespace TN_CSDLPT.views
{
    public partial class FormSubject : DevExpress.XtraEditors.XtraForm
    {
        ArrayList undoCommands = new ArrayList();

        private CallBackAction1 _callAction = new CallBackAction1();
        int vitri = -1;
        String maCoSo;
        ActionMode mode;

        public FormSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.COSO' table. You can move, or remove it, as needed.
            this.taLocation.Fill(this.DataSet.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);

        }


        private void btnCommit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ValidateInput()) // Pass validation
            {

                string id = teID.Text;
                string name = teName.Text;

                string query = DatabaseUtils.BuildQuery(Database.SP_INSERT_SUBJECT, new string[] { id, name });
                int result = Program.ExecSqlNonQuery(query);
                if (result == 1) //subject id is already existed
                {
                    teID.Focus();
                    FillTable();
                    int position = bdsSubject.Find("ID", id); //get row position of existed id
                    bdsSubject.Position = position; //Hightlight that row
                }
                else
                {
                    bdsSubject.EndEdit();
                    bdsSubject.ResetCurrentItem();
                    CommitDB();


                    Frm_ActionInfo info = new Frm_ActionInfo(
                                        new Object[] { this.gvSubject, barManager1 },
                                        new CallBackAction1(TracNghiem_CSDLPT.Share.Action.AddSuccess, this._callAction.Table)
                                        );
                }
            }
        }

        private void cbxLocation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void cbxLocation_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            vitri = bdsSubject.Position;

            bdsSubject.AddNew();
            FormUtils.DisableMatrixButtons(barManager1, new List<BarButtonItem> { btnNew, btnEdit, btnExit, btnRefresh, btnUndo });
            gcSubject.Enabled = true;
            teID.Enabled = true;
        }



        private void gcInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            mode = ActionMode.Edit;
            vitri = bdsSubject.Position;

            gcInfo.Enabled = true;
            teID.Enabled = false;
            gcSubject.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            mode = ActionMode.Delete;
            string id = "";
            string name = "";

            int dialogResult = (int)XtraMessageBox.Show("Bạn có chắc muốn xóa môn học này?", "Xác nhận", MessageBoxButtons.OKCancel);
            if (dialogResult == (int)DialogResult.OK)
            {
                try
                {
                    id = (string)((DataRowView)bdsSubject[bdsSubject.Position])["MAMH"].ToString();
                    name = (string)((DataRowView)bdsSubject[bdsSubject.Position])["TENMH"].ToString();
                    bdsSubject.RemoveCurrent();
                    this.taSubject.Connection.ConnectionString = Program.connstr;
                    this.taSubject.Update(this.DataSet.MONHOC);
                    undoCommands.Add("EXEC SP_ADD_SUBJECT '" + id + "', '" + name + "'");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Xóa môn học thất bại, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.taSubject.Update(this.DataSet.MONHOC);
                    bdsSubject.Position = bdsSubject.Find("MAMH", id);
                    return;
                }

                if (bdsSubject.Count == 0)
                {
                    btnDelete.Enabled = false;
                }

                //mode = "";
                if (undoCommands.Count > 0)
                {
                    btnUndo.Enabled = true;
                }
                else
                {
                    btnUndo.Enabled = false;
                }
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (undoCommands.Count == 0)
            {
                btnUndo.Enabled = false;
            }
            else
            {

            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (mode.Equals(ActionMode.Add))
            {
                gvSubject.DeleteRow(gvSubject.FocusedRowHandle);
            }
            bdsSubject.CancelEdit(); //Stop editing on binding source

            bdsSubject.Position = vitri; //Point to previous row
            gcInfo.Enabled = false;

        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                taSubject.Fill(this.DataSet.MONHOC);
                bdsSubject.Position = vitri;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private bool ValidateInput()
        {
            bool validated = true;
            if (teID.Text.Trim().Length == 0)
            {
                teID.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._idLabel);
                validated = false;
            }
            if (teName.Text.Trim().Length == 0)
            {
                teName.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._nameLabel);
                validated = false;
            }
            return validated;
        }

        private void FillTable()
        {
            this.DataSet.EnforceConstraints = false;
            this.taSubject.Connection.ConnectionString = Program.connstr;
            this.taSubject.Fill(this.DataSet.MONHOC);
        }

        private void CommitDB()
        {
            this.bdsSubject.EndEdit();
            this.bdsSubject.ResetCurrentItem();
            this.taSubject.Update(this.DataSet.MONHOC);
        }


        //public bool AbleDelete()
        //{
        //    if (bs_GVDK.Count != 0)
        //    {
        //        MessageBox.Show("Không thể xóa môn học. Vì môn học đã được đăng ký thi.", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else if (bs_BangDiem.Count != 0)
        //    {
        //        MessageBox.Show("Không thể xóa môn học. Vì môn học đã được thi.", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else if (bs_BoDe.Count != 0)
        //    {
        //        MessageBox.Show("Không thể xóa môn học. Vì môn học đã được lập bộ đề.", "Error",
        //            MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}
    }
}