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

namespace TN_CSDLPT.views
{
    public partial class FormTeacherRegistration : DevExpress.XtraEditors.XtraForm
    {
        int position = -1;
        ActionMode mode = ActionMode.None;
        BindingList<CallBackAction> callBackActions = new BindingList<CallBackAction>();

        public FormTeacherRegistration()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormTeacherRegistration_Load(object sender, EventArgs e)
        {
            FillTables();
            Program.FillLocationCombobox(btnLocation, cbxLocation);
            FormUtils.FillComboBox(cbxTeacher, this.bdsTeacher,
                new string[] { Database.TABLE_TEACHER_COL_TEACHER_ID, Database.TABLE_TEACHER_COL_TEACHER_LASTNAME, Database.TABLE_TEACHER_COL_TEACHER_FIRSTNAME },
                "{0} - {1} {2}");
            FormUtils.FillComboBox(cbxSubject, this.bdsSubject, new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });
            FormUtils.FillComboBox(cbxClass, this.bdsClass, new string[] { Database.TABLE_CLASS_COL_CLASS_ID, Database.TABLE_CLASS_COL_CLASS_NAME });
            DatabaseUtils.FillCbxLevel(cbxLevel);
            FormUtils.SetDefaultPropertiesForSpinEdits(new SpinEdit[] { seNumberOfExamTimes, seTotalMinutes, seTotalQuestions });
            FormUtils.SetDefaultGridView(gvTeacher_Registration);

            if ((Program.mGroup == Database.ROLE_SCHOOL) || (Program.mGroup == Database.ROLE_TEACHER) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else if (Program.mGroup == Database.ROLE_LOCATION)
            {
                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnCancel, btnCommit
                });
            }
            gcInfo.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            this.bdsTeacher_Registration.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcTeacher_Registration.Enabled = false;

            cbxTeacher.SelectedIndex = 0;
            cbxSubject.SelectedIndex = 0;
            cbxClass.SelectedIndex = 0;
            cbxLevel.SelectedIndex = 0;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Edit;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcTeacher_Registration.Enabled = false;
        }

        private void btnCommit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            string oldClassId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID).Trim();
            string oldTeacherId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID).Trim();
            string oldSubjectId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID).Trim();
            string oldLevel = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_LEVEL).Trim();
            string oldExamDate = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_DATE).Trim();
            string oldNumberOfExamTimes = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES).Trim();
            string oldTotalQuestions = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_QUESTIONS).Trim();
            string oldTotalMinutes = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_TIME).Trim();
            string oldExamDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(oldExamDate), "yyyy-MM-dd");

            //không cho sửa mã lớp, mã môn và lần
            string classId = FormUtils.GetBindingSourceData(this.bdsClass, cbxClass.SelectedIndex, Database.TABLE_CLASS_COL_CLASS_ID).Trim();
            string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTeacher, cbxTeacher.SelectedIndex, Database.TABLE_TEACHER_COL_TEACHER_ID).Trim();
            string level = cbxLevel.SelectedItem.ToString();
            string examDate = deExamDate.Text;
            string examDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(examDate), "yyyy-MM-dd");

            // ta k cho sửa lần thi
            string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();
            string totalQuestions = seTotalQuestions.Value.ToString();
            string totalMinutes = seTotalMinutes.Value.ToString();

            //Vadidate Data correct before commit
            //Nếu commit mode là ADD thì kiểm tra xem ĐĂNG KÝ THI đã tồn tại hay chưa trước khi THÊM vào DB
            if (mode.Equals(ActionMode.Add))
            {
                string checkTeacherRegistrationExistsQuery = DatabaseUtils.BuildQuery2(Database.SP_CHECK_TEACHER_REGISTRATION_EXISTS, new string[] {
                    classId, subjectId, numberOfExamTimes, examDateSQLFormat
                });

                int excutedResult = Program.ExecSqlNonQuery(checkTeacherRegistrationExistsQuery);
                if (excutedResult == 1)
                {
                    seNumberOfExamTimes.Focus();
                    return;
                }
                if (excutedResult == 2)
                {
                    seNumberOfExamTimes.Focus();
                    return;
                }
                if (excutedResult == 3)
                {
                    deExamDate.Focus();
                    return;
                }
            }

            //Nếu commit mode là ADD thì kiểm tra xem ĐĂNG KÝ THI đã sửa có hợp lệ hay không trước khi UPDATE trong DB
            if (mode.Equals(ActionMode.Edit))
            {
                string checkUpdateTeacherRegistrationQuery = DatabaseUtils.BuildQuery2(Database.SP_CHECK_UPDATE_TEACHER_REGISTRATION, new string[] {
                    classId, subjectId, numberOfExamTimes, examDateSQLFormat
                });

                int excutedResult = Program.ExecSqlNonQuery(checkUpdateTeacherRegistrationQuery);
                if (excutedResult == 3)
                {
                    deExamDate.Focus();
                    return;
                }
            }

            //Kiểm tra có thể tạo BỘ ĐỀ cho môn học với các thông số đầu vào được hay không?
            string getQuestionsQuery = DatabaseUtils.BuildQuery2(Database.SP_GET_QUESTIONS, new string[] {
                subjectId, level, totalQuestions
            });

            int excutedResult2 = Program.ExecSqlNonQuery(getQuestionsQuery);
            if (excutedResult2 == 1 || excutedResult2 == 2)
            {
                seTotalQuestions.Focus();
                return;
            }

            
            //Tất cả validation phía trên PASSED. Bắt đầu thêm vào DB

            //Do các cbx không được bind data đến grid control mà sử dụng cơ chế riêng để hiển thị dữ liệu,
            //nên trước khi COMMIT ta cần set dữ liệu của combobox vào current binding source. 
            FormUtils.SetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, classId);
            FormUtils.SetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID, teacherId);
            FormUtils.SetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, subjectId);

            if (!CommitDB()) //Save to DB
            {
                return;
            }

            //Add callback
            if (mode.Equals(ActionMode.Add))
            {
                Hashtable refs = new Hashtable();
                refs.Add(Database.TABLE_TEACHER_REGISTRATION, $"class {classId}, subject {subjectId} at ${examDate}, Number of Exam Time: ${numberOfExamTimes}");
                callBackActions.Add(
                    new CallBackAction(
                        mode,
                        DatabaseUtils.BuildQuery(Database.SP_DELETE_TEACHER_REGISTRATION, new string[] {
                            subjectId, classId, numberOfExamTimes
                        }),
                        refs
                    ));
            }

            if (mode.Equals(ActionMode.Edit))
            {
                callBackActions.Add(
                   new CallBackAction(
                       mode,
                       DatabaseUtils.BuildQuery(Database.SP_UPDATE_TEACHER_REGISTRATION, new string[] {
                            oldTeacherId, oldSubjectId, oldClassId, oldLevel, oldExamDateSQLFormat, oldNumberOfExamTimes, oldTotalQuestions, oldTotalMinutes
                       })));
            }


            mode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = false;
            gcTeacher_Registration.Enabled = true;

            btnRefresh.PerformClick();
            this.bdsTeacher_Registration.Position = this.bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES, numberOfExamTimes)
                        + this.bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, classId)
                        + this.bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, subjectId);

        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Delete;

            string classId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID).Trim();
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID).Trim();
            string subjectId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID).Trim();
            string level = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_LEVEL).Trim();
            string examDate = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_DATE).Trim();
            string numberOfExamTimes = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES).Trim();
            string totalQuestions = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_QUESTIONS).Trim();
            string totalMinutes = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_TIME).Trim();
            string examDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(examDate), "yyyy-MM-dd");

            if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                string.Format(Translation._argsDeleteWarningMsg, $"Registration")) == DialogResult.OK)
            {
                try
                {
                    string checkDeleteTeacherRegistrationQuery = DatabaseUtils.BuildQuery2(Database.SP_CHECK_DELETE_TEACHER_REGISTRATION, new string[]
                    {
                        classId, subjectId, numberOfExamTimes, examDateSQLFormat
                    });

                    int executedResult = Program.ExecSqlNonQuery(checkDeleteTeacherRegistrationQuery);
                    if (executedResult == 2)
                    {
                        return;
                    }

                    this.bdsSubject.RemoveCurrent();
                    this.taTeacher_Registration.Connection.ConnectionString = Program.connstr;
                    this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);

                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery2(Database.SP_INSERT_TEACHER_REGISTRATION, new string[] {
                                teacherId, subjectId, classId, level, examDateSQLFormat, numberOfExamTimes, totalQuestions, totalMinutes
                            })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDeleteErrorMsg, ex.Message));
                    //this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);
                    return;
                }
                finally
                {
                    mode = ActionMode.None;
                    btnRefresh.PerformClick();

                    int position = bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES, numberOfExamTimes)
                       + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, classId)
                       + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, subjectId);

                    this.bdsTeacher_Registration.Position = position;
                }
            }

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CallBackAction action = callBackActions[callBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                string registration = action.Reference[Database.TABLE_TEACHER_REGISTRATION].ToString();
                if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                    string.Format(Translation._argsDeleteWarningMsg, $"Registration {registration}")) == DialogResult.Cancel)
                {
                    return;
                }
            };

            try
            {
                Program.myReader = Program.ExecSqlDataReader(action.Query);
                Program.myReader.Read();

                // lấy ra mã sinh viên bị ảnh hưởng khi undo 
                //lay AFFECTED_ID tu sp
                string affected_id = Program.myReader.GetString(0).Trim(); // không dùng
                string affectedSubjectId = Program.myReader.GetString(1).Trim();
                string affectedClassId = Program.myReader.GetString(2).Trim();
                string affectedNumberOfExamTimes = Program.myReader.GetString(3).Trim();

                if (affected_id != "" || affected_id != null)
                {
                    int position = bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES, affectedSubjectId)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, affectedClassId)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, affectedSubjectId);

                    this.bdsTeacher_Registration.Position = position;
                }

                callBackActions.RemoveAt(callBackActions.Count - 1);

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
                //this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);
                return;
            }
            finally
            {
                btnRefresh.PerformClick();
                Program.CloseSqlDataReader();
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode.Equals(ActionMode.Add))
            {
                mode = ActionMode.Cancel;
                this.gvTeacher_Registration.DeleteRow(this.gvTeacher_Registration.FocusedRowHandle);
            }

            mode = ActionMode.Cancel;
            this.bdsTeacher_Registration.CancelEdit();
            this.bdsTeacher_Registration.Position = position;

            gcInfo.Enabled = false;
            gcTeacher_Registration.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnCommit, btnCancel
            });

            mode = ActionMode.None;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;
                this.bdsTeacher_Registration.EndEdit();

                gcTeacher_Registration.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                FillTables();
                this.bdsTeacher_Registration.Position = this.position;

                SplashScreenManager.CloseForm();
                gcTeacher_Registration.Enabled = true;

            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
            finally
            {
                mode = ActionMode.None;
            }
        }

        private bool CommitDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsTeacher_Registration.EndEdit();
                this.bdsTeacher_Registration.ResetCurrentItem();
                this.taTeacher_Registration.Connection.ConnectionString = Program.connstr;
                this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
                //this.taTeacher_Registration.Update(this.DataSet);
            }
            return isCommitted;
        }

        private bool ValidateInput()
        {
            bool isValidated = true;
            int numberOfExamTimes = int.Parse(seNumberOfExamTimes.Value.ToString());
            if (numberOfExamTimes < 1 || numberOfExamTimes > 2)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._incorrectNumberOfExamTimesErrorMsg);
                seNumberOfExamTimes.Focus();
                isValidated = false;
                return isValidated;
            }

            int totalQuestions = int.Parse(seTotalQuestions.Value.ToString());
            if (totalQuestions < 10 || totalQuestions > 100)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._incorrectTotalQuestionErrorMsg);
                isValidated = false;
                seTotalQuestions.Focus();
                return isValidated;
            }

            int examTime = int.Parse(seTotalMinutes.Value.ToString());
            if (examTime < 15)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._incorrectNumberOfExamTimesErrorMsg);
                isValidated = false;
                seTotalMinutes.Focus();
                return isValidated;
            }
            if (deExamDate.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Exam Date"));
                deExamDate.Focus();
                isValidated = false;
                return isValidated;
            }
            if (deExamDate.DateTime.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._noTestHeldOnSundayErrorMsg);
                deExamDate.Focus();
                isValidated = false;
                return isValidated;
            }
            if (deExamDate.DateTime.Date < DateTime.Now.Date)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._invalidExamDateErrorMsg);
                deExamDate.Focus();
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void FillTables()
        {
            this.DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Connection.ConnectionString = Program.connstr;
            this.taClass.Fill(this.DataSet.LOP);
            // TODO: This line of code loads data into the 'DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Connection.ConnectionString = Program.connstr;
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.taTeacher.Connection.ConnectionString = Program.connstr;
            this.taTeacher.Fill(this.DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.taTeacher_Registration.Connection.ConnectionString = Program.connstr;
            this.taTeacher_Registration.Fill(this.DataSet.GIAOVIEN_DANGKY);
        }

        private void InitializeCallBackActions()
        {
            callBackActions = new BindingList<CallBackAction>();
            callBackActions.RaiseListChangedEvents = true;
            callBackActions.ListChanged += new ListChangedEventHandler(callBackActions_ListChanged);
            bdsTeacher_Registration.ListChanged += new ListChangedEventHandler(bdsTeacher_Registration_ListChanged);
            callBackActions_ListChanged(null, null);
            bdsTeacher_Registration_ListChanged(null, null);
        }

        private void bdsTeacher_Registration_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (bdsTeacher_Registration.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void callBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndo.Enabled = callBackActions.Count != 0;
        }

        private void gvTeacher_Registration_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!mode.Equals(ActionMode.Refresh))
            {
                this.position = this.bdsTeacher_Registration.Position;
            }

            if (this.bdsTeacher_Registration.Position >= 0)
            {
                string subjectId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID);
                int subjectPosition = this.bdsSubject.Find(Database.TABLE_SUBJECT_COL_SUBJECT_ID, subjectId);
                cbxSubject.SelectedIndex = subjectPosition;

                string classId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID);
                int classPosition = this.bdsClass.Find(Database.TABLE_CLASS_COL_CLASS_ID, classId);
                cbxClass.SelectedIndex = classPosition;

                string teacherId = FormUtils.GetBindingSourceData(this.bdsTeacher_Registration, this.bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID);
                int teacherPosition = this.bdsTeacher.Find(Database.TABLE_TEACHER_COL_TEACHER_ID, teacherId);
                cbxTeacher.SelectedIndex = teacherPosition;
            }
        }
    }
}