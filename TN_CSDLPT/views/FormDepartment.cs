using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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
using TN_CSDLPT.views;

namespace TN_CSDLPT
{
    public partial class FormDepartment : DevExpress.XtraEditors.XtraForm
    {

        public FormDepartmentMode formMode = FormDepartmentMode.Department;

        //dept
        BindingList<CallBackAction> departmentCallBackActions = new BindingList<CallBackAction>();
        ActionMode departmentActionMode = ActionMode.None;
        int bdsDepartmentPosition = -1;

        //teacher
        BindingList<CallBackAction> teacherCallBackActions = new BindingList<CallBackAction>();
        ActionMode teacherActionMode = ActionMode.None;
        int bdsTeacherPosition = -1;

        public FormDepartment()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            this.DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSet.COSO' table. You can move, or remove it, as needed.
            this.taLocation.Connection.ConnectionString = Program.connstr;
            this.taLocation.Fill(this.DataSet.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.taTeacher.Connection.ConnectionString = Program.connstr;
            this.taTeacher.Fill(this.DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.KHOA' table. You can move, or remove it, as needed.
            this.taDepartment.Connection.ConnectionString = Program.connstr;
            this.taDepartment.Fill(this.DataSet.KHOA);

            Program.FillLocationCombobox(btnLocation, cbxLocation);
            FormUtils.FillComboBox(cbxStudentDepartment, this.bdsDepartment, new string[] { Database.TABLE_DEPT_COL_DEPT_ID, Database.TABLE_DEPT_COL_DEPT_ID });
            FormUtils.FillComboBox(cbxDepartmentLocation, this.bdsLocation, new string[] { Database.TABLE_LOCATION_COL_LOCATION_ID, Database.TABLE_LOCATION_COL_LOCATION_NAME });
            FormUtils.SetDefaultForBarManagerBars(barManager1);

            if ((Program.mGroup == Database.ROLE_SCHOOL || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                //class
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });

                //student
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNewTeacher, btnEditTeacher, btnDeleteTeacher, btnCommitTeacher, btnUndoTeacher, btnCancelTeacher
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
                    btnNewTeacher, btnEditTeacher, btnDeleteTeacher
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                   btnCancelTeacher, btnCommitTeacher
                });
            }

            gcDepartmentInfo.Enabled = gcTeacherInfo.Enabled = false;
        }

        //dept
        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            departmentActionMode = ActionMode.Add;
            this.bdsDepartment.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcDepartmentInfo.Enabled = true;
            gcDepartment.Enabled = false;
            teDepartmentId.Enabled = true;

            pcTeacher.Enabled = false;

            cbxDepartmentLocation.SelectedIndex = 0;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            departmentActionMode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcDepartmentInfo.Enabled = true;
            teDepartmentId.Enabled = false;
            gcDepartment.Enabled = false;

            pcTeacher.Enabled = false;
        }

        private void btnCommit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateDepartmentInput())
            {
                return;
            }

            string oldDepartmentId = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_ID);
            string oldDepartmentName = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_NAME);
            string oldLocationId = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_LOCATION_ID);

            string departmentId = teDepartmentId.Text;
            string locationId = FormUtils.GetBindingSourceData(this.bdsLocation, cbxDepartmentLocation.SelectedIndex, Database.TABLE_LOCATION_COL_LOCATION_ID);

            FormUtils.SetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_LOCATION_ID, locationId);
            if (!CommitDepartmentDB()) //Write database failed
            {
                return;
            }

            if (departmentActionMode.Equals(ActionMode.Edit))
            {
                departmentCallBackActions.Add(
                    new CallBackAction(departmentActionMode,
                    DatabaseUtils.BuildQuery2(Database.SP_UPDATE_DEPARTMENT, new string[] { oldDepartmentId, oldDepartmentName, oldLocationId })
                    ));
            }

            if (departmentActionMode.Equals(ActionMode.Add))
            {
                Hashtable refs = new Hashtable();
                refs.Add(Database.TABLE_DEPT_COL_DEPT_ID, oldDepartmentId);
                departmentCallBackActions.Add(
                    new CallBackAction(
                        departmentActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_DELETE_DEPARTMENT, new string[] { departmentId }),
                        refs
                    ));

                CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, DatabaseUtils.BuildQuery2(Database.SP_DELETE_DEPARTMENT, new string[] { departmentId }));
            }

            departmentActionMode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcDepartmentInfo.Enabled = false;
            gcDepartment.Enabled = true;
            pcTeacher.Enabled = true;

            btnRefresh.PerformClick();
            this.bdsDepartment.Position = bdsDepartment.Find(Database.TABLE_DEPT_COL_DEPT_ID, departmentId);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            departmentActionMode = ActionMode.Delete;
            if (this.bdsTeacher.Count > 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, "Deparment couldn't be deleted, already have teachers");
                return;
            }
            string departmentId = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_ID);
            string departmentName = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_NAME);
            string locationId = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_LOCATION_ID);

            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                string.Format(Translation._argsDeleteWarningMsg, $"Department {departmentName.Trim()}")) == DialogResult.OK)
            {
                try
                {
                    this.bdsDepartment.RemoveCurrent();
                    this.taDepartment.Connection.ConnectionString = Program.connstr;
                    this.taDepartment.Update(this.DataSet.KHOA);

                    departmentCallBackActions.Add(
                        new CallBackAction(
                            departmentActionMode,
                            DatabaseUtils.BuildQuery2(Database.SP_INSERT_DEPARTMENT, new string[] { departmentId, departmentName, locationId })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                        string.Format(Translation._argsDeleteErrorMsg, new string[] { $"Department {departmentName.Trim()}", ex.Message }));
                    //this.taSubject.Update(this.DataSet.MONHOC);
                    return;
                }
                finally
                {
                    departmentActionMode = ActionMode.None;
                    btnRefresh.PerformClick();
                    this.bdsDepartment.Position = this.bdsDepartment.Find(Database.TABLE_DEPT_COL_DEPT_ID, departmentId);
                }
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CallBackAction action = departmentCallBackActions[departmentCallBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string classId = action.Reference[Database.TABLE_DEPT_COL_DEPT_ID].ToString();
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                    string.Format(Translation._argsDeleteWarningMsg, $"Department {classId.Trim()}"));

                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
            }

            try
            {
                Program.myReader = Program.ExecSqlDataReader(action.Query);
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, action.Query);
                Program.myReader.Read();

                string affectedId = Program.myReader.GetString(0);
                if (affectedId != "-1")
                {
                    this.bdsDepartment.Position = this.bdsDepartment.Find(Database.TABLE_DEPT_COL_DEPT_ID, affectedId);
                }

                departmentCallBackActions.RemoveAt(departmentCallBackActions.Count - 1);
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

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (departmentActionMode.Equals(ActionMode.Add))
            {
                departmentActionMode = ActionMode.Cancel;
                gvDepartment.DeleteRow(gvDepartment.FocusedRowHandle);
            }

            departmentActionMode = ActionMode.Cancel;
            this.bdsDepartment.CancelEdit();
            this.bdsDepartment.Position = bdsDepartmentPosition;

            gcDepartmentInfo.Enabled = false;
            gcDepartment.Enabled = true;

            pcTeacher.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            departmentActionMode = ActionMode.None;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                departmentActionMode = ActionMode.Refresh;

                gcDepartment.Enabled = false;
                pcTeacher.Enabled = false;

                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                this.bdsDepartment.EndEdit();

                this.taTeacher.Connection.ConnectionString = Program.connstr;
                this.taTeacher.Fill(this.DataSet.GIAOVIEN);

                this.taLocation.Connection.ConnectionString = Program.connstr;
                this.taLocation.Fill(this.DataSet.COSO);

                this.taDepartment.Connection.ConnectionString = Program.connstr;
                this.taDepartment.Fill(this.DataSet.KHOA);
                this.bdsDepartment.Position = this.bdsDepartmentPosition;

                SplashScreenManager.CloseForm();

                gcDepartment.Enabled = true;
                pcTeacher.Enabled = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                departmentActionMode = ActionMode.None;
            }
        }

        private bool ValidateDepartmentInput()
        {
            bool isValidated = true;
            if (teDepartmentId.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Deparment ID"));
                isValidated = false;
                return isValidated;
            }

            if (teDepartmentName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Department Name"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private bool CommitDepartmentDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsDepartment.EndEdit();
                this.bdsDepartment.ResetCurrentItem();
                this.taDepartment.Connection.ConnectionString = Program.connstr;
                this.taDepartment.Update(this.DataSet.KHOA);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            }
            return isCommitted;
        }

        //teacher
        private void btnNewTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teacherActionMode = ActionMode.Add;
            this.bdsTeacher.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewTeacher, btnEditTeacher, btnDeleteTeacher, btnRefreshTeacher, btnUndoTeacher, btnExit
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitTeacher, btnCancelTeacher
            });

            gcTeacherInfo.Enabled = true;
            gcTeacher.Enabled = false;
            teTeacherId.Enabled = true;

            pcDepartment.Enabled = false;

            cbxStudentDepartment.SelectedIndex = 0;
        }

        private void btnEditTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teacherActionMode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewTeacher, btnEditTeacher, btnDeleteTeacher, btnRefreshTeacher, btnUndoTeacher, btnExit
            });


            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitTeacher, btnCancelTeacher
            });

            gcTeacherInfo.Enabled = true;
            gcTeacher.Enabled = false;
            teTeacherId.Enabled = false;

            pcDepartment.Enabled = false;
        }

        private void btnCommitTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateTeacherInput())
            {
                return;
            }

            string oldTeacherId = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_ID);
            string oldLastName = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_LASTNAME);
            string oldFirstName = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_FIRSTNAME);
            string oldAddress = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_ADDRESS);
            string oldDepartmentId = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_DEPARTMENT_ID);

            string teacherId = this.teTeacherId.Text;
            string departmentId = FormUtils.GetBindingSourceData(this.bdsDepartment, cbxStudentDepartment.SelectedIndex, Database.TABLE_DEPT_COL_DEPT_ID);

            FormUtils.SetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_DEPARTMENT_ID, departmentId);
            if (!CommitTeacherDB()) //Write database failed
            {
                return;
            }

            if (teacherActionMode.Equals(ActionMode.Edit))
            {
                teacherCallBackActions.Add(
                    new CallBackAction(
                        teacherActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_UPDATE_TEACHER, new string[]
                        {
                            oldTeacherId, oldLastName, oldFirstName, oldAddress, oldDepartmentId
                        })
                    ));
            }

            if (teacherActionMode.Equals(ActionMode.Add))
            {
                Hashtable refs = new Hashtable();
                refs.Add(Database.TABLE_TEACHER_COL_TEACHER_ID, teacherId);
                teacherCallBackActions.Add(
                    new CallBackAction(
                        teacherActionMode,
                        DatabaseUtils.BuildQuery2(Database.SP_DELETE_TEACHER, new string[] { teacherId }),
                        refs
                    ));
            }

            teacherActionMode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewTeacher, btnEditTeacher, btnDeleteTeacher, btnRefreshTeacher, btnExit
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitTeacher, btnCancelTeacher
            });

            gcTeacherInfo.Enabled = false;
            gcTeacher.Enabled = true;
            pcDepartment.Enabled = true;

            btnRefresh.PerformClick();
            this.bdsTeacher.Position = bdsTeacher.Find(Database.TABLE_TEACHER_COL_TEACHER_ID, teacherId);
        }

        private void btnDeleteTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            teacherActionMode = ActionMode.Delete;
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_ID);
            string lastName = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_LASTNAME);
            string firstName = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_FIRSTNAME);
            string address = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_ADDRESS);
            string departmentId = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_DEPARTMENT_ID);

            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
               string.Format(Translation._argsDeleteWarningMsg, $"Teacher {teacherId.Trim()}")) == DialogResult.OK)
            {

                try
                {
                    this.bdsTeacher.RemoveCurrent();
                    this.taTeacher.Connection.ConnectionString = Program.connstr;
                    this.taTeacher.Update(this.DataSet.GIAOVIEN);

                    teacherCallBackActions.Add(
                        new CallBackAction(
                            teacherActionMode,
                            DatabaseUtils.BuildQuery(Database.SP_INSERT_TEACHER, new string[] { teacherId, lastName, firstName, address, departmentId })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                        string.Format(Translation._argsDeleteErrorMsg, new string[] { $"Teacher {teacherId.Trim()}", ex.Message }));
                    //this.taSubject.Update(this.DataSet.MONHOC);
                    return;
                }
                finally
                {
                    teacherActionMode = ActionMode.None;
                    btnRefreshTeacher.PerformClick();
                    this.bdsTeacher.Position = this.bdsTeacher.Find(Database.TABLE_TEACHER_COL_TEACHER_ID, teacherId);
                }
            }
        }

        private void btnUndoTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CallBackAction action = teacherCallBackActions[teacherCallBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string teacherId = action.Reference[Database.TABLE_CLASS_COL_CLASS_ID].ToString();
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                    string.Format(Translation._argsDeleteWarningMsg, $"Teacher {teacherId}"));
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
                    this.bdsTeacherPosition = this.bdsTeacher.Find(Database.TABLE_CLASS_COL_CLASS_ID, affectedId);
                }

                teacherCallBackActions.RemoveAt(teacherCallBackActions.Count - 1);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
            }

            finally
            {
                btnRefreshTeacher.PerformClick();
                Program.CloseSqlDataReader();
            }
        }

        private void btnCancelTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (teacherActionMode.Equals(ActionMode.Add))
            {
                teacherActionMode = ActionMode.Cancel;
                gvTeacher.DeleteRow(gvTeacher.FocusedRowHandle);
            }

            teacherActionMode = ActionMode.Cancel;
            this.bdsTeacher.CancelEdit();
            this.bdsTeacher.Position = bdsTeacherPosition;

            gcTeacherInfo.Enabled = false;
            gcTeacher.Enabled = true;
            pcDepartment.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNewTeacher, btnEditTeacher, btnDeleteTeacher, btnRefreshTeacher, btnExit
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommitTeacher, btnCancelTeacher
            });

            teacherActionMode = ActionMode.None;
        }

        private void btnRefreshTeacher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.teacherActionMode = ActionMode.Refresh;

                gcTeacher.Enabled = false;
                pcDepartment.Enabled = false;

                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                this.bdsTeacher.EndEdit();
                this.taTeacher.Connection.ConnectionString = Program.connstr;
                this.taTeacher.Fill(this.DataSet.GIAOVIEN);

                this.bdsTeacher.Position = this.bdsTeacherPosition;

                SplashScreenManager.CloseForm();

                gcTeacher.Enabled = true;
                pcDepartment.Enabled = true;

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                this.teacherActionMode = ActionMode.None;
            }
        }

        private bool ValidateTeacherInput()
        {
            bool isValidated = true;
            if (teTeacherId.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Teacher ID"));
                isValidated = false;
                return isValidated;
            }

            if (teTeacherFirstName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "First Name"));
                isValidated = false;
                return isValidated;
            }
            if (teTeacherLastName.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Last Name"));
                isValidated = false;
                return isValidated;
            }
            if (teTeacherAddress.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Address"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private bool CommitTeacherDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsTeacher.EndEdit();
                this.bdsTeacher.ResetCurrentItem();
                this.taTeacher.Connection.ConnectionString = Program.connstr;
                this.taTeacher.Update(this.DataSet.GIAOVIEN);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            }
            return isCommitted;
        }

        private void InitializeCallBackActions()
        {
            //Dept
            departmentCallBackActions = new BindingList<CallBackAction>();
            departmentCallBackActions.RaiseListChangedEvents = true;
            departmentCallBackActions.ListChanged += new ListChangedEventHandler(departmentCallBackActions_ListChanged);
            this.bdsDepartment.ListChanged += new ListChangedEventHandler(bdsDepartment_ListChanged);
            departmentCallBackActions_ListChanged(null, null);
            bdsDepartment_ListChanged(null, null);

            //Teacher
            teacherCallBackActions = new BindingList<CallBackAction>();
            teacherCallBackActions.RaiseListChangedEvents = true;
            teacherCallBackActions.ListChanged += new ListChangedEventHandler(teacherCallBackActions_ListChanged);
            this.bdsTeacher.ListChanged += new ListChangedEventHandler(bdsTeacher_ListChanged);
            teacherCallBackActions_ListChanged(null, null);
            bdsTeacher_ListChanged(null, null);
        }

        //Dept
        private void bdsDepartment_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bdsDepartment.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void departmentCallBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndo.Enabled = departmentCallBackActions.Count != 0;
        }

        private void gvDepartment_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!departmentActionMode.Equals(ActionMode.Refresh))
            {
                this.bdsDepartmentPosition = this.bdsDepartment.Position;
            }

            if (this.bdsLocation.Position >= 0 && this.bdsDepartment.Position != -1)
            {
                string locationId = FormUtils.GetBindingSourceData(this.bdsDepartment, this.bdsDepartment.Position, Database.TABLE_DEPT_COL_DEPT_LOCATION_ID);
                int index = this.bdsLocation.Find(Database.TABLE_LOCATION_COL_LOCATION_ID, locationId);
                cbxDepartmentLocation.SelectedIndex = index;
            }
        }

        //Teacher
        private void bdsTeacher_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((Program.mGroup == Database.ROLE_SCHOOL || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                return;
            }

            if (this.bdsTeacher.Count == 0)
            {
                btnDeleteTeacher.Enabled = btnEditTeacher.Enabled = false;
            }
            else
            {
                btnDeleteTeacher.Enabled = btnEditTeacher.Enabled = true;
            }
        }

        private void teacherCallBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndoTeacher.Enabled = teacherCallBackActions.Count != 0;
        }

        private void gvTeacher_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!teacherActionMode.Equals(ActionMode.Refresh))
            {
                this.bdsTeacherPosition = this.bdsTeacher.Position;
            }

            if (this.bdsDepartment.Position >= 0 && bdsTeacher.Position != -1)
            {
                string departmentId = FormUtils.GetBindingSourceData(this.bdsTeacher, this.bdsTeacher.Position, Database.TABLE_TEACHER_COL_TEACHER_DEPARTMENT_ID);
                int index = this.bdsDepartment.Find(Database.TABLE_DEPT_COL_DEPT_ID, departmentId);
                cbxStudentDepartment.SelectedIndex = index;
            }

            if (bdsTeacher.Position == -1)
            {
                cbxStudentDepartment.SelectedIndex = -1;
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

                    this.taDepartment.Connection.ConnectionString = Program.connstr;
                    this.taDepartment.Fill(this.DataSet.KHOA);

                    this.taTeacher.Connection.ConnectionString = Program.connstr;
                    this.taTeacher.Fill(this.DataSet.GIAOVIEN);
                }
            }
        }
    }

    public enum FormDepartmentMode
    {
        Department,
        Teacher
    }
}