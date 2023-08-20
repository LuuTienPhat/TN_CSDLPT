using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
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
using TN_CSDLPT.models;
using TN_CSDLPT.utils;

namespace TN_CSDLPT.views
{
    public partial class FormClass : DevExpress.XtraEditors.XtraForm
    {

        public FormClassMode formMode = FormClassMode.Class;

        //class
        BindingList<CallBackAction> classCallBackActions = new BindingList<CallBackAction>();
        ActionMode classActionMode = ActionMode.None;
        int bdsClassPosition = -1;

        //student
        BindingList<CallBackAction> studentCallBackActions = new BindingList<CallBackAction>();
        ActionMode studentActionMode = ActionMode.None;
        int bdsStudentPosition = -1;

        public FormClass()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormClass_Load(object sender, EventArgs e)
        {
            this.DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSet.KHOA' table. You can move, or remove it, as needed.
            this.taDepartment.Connection.ConnectionString = Program.connstr;
            this.taDepartment.Fill(this.DataSet.KHOA);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.taStudent.Connection.ConnectionString = Program.connstr;
            this.taStudent.Fill(this.DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Connection.ConnectionString = Program.connstr;
            this.taClass.Fill(this.DataSet.LOP);

            Program.FillLocationCombobox(btnLocation, cbxLocation);
            FormUtils.FillComboBox(cbxDepartment, this.bdsDepartment, new string[] { Database.TABLE_DEPT_COL_DEPT_ID, Database.TABLE_DEPT_COL_DEPT_NAME });
            FormUtils.FillComboBox(cbxStudentClass, this.bdsClass, new string[] { Database.TABLE_CLASS_COL_CLASS_ID, Database.TABLE_CLASS_COL_CLASS_NAME });
            FormUtils.SetDefaultForBarManagerBars(barManager1);

            if (((Program.mGroup == Database.ROLE_SCHOOL) || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                //class
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });

                //student
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNewStudent, btnEditStudent, btnDeleteStudent, btnCommitStudent, btnUndoStudent, btnCancelStudent
                });
            }
            else
            {
                //class
                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                   btnCancel, btnCommit
                });

                //student
                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNewStudent, btnEditStudent, btnDeleteStudent
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                   btnCancelStudent, btnCommitStudent
                });
            }

            gcClassInfo.Enabled = gcStudentInfo.Enabled = false;
        }

        //class
        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            classActionMode = ActionMode.Add;
            bdsClass.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcClassInfo.Enabled = true;
            gcClass.Enabled = false;
            pcStudent.Enabled = false;
            teClassId.Enabled = teClassName.Enabled = true;

            cbxDepartment.SelectedIndex = 0;
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            //if (bdsClass.Count == 0)
            //{
            //    CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._infomationTitle, "No Class available!");
            //    btnEdit.Enabled = false;
            //}
            //else
            //{
            classActionMode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcClassInfo.Enabled = true;
            teClassId.Enabled = false;
            gcClass.Enabled = false;

            pcStudent.Enabled = false;
            //ctxMenu.Enabled = false;
            //pcClass.Enabled = true;


            //Fill data cho bdsKhoa
            //taDepartment.Connection.ConnectionString = Program.connstr;
            //taDepartment.Fill(DataSet.KHOA);
            //this.tbDSKhoaADT.Fill(this.TNDataSet.DSKHOA);

            //cbbTenKhoa.SelectedValue = ((DataRowView)this.bdsLop.Current).Row["MAKH"].ToString();
            //edtMaKH.Text = cbbTenKhoa.SelectedValue.ToString();
            //checkSua = true;
            //panelTimGV.Enabled = false;
            //checkSave = false;
            //}
        }

        private void btnCommit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateClassInput())
            {
                return;
            }

            string oldClassId = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_ID);
            string oldClassName = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_NAME);
            string oldDeparmentId = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_DEPARTMENT_ID);

            string classId = teClassId.Text;
            string departmentId = FormUtils.GetBindingSourceData(this.bdsDepartment, cbxDepartment.SelectedIndex, Database.TABLE_DEPT_COL_DEPT_ID);

            FormUtils.SetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_DEPARTMENT_ID, departmentId);
            if (!CommitClassDB()) //Write database failed
            {
                return;
            }

            if (classActionMode.Equals(ActionMode.Edit))
            {
                classCallBackActions.Add(
                    new CallBackAction(classActionMode,
                    DatabaseUtils.BuildQuery2(Database.SP_UPDATE_CLASS, new string[] { oldClassId, oldClassName, oldDeparmentId })
                    ));
            }

            if (classActionMode.Equals(ActionMode.Add))
            {
                Hashtable refs = new Hashtable();
                refs.Add(Database.TABLE_CLASS_COL_CLASS_ID, oldClassId);
                classCallBackActions.Add(
                    new CallBackAction(
                        classActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_DELETE_CLASS, new string[] { classId }),
                        refs
                    ));
            }

            classActionMode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcClassInfo.Enabled = false;
            gcClass.Enabled = true;
            pcStudent.Enabled = true;

            btnRefresh.PerformClick();

            this.bdsClass.Position = bdsClass.Find(Database.TABLE_CLASS_COL_CLASS_ID, classId);

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            classActionMode = ActionMode.Delete;
            if (bdsStudent.Count > 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, "Class couldn't be deleted, already have students");
                return;
            }

            string classId = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_ID);
            string className = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_NAME);
            string departmentId = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_DEPARTMENT_ID);
            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                string.Format(Translation._argsDeleteWarningMsg, $"Class {className.Trim()}")) == DialogResult.OK)
            {
                try
                {
                    this.bdsClass.RemoveCurrent();
                    this.taClass.Connection.ConnectionString = Program.connstr;
                    this.taClass.Update(this.DataSet.LOP);

                    classCallBackActions.Add(
                        new CallBackAction(
                            classActionMode,
                            DatabaseUtils.BuildQuery2(Database.SP_INSERT_CLASS, new string[] { classId, className, departmentId })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                        string.Format(Translation._argsDeleteErrorMsg, new string[] { $"Class {className.Trim()}", ex.Message }));
                    //this.taSubject.Update(this.DataSet.MONHOC);
                    return;
                }
                finally
                {
                    classActionMode = ActionMode.None;
                    btnRefresh.PerformClick();
                    this.bdsClass.Position = this.bdsClass.Find(Database.TABLE_CLASS_COL_CLASS_ID, classId);
                }
            }



            //}
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            CallBackAction action = classCallBackActions[classCallBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string classId = action.Reference[Database.TABLE_CLASS_COL_CLASS_ID].ToString();
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, string.Format(Translation._argsDeleteWarningMsg, $"Class {classId}"));
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                Program.myReader = Program.ExecSqlDataReader(action.Query);
                Program.myReader.Read();

                string affectedId = Program.myReader.GetString(0);
                if (affectedId != "-1")
                {
                    this.bdsClass.Position = this.bdsClass.Find(Database.TABLE_CLASS_COL_CLASS_ID, affectedId);
                }

                classCallBackActions.RemoveAt(classCallBackActions.Count - 1);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
            }

            finally
            {
                btnRefresh.PerformClick();
                Program.CloseSqlDataReader();
            }
        }

        private void btnCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (classActionMode.Equals(ActionMode.Add))
            {
                classActionMode = ActionMode.Cancel;
                gvClass.DeleteRow(gvClass.FocusedRowHandle);
            }

            classActionMode = ActionMode.Cancel;
            this.bdsClass.CancelEdit();
            this.bdsClass.Position = bdsClassPosition;

            gcClassInfo.Enabled = false;
            gcClass.Enabled = true;

            pcStudent.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            classActionMode = ActionMode.None;
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                classActionMode = ActionMode.Refresh;

                gcClass.Enabled = false;
                pcStudent.Enabled = false;

                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                this.bdsClass.EndEdit();

                this.taStudent.Connection.ConnectionString = Program.connstr;
                this.taStudent.Fill(this.DataSet.SINHVIEN);

                this.taDepartment.Connection.ConnectionString = Program.connstr;
                this.taDepartment.Fill(this.DataSet.KHOA);

                this.taClass.Connection.ConnectionString = Program.connstr;
                this.taClass.Fill(this.DataSet.LOP);
                this.bdsClass.Position = this.bdsClassPosition;

                SplashScreenManager.CloseForm();

                gcClass.Enabled = true;
                pcStudent.Enabled = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                classActionMode = ActionMode.None;
            }
        }

        //student
        private void btnNewStudent_Click(object sender, ItemClickEventArgs e)
        {
            studentActionMode = ActionMode.Add;
            bdsStudent.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewStudent, btnEditStudent, btnDeleteStudent, btnRefreshStudent, btnUndoStudent, btnExit
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitStudent, btnCancelStudent
            });

            gcStudentInfo.Enabled = true;
            gcStudent.Enabled = false;
            teStudentId.Enabled = true;

            pcClass.Enabled = false;

            cbxStudentClass.SelectedIndex = 0;

            //bdsStudent.AddNew();
            //FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { });

            //pcClass.Enabled = false;
            //pcStudent.Enabled = true;

            //gcClassInfo.Enabled = gcStudentInfo.Enabled = false;
            //FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem> {
            //        btnCtxAddStudent, btnCtxEditStudent, btnCtxMoveStudent, btnCtxDeleteStudent, btnCtxSaveStudent, btnCtxUndoStudent, btnCtxRefreshStudent
            //    });

            //teStudentId.Enabled = teLastName.Enabled = teFirstName.Enabled = deBirthDate.Enabled
            //    = teAddress.Enabled = true;

            //cbxStudentClass.Enabled = false;
            //checkThemSV = true;

            ////cbbTenLop.SelectedValue = edtMaLop.Text;
            //SetCbxStudentClass(teClassId.Text);
            //teStudentClassId.Text = ((DataRowView)this.bdsClass.Current).Row["MALOP"].ToString();
            //checkSave = false;
        }

        private void btnEditStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            classActionMode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewStudent, btnEditStudent, btnDeleteStudent, btnRefreshStudent, btnUndoStudent, btnExit
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitStudent, btnCancelStudent
            });

            gcStudentInfo.Enabled = true;
            gcStudent.Enabled = false;
            teStudentId.Enabled = false;

            pcClass.Enabled = false;

            //if (bdsStudent.Count == 0)
            //{
            //    CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION,
            //         Translation._infomationTitle, string.Format(Translation._argsNotEmptyMsg, "No student available!"));

            //}
            //else
            //{
            //FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            //    {
            //        btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
            //    });

            //pcClass.Enabled = false;
            //pcStudent.Enabled = true;
            //gcClassInfo.Enabled = gcStudentInfo.Enabled = false;

            //FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
            //    {
            //        btnCtxAddStudent, btnCtxEditStudent, btnCtxMoveStudent, btnCtxDeleteStudent
            //    });

            //teFirstName.Enabled = teLastName.Enabled = deBirthDate.Enabled = teAddress.Enabled = true;
            //cbxStudentClass.Enabled = false;

            //checkSuaSV = true;
            //checkSave = false;

            //}
        }

        private void btnCommitStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateStudentInput())
            {
                return;
            }

            string oldStudentId = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_ID);
            string oldLastName = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_LASTNAME);
            string oldFirstName = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_FIRSTNAME);
            string oldBirthDate = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_BIRTHDATE);
            string oldAddress = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_ADDRESS);
            string oldPassword = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_PASSWORD);
            string oldClassId = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_CLASS_ID);

            string studentId = this.teStudentId.Text;
            string classId = FormUtils.GetBindingSourceData(this.bdsClass, cbxStudentClass.SelectedIndex, Database.TABLE_CLASS_COL_CLASS_ID);

            if(studentActionMode.Equals(ActionMode.Add)) {
                string password = "123";
                FormUtils.SetBindingSourceData(this.bdsStudent, bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_PASSWORD, password);
            }

            FormUtils.SetBindingSourceData(bdsStudent, bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_CLASS_ID, classId);
            if (!CommitStudentDB()) //Write database failed
            {
                return;
            }

            if (studentActionMode.Equals(ActionMode.Edit))
            {
                studentCallBackActions.Add(
                    new CallBackAction(
                        studentActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_UPDATE_STUDENT, new string[]
                        {
                            oldStudentId, oldLastName, oldFirstName, oldBirthDate, oldAddress, oldPassword, oldClassId
                        })
                    ));
            }

            if (studentActionMode.Equals(ActionMode.Add))
            {
                Hashtable refs = new Hashtable();
                refs.Add(Database.TABLE_STUDENT_COL_STUDENT_ID, studentId);
                studentCallBackActions.Add(
                    new CallBackAction(
                        studentActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_DELETE_STUDENT, new string[] { studentId }),
                        refs
                    ));
            }

            studentActionMode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewStudent, btnEditStudent, btnDeleteStudent, btnRefreshStudent, btnExit
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitStudent, btnCancelStudent
            });

            gcStudentInfo.Enabled = false;
            gcStudent.Enabled = true;
            pcClass.Enabled = true;

            btnRefresh.PerformClick();
            this.bdsClass.Position = bdsStudent.Find(Database.TABLE_STUDENT_COL_STUDENT_ID, studentId);
        }

        private void btnDeleteStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            studentActionMode = ActionMode.Delete;
            string studentId = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_ID);
            string lastName = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_LASTNAME);
            string firstName = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_FIRSTNAME);
            string birthDate = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_BIRTHDATE);
            string address = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_ADDRESS);
            string password = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_PASSWORD);
            string classId = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_CLASS_ID);

            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
               string.Format(Translation._argsDeleteWarningMsg, $"Student {studentId}")) == DialogResult.OK)
            {

                try
                {
                    this.bdsStudent.RemoveCurrent();
                    this.taStudent.Connection.ConnectionString = Program.connstr;
                    this.taStudent.Update(this.DataSet.SINHVIEN);

                    studentCallBackActions.Add(
                        new CallBackAction(
                            studentActionMode,
                            DatabaseUtils.BuildQuery(Database.SP_INSERT_SUBJECT, new string[] { studentId, lastName, firstName, birthDate, address, password, classId })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                        string.Format(Translation._argsDeleteErrorMsg, new string[] { $"Student {studentId}", ex.Message }));
                    //this.taSubject.Update(this.DataSet.MONHOC);
                    return;
                }
                finally
                {
                    studentActionMode = ActionMode.None;
                    btnRefreshStudent.PerformClick();
                    this.bdsStudent.Position = this.bdsStudent.Find(Database.TABLE_STUDENT_COL_STUDENT_ID, studentId);
                }
            }


        }

        private void btnUndoStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            CallBackAction action = studentCallBackActions[studentCallBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string classId = action.Reference[Database.TABLE_CLASS_COL_CLASS_ID].ToString();
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, string.Format(Translation._argsDeleteWarningMsg, $"Class {classId}"));
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                Program.myReader = Program.ExecSqlDataReader(action.Query);
                Program.myReader.Read();

                string affectedId = Program.myReader.GetString(0);
                if (affectedId != "-1")
                {
                    this.bdsStudentPosition = this.bdsStudent.Find(Database.TABLE_CLASS_COL_CLASS_ID, affectedId);
                }

                studentCallBackActions.RemoveAt(studentCallBackActions.Count - 1);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
            }

            finally
            {
                btnRefreshStudent.PerformClick();
                Program.CloseSqlDataReader();
            }
        }

        private void btnCancelStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (studentActionMode.Equals(ActionMode.Add))
            {
                studentActionMode = ActionMode.Cancel;
                gvStudent.DeleteRow(gvStudent.FocusedRowHandle);
            }

            studentActionMode = ActionMode.Cancel;
            this.bdsStudent.CancelEdit();
            this.bdsStudent.Position = bdsStudentPosition;

            gcStudentInfo.Enabled = false;
            gcStudent.Enabled = true;
            pcClass.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewStudent, btnEditStudent, btnDeleteStudent, btnRefreshStudent, btnExit
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitStudent, btnCancelStudent
            });

            studentActionMode = ActionMode.None;
        }

        private void btnRefreshStudent_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                classActionMode = ActionMode.Refresh;

                gcStudent.Enabled = false;
                pcClass.Enabled = false;

                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                this.bdsStudent.EndEdit();
                this.taStudent.Connection.ConnectionString = Program.connstr;
                this.taStudent.Fill(this.DataSet.SINHVIEN);

                this.bdsStudent.Position = this.bdsStudentPosition;

                SplashScreenManager.CloseForm();

                gcStudent.Enabled = true;
                pcClass.Enabled = true;

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                classActionMode = ActionMode.None;
            }
        }

        private void SetCbxStudentClass(string classId)
        {
            int position = bdsClass.Find("MALOP", classId);
            cbxStudentClass.SelectedIndex = position;
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

        private bool CommitClassDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsClass.EndEdit();
                this.bdsClass.ResetCurrentItem();
                this.taClass.Connection.ConnectionString = Program.connstr;
                this.taClass.Update(this.DataSet.LOP);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            }
            return isCommitted;
        }

        private bool CommitStudentDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsStudent.EndEdit();
                this.bdsStudent.ResetCurrentItem();
                this.taStudent.Connection.ConnectionString = Program.connstr;
                this.taStudent.Update(this.DataSet.SINHVIEN);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            }
            return isCommitted;
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
                    btnCtxRefreshStudent.PerformClick();
                }

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
            //if (checkThemSV == true)
            //{
            //    if (ValidateStudentInput())
            //    {
            //        WriteStudent();
            //    }
            //}
            //else if (checkSuaSV)
            //{
            //    if (ValidateStudentInput())
            //    {
            //        checkSuaSV = false;
            //        WriteStudent();
            //    }
            //}
            //else if (checkChuyenLop)
            //{
            //    string query = $"EXEC SP_CHANGE_CLASS N'{teStudentClassId.Text.Trim()}', N'{teStudentId.Text.Trim()}'";
            //    int result = Program.ExecSqlNonQuery(query);
            //    if (result == 1)
            //    {

            //        FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            //        {
            //            btnNew, btnEdit, btnDelete, btnCommit, btnRefresh, btnUndo
            //        });

            //        pcClass.Enabled = pcStudent.Enabled = false;
            //        gcClassInfo.Enabled = gcStudentInfo.Enabled = true;
            //        checkThemSV = checkSuaSV = checkXoaSV = false;

            //        FormUtils.EnableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
            //        {
            //            btnCtxAddStudent, btnCtxEditStudent, btnCtxMoveStudent, btnCtxDeleteStudent, btnCtxSaveStudent, btnCtxUndoStudent, btnCtxRefreshStudent
            //        });

            //        checkChuyenLop = false;
            //        btnRefresh.PerformClick();
            //    }
            //    else
            //    {
            //        WriteStudent();
            //    }
            //}
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
                    gcClassInfo.Enabled = gcStudentInfo.Enabled = false;

                    FormUtils.DisableMatrixContexMenuItems(ctxMenu, new List<ToolStripMenuItem>
                    {
                        btnCtxAddStudent, btnCtxEditStudent, btnCtxMoveStudent, btnCtxDeleteStudent
                    });

                    teFirstName.Enabled = teLastName.Enabled = deBirthDate.Enabled = teAddress.Enabled = false;
                    cbxStudentClass.Enabled = false;

                    //checkChuyenLop = true;
                    //checkSave = false;
                }
            }
        }

        private void cbxStudentClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    int position = cbxStudentClass.SelectedIndex;
            //    teStudentClassId.Text = ((DataRowView)this.bdsClass[position]).Row["MALOP"].ToString();
            //}
            //catch (Exception ex)
            //{
            //    CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
            //        Translation._errorTitle, $"cbxStudentClass\n{ex.Message}");
            //}
        }

        private void btnMode_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void swMode_Toggled(object sender, EventArgs e)
        {

            ToggleSwitch toggleSwitch = sender as ToggleSwitch;
            if (toggleSwitch.IsOn)
            {
                formMode = FormClassMode.Student;
                pcClass.Enabled = false;
                pcStudent.Enabled = true;

            }
            else
            {
                formMode = FormClassMode.Class;
                pcClass.Enabled = true;
                pcStudent.Enabled = false;
            }

        }

        private void InitializeCallBackActions()
        {
            //Class
            classCallBackActions = new BindingList<CallBackAction>();
            classCallBackActions.RaiseListChangedEvents = true;
            classCallBackActions.ListChanged += new ListChangedEventHandler(classCallBackActions_ListChanged);
            this.bdsClass.ListChanged += new ListChangedEventHandler(bdsClass_ListChanged);
            classCallBackActions_ListChanged(null, null);
            bdsClass_ListChanged(null, null);

            //Student
            studentCallBackActions = new BindingList<CallBackAction>();
            studentCallBackActions.RaiseListChangedEvents = true;
            studentCallBackActions.ListChanged += new ListChangedEventHandler(studentCallBackActions_ListChanged);
            this.bdsStudent.ListChanged += new ListChangedEventHandler(bdsStudent_ListChanged);
            studentCallBackActions_ListChanged(null, null);
            bdsStudent_ListChanged(null, null);
        }

        //Class
        private void bdsClass_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bdsClass.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void classCallBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndo.Enabled = classCallBackActions.Count != 0;
        }

        private void gvClass_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!classActionMode.Equals(ActionMode.Refresh))
            {
                this.bdsClassPosition = this.bdsClass.Position;
            }

            if (this.bdsDepartment.Position >= 0 && this.bdsClass.Position != -1)
            {
                string deparmentId = FormUtils.GetBindingSourceData(this.bdsClass, this.bdsClass.Position, Database.TABLE_CLASS_COL_CLASS_DEPARTMENT_ID);
                int index = this.bdsDepartment.Find(Database.TABLE_DEPT_COL_DEPT_ID, deparmentId);
                cbxDepartment.SelectedIndex = index;
            }
        }

        //Student
        private void bdsStudent_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bdsStudent.Count == 0)
            {
                btnDeleteStudent.Enabled = btnEditStudent.Enabled = false;
            }
            else
            {
                btnDeleteStudent.Enabled = btnEditStudent.Enabled = true;
            }
        }

        private void studentCallBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndoStudent.Enabled = studentCallBackActions.Count != 0;
        }

        private void gvStudent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!studentActionMode.Equals(ActionMode.Refresh))
            {
                this.bdsStudentPosition = this.bdsStudent.Position;
            }

            if (this.bdsClass.Position >= 0 && bdsStudent.Position != -1) //khi có student được chọn
            {
                string classId = FormUtils.GetBindingSourceData(this.bdsStudent, this.bdsStudent.Position, Database.TABLE_STUDENT_COL_STUDENT_CLASS_ID);
                int index = this.bdsClass.Find(Database.TABLE_CLASS_COL_CLASS_ID, classId);
                cbxStudentClass.SelectedIndex = index;
            }

            if (bdsStudent.Position == -1) //khi không có student nào được chọn
            {
                cbxStudentClass.SelectedIndex = -1; //combo class sẽ phải bỏ trống
            }
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboboxEdit = (ComboBoxEdit)sender;
            object editValue = comboboxEdit.EditValue;
            if (comboboxEdit.SelectedItem.ToString() != "System.Data.DataRowView")
            {
                Program.servername = FormUtils.GetBindingSourceData(Program.bdsSubcriber, comboboxEdit.SelectedIndex, Database.VIEW_ALL_LOCATION_COL_LOCATION_SERVER);
                if (comboboxEdit.SelectedIndex != Program.indexCoSo)
                {
                    Program.mlogin = Program.remoteLogin;
                    Program.password = Program.remotePassword;
                }
                else
                {
                    Program.mlogin = Program.mLoginDN;
                    Program.password = Program.passwordDN;
                }
                if (!Program.ConnectDatabase())
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDatabaseConnectErrorMsg, comboboxEdit.SelectedText));
                }
                else
                {
                    this.DataSet.EnforceConstraints = false;

                    this.taClass.Connection.ConnectionString = Program.connstr;
                    this.taClass.Fill(this.DataSet.LOP);

                    this.taStudent.Connection.ConnectionString = Program.connstr;
                    this.taStudent.Fill(this.DataSet.SINHVIEN);

                    this.taDepartment.Connection.ConnectionString = Program.connstr;
                    this.taDepartment.Fill(this.DataSet.KHOA);
                }
            }
        }
    }

    public enum FormClassMode
    {
        Class,
        Student
    }

}

