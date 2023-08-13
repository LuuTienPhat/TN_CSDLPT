using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
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

        private void FormTestPreparation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Fill(this.DataSet.LOP);
            // TODO: This line of code loads data into the 'DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'DataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.taTeacher.Fill(this.DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN_DANGKY' table. You can move, or remove it, as needed.
            this.taTeacher_Registration.Fill(this.DataSet.GIAOVIEN_DANGKY);

            Program.FillLocationCombobox(btnLocation, cbxLocation);


            if (((Program.mGroup == Database.ROLE_SCHOOL) || (Program.mGroup == Database.ROLE_TEACHER)) || (Program.mGroup == Database.ROLE_STUDENT))
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else if (Program.mGroup == Database.ROLE_LOCATION)
            {

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                    btnNew, btnEdit, btnDelete, btnCommit
                });

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                   btnCancel
                });
            }
            gcInfo.Enabled = false;
        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            bdsTeacher_Registration.AddNew();

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = true;
            gcTeacher_Registration.Enabled = true;
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
            string oldClassId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID).Trim();
            string oldTeacherId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID).Trim();
            string oldSubjectId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID).Trim();
            string oldLevel = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_LEVEL).Trim();
            string oldExamDate = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_DATE).Trim();
            string oldNumberOfExamTimes = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES).Trim();
            string oldTotalQuestions = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_QUESTIONS).Trim();
            string oldTotalMinutes = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_TIME).Trim();
            string oldExamDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(oldExamDate), "yyyy-MM-dd");

            if (mode.Equals(ActionMode.Edit))
            {
                if (ValidateInput())
                {
                    //không cho sửa mã lớp, mã môn và lần
                    string classId = cbxClass.SelectedText.Trim();
                    ///string teacherId = cbxTeacher.SelectedText.Trim();
                    string subjectId = cbxSubject.SelectedText.Trim();
                    string level = cbxLevel.SelectedText.Trim();
                    string examDate = deExamDate.Text;
                    string examDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(examDate), "yyyy-MM-dd");

                    // ta k cho sửa lần thi
                    string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();
                    string totalQuestions = seTotalQuestions.Value.ToString();
                    string totalMinutes = seTotalMinutes.Value.ToString();

                    string checkUpdateTeacherRegistrationQuery = DatabaseUtils.BuildQuery2(Database.SP_UPDATE_TEACHER_REGISTRATION, new string[]
                    {
                        classId, subjectId, numberOfExamTimes, examDateSQLFormat
                    });

                    int excutedResult = Program.ExecSqlNonQuery(checkUpdateTeacherRegistrationQuery);
                    if (excutedResult == 3)
                    {
                        deExamDate.Focus();
                        return;
                    }

                    string getQuestionsQuery = DatabaseUtils.BuildQuery2(Database.SP_GET_QUESTIONS, new string[]
                    {
                        subjectId, level, totalQuestions
                    });

                    excutedResult = Program.ExecSqlNonQuery(getQuestionsQuery);
                    if (excutedResult == 1 || excutedResult == 2)
                    {
                        //tự raiserror, ta chỉ cần focus về field nhập
                        seTotalQuestions.Focus();
                        return;
                    }

                    CommitDB();

                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery(Database.SP_UPDATE_TEACHER_REGISTRATION, new string[]
                            {
                                oldTeacherId, oldSubjectId, oldClassId, oldLevel, oldExamDateSQLFormat, oldNumberOfExamTimes, oldTotalQuestions, oldTotalMinutes
                            })));
                }
                else
                {
                    return;
                }
            }

            if (mode.Equals(ActionMode.Add))
            {
                if (ValidateInput())
                {
                    string classId = cbxClass.SelectedText.Trim();
                    string subjectId = cbxSubject.SelectedText.Trim();
                    string level = cbxLevel.SelectedText.Trim();
                    string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();
                    string examDate = deExamDate.Text;
                    string examDateSQLFormat = DateTimeHelper.DateTimeToString(DateTime.Parse(examDate), "yyyy-MM-dd");
                    string totalQuestions = seTotalQuestions.Value.ToString();

                    string checkTeacherRegistrationExsistsQuery = DatabaseUtils.BuildQuery2(Database.SP_UPDATE_TEACHER_REGISTRATION, new string[]
                    {
                        classId, subjectId, numberOfExamTimes, examDateSQLFormat
                    });

                    int excutedResult = Program.ExecSqlNonQuery(checkTeacherRegistrationExsistsQuery);
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

                    string getQuestionsQuery = DatabaseUtils.BuildQuery2(Database.SP_GET_QUESTIONS, new string[]
                    {
                        subjectId, level, totalQuestions
                    });

                    excutedResult = Program.ExecSqlNonQuery(getQuestionsQuery);
                    if (excutedResult == 1 || excutedResult == 2)
                    {
                        //tự raiserror, ta chỉ cần focus về field nhập
                        seTotalQuestions.Focus();
                        return;
                    }

                    CommitDB();

                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery(Database.SP_DELETE_TEACHER_REGISTRATION, new string[]
                            {
                                subjectId, classId, numberOfExamTimes
                            })
                        ));
                }
                else
                {
                    return;
                }
            }

            mode = ActionMode.None;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = false;
            gcTeacher_Registration.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Delete;

            string classId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_CLASS_ID).Trim();
            string teacherId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_TEACHER_ID).Trim();
            string subjectId = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID).Trim();
            string level = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_LEVEL).Trim();
            string examDate = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_DATE).Trim();
            string numberOfExamTimes = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES).Trim();
            string totalQuestions = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_QUESTIONS).Trim();
            string totalMinutes = FormUtils.GetBindingSourceData(bdsTeacher_Registration, bdsTeacher_Registration.Position, Database.TABLE_TEACHER_REGISTRATION_EXAM_TIME).Trim();
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
                    this.taSubject.Connection.ConnectionString = Program.connstr;
                    this.taSubject.Update(this.DataSet.MONHOC);

                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery2(Database.SP_INSERT_TEACHER_REGISTRATION, new string[]
                            {
                                teacherId, subjectId, classId, level, examDateSQLFormat, numberOfExamTimes, totalQuestions, totalMinutes
                            })
                        ));
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDeleteErrorMsg, ex.Message));
                    this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);

                    int position = bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES, numberOfExamTimes)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, classId)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, subjectId);

                    this.bdsTeacher_Registration.Position = position;
                    return;
                }
                mode = ActionMode.None;
            }

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CallBackAction action = callBackActions[callBackActions.Count - 1];
            if (action.BackAction.Equals(ActionMode.Add))
            {
                //string subjectId = action.Reference[Database.TABLE_SUBJECT_COL_SUBJECT_ID].ToString();
                //if (CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, string.Format(Translation._argsDeleteWarningMsg, $"Subject {subjectId}")) == DialogResult.OK)
                //{
                try
                {
                    Program.myReader = Program.ExecSqlDataReader(action.Query);
                    Program.myReader.Read();
                    btnRefresh.PerformClick();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
                    this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);
                    return;
                }
                finally
                {
                    Program.CloseSqlDataReader();
                }

                // lấy ra mã sinh viên bị ảnh hưởng khi undo 
                string affected_id = "";
                string affectedSubjectId = "";
                string affectedClassId = "";
                string affectedNumberOfExamTimes = "";
                try
                {
                    //lay AFFECTED_ID tu sp
                    affected_id = Program.myReader.GetString(0).Trim(); // không dùng
                    affectedSubjectId = Program.myReader.GetString(1).Trim();
                    affectedClassId = Program.myReader.GetString(2).Trim();
                    affectedNumberOfExamTimes = Program.myReader.GetString(3).Trim();
                }
                finally
                {
                    Program.CloseSqlDataReader();
                }

                if (affected_id != "" || affected_id != null)
                {
                    int position = bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_NUMBER_OF_EXAM_TIMES, affectedSubjectId)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_CLASS_ID, affectedClassId)
                        + bdsTeacher_Registration.Find(Database.TABLE_TEACHER_REGISTRATION_SUBJECT_ID, affectedSubjectId);

                    this.bdsTeacher_Registration.Position = position;
                }
                //}
            };
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (mode.Equals(ActionMode.Add))
            {
                gvTeacher_Registration.DeleteRow(gvTeacher_Registration.FocusedRowHandle);
            }
            this.bdsSubject.CancelEdit();

            this.bdsSubject.Position = position;

            gcInfo.Enabled = false;
            gcTeacher_Registration.Enabled = true;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;
                tableAdapterManager.Connection.ConnectionString = Program.connstr;
                this.taTeacher_Registration.Fill(this.DataSet.GIAOVIEN_DANGKY);
                this.bdsTeacher_Registration.Position = this.position;
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

        private void CommitDB()
        {
            try
            {
                this.bdsTeacher_Registration.EndEdit();
                this.bdsTeacher_Registration.ResetCurrentItem();
                this.taTeacher_Registration.Connection.ConnectionString = Program.connstr;
                this.taTeacher_Registration.Update(this.DataSet.GIAOVIEN_DANGKY);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitErrorMsg, ex.Message));
                this.taTeacher_Registration.Update(this.DataSet);
            }
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
                this.position = bdsTeacher_Registration.Position;
            }
        }
    }
}