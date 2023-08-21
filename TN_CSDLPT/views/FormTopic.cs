using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.models;
using TN_CSDLPT.utils;

namespace TN_CSDLPT.views
{
    public partial class FormTopic : DevExpress.XtraEditors.XtraForm
    {
        BindingList<CallBackAction> callBackActions = null;
        ActionMode mode = ActionMode.None;
        int position = -1;

        public FormTopic()
        {
            InitializeComponent();
            InitializeCallBackActions();
        }

        private void FormTopic_Load(object sender, EventArgs e)
        {
            this.DataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);

            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.BODE' table. You can move, or remove it, as needed.
            this.taTopic.Fill(this.DataSet.BODE);

            Program.FillLocationCombobox(btnLocation, cbxLocation);

            if (Program.mGroup == Database.ROLE_SCHOOL || Program.mGroup == Database.ROLE_STUDENT)
            {
                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                });
            }
            else //mGroup == "GIANGVIEN", "COSO" chỉ có quyền giảng viên mới đc thao tác thêm xóa sửa bộ đề
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

            DatabaseUtils.FillCbxAnswer(cbxAnswer);
            DatabaseUtils.FillCbxLevel(cbxLevel);
            FormUtils.FillComboBox(cbxSubject, bdsSubject, new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });

            //vì lúc thêm mã giáo viên lấy từ username (mã gv) bên Program.cs, 
            //và lúc sửa thì k cho sửa mã giáo viên nốt, nên ta disable nó từ đầu
            teTeacherId.Enabled = false;
            seQuestionNo.Enabled = false;

            gcInfo.Enabled = false;



        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            this.bdsTopic.AddNew();

            seQuestionNo.Enabled = false;
            teTeacherId.Enabled = false;

            //mã giáo viên tạo câu hỏi là mã giáo viên đang đăng nhập
            teTeacherId.Text = Program.username;
            cbxSubject.SelectedIndex = 0;
            cbxAnswer.SelectedIndex = 0;
            cbxLevel.SelectedIndex = 0;

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh, btnUndo
            });

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcTopic.Enabled = false;
            gcInfo.Enabled = true;

        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_TEACHER_ID).Trim();

            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Edit;

                string subjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_SUBJECT_ID);
                string level = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_LEVEL);
                string answer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER);

                //UI changed
                cbxSubject.SelectedText = subjectId;
                cbxAnswer.SelectedText = answer;
                cbxLevel.SelectedText = level;

                FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnNew, btnEdit, btnDelete, btnExit, btnRefresh
                });

                FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
                {
                    btnCommit, btnCancel
                });

                teTeacherId.Enabled = false;
                gcTopic.Enabled = false;
                gcInfo.Enabled = true;
            }
        }

        private void btnCommit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //teacher Id không thể sửa, khi thêm mới sẽ lấy từ Program.maGiaoVien
            string oldQuestionNo = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_QUESTION_NO);
            string oldSubjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_SUBJECT_ID);
            string oldLevel = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_LEVEL);
            string oldContent = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_CONTENT);
            string oldAnswerA = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_A);
            string oldAnswerB = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_B);
            string oldAnswerC = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_C);
            string oldAnswerD = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_D);
            string oldAnswer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER);

            string teacherId = teTeacherId.Text.Trim();
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string questionNo = "";

            if (mode.Equals(ActionMode.Add))
            {
                questionNo = GetNextQuestionNo();
                FormUtils.SetBindingSourceData(bdsTopic, bdsTopic.Position, Database.TABLE_TOPIC_COL_QUESTION_NO, questionNo);
            }
            else if (mode.Equals(ActionMode.Edit))
            {
                questionNo = seQuestionNo.Text;
            }

            FormUtils.SetBindingSourceData(bdsTopic, bdsTopic.Position, Database.TABLE_TOPIC_COL_SUBJECT_ID, subjectId);

            if (!CommitDB())
            {
                return;
            }

            if (mode.Equals(ActionMode.Add))
            {
                callBackActions.Add(
                    new CallBackAction(
                        mode,
                        DatabaseUtils.BuildQuery2(Database.SP_DELETE_TOPIC, new string[]
                        {
                                questionNo
                        })
                    ));

            }

            if (mode.Equals(ActionMode.Edit))
            {
                callBackActions.Add(
                    new CallBackAction(
                        mode,
                        DatabaseUtils.BuildQuery(Database.SP_UPDATE_TOPIC, new string[]
                        {
                                oldQuestionNo, oldSubjectId, oldLevel, oldContent, oldAnswerA, oldAnswerB, oldAnswerC, oldAnswerD, oldAnswer, teacherId
                        }) //tính ra khỏi cần sửa mã giáo viên cũng đc, vì có chỉnh sửa gì đâu nó bị disable r mà
                    ));
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
            gcTopic.Enabled = true;

            btnRefresh.PerformClick();
            this.bdsTopic.Position = bdsTopic.Find(Database.TABLE_TOPIC_COL_QUESTION_NO, questionNo);

        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_TEACHER_ID).Trim();
            string questionNo = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_QUESTION_NO);
            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Delete;
                //callBackActions.Add(mode);

                DialogResult result = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                    string.Format(Translation._argsDeleteWarningMsg, $"Question No {questionNo}"));

                if (result.Equals(DialogResult.OK))
                {
                    string subjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_SUBJECT_ID);
                    string level = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_LEVEL);
                    string content = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_CONTENT);
                    string a = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_A);
                    string b = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_B);
                    string c = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_C);
                    string d = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER_D);
                    string answer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_COL_ANSWER);

                    try
                    {
                        this.bdsTopic.RemoveCurrent();
                        taTopic.Connection.ConnectionString = Program.connstr;
                        taTopic.Update(this.DataSet.BODE);

                        callBackActions.Add(
                            new CallBackAction(
                                mode,
                                DatabaseUtils.BuildQuery(Database.SP_INSERT_TOPIC, new string[]
                                {
                                    questionNo, subjectId, level, content, a, b, c, d, answer, teacherId
                                })
                            )
                        );
                    }
                    catch (Exception ex)
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                            string.Format(Translation._argsDeleteErrorMsg, new string[] { $"Question No {questionNo}", ex.Message }));
                        //taTopic.Update(this.DataSet.BODE);
                        return;
                    }
                    finally
                    {
                        mode = ActionMode.None;
                        btnRefresh.PerformClick();
                        this.bdsTopic.Position = this.bdsTopic.Find(Database.TABLE_TOPIC_COL_QUESTION_NO, questionNo);
                    }
                }
            }
        }

        private void btnUndo_ItemClick(object sender, ItemClickEventArgs e)
        {
            CallBackAction action = callBackActions[callBackActions.Count - 1];
            try
            {
                Program.myReader = Program.ExecSqlDataReader(action.Query);
                Program.myReader.Read();

                string affectedId = Program.myReader.GetString(0);
                if (affectedId != "-1")
                {
                    this.bdsTopic.Position = this.bdsTopic.Find(Database.TABLE_TOPIC_COL_QUESTION_NO, affectedId);
                }

                callBackActions.RemoveAt(callBackActions.Count - 1); //Remove the last action
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
            if (mode.Equals(ActionMode.Add))
            {
                gvTopic.DeleteRow(gvTopic.FocusedRowHandle);
            }

            this.bdsTopic.CancelEdit();
            this.bdsTopic.Position = position;

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnNew, btnEdit, btnDelete, btnExit, btnRefresh
            });

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
            {
                btnCommit, btnCancel
            });

            gcInfo.Enabled = false;
            gcTopic.Enabled = true;

            mode = ActionMode.None;
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;

                gcTopic.Enabled = false;
                SplashScreenManager.ShowForm(typeof(WaitRefreshForm));
                System.Threading.Thread.Sleep(1000);

                this.bdsTopic.EndEdit();
                this.taTopic.Connection.ConnectionString = Program.connstr;
                this.taTopic.Fill(this.DataSet.BODE);

                this.bdsTopic.Position = this.position;

                SplashScreenManager.CloseForm();
                gcTopic.Enabled = true;

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

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private bool DoesTeacherAllowToEdit(string teacherId)
        {
            bool doesTeacherAllowToEdit = true;
            if (!teacherId.Equals(Program.username))
            {
                doesTeacherAllowToEdit = false;
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._teacherCannotEditQuestionOfOtherTeacherMsg);
            }
            return doesTeacherAllowToEdit;
        }

        private bool ValidateInput()
        {
            bool isValidated = true;
            if (teQuestion.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Question"));
                isValidated = false;
                return isValidated;
            }

            if (teAnswerA.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer A"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerB.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer B"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerC.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer C"));
                isValidated = false;
                return isValidated;
            }
            if (teAnswerD.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "Answer D"));
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private bool CommitDB()
        {
            bool isCommitted = false;
            try
            {
                this.bdsTopic.EndEdit();
                this.bdsTopic.ResetCurrentItem();
                this.taTopic.Connection.ConnectionString = Program.connstr;
                this.taTopic.Update(this.DataSet.BODE);

                isCommitted = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            }
            return isCommitted;
        }

        private string GetNextQuestionNo()
        {
            string nextQuestionNo = null;
            string getNextQuestionNoQuery = DatabaseUtils.BuildQuery2(Database.SP_GET_NEXT_QUESTION_NO, new string[] { });
            try
            {
                Program.myReader = Program.ExecSqlDataReader(getNextQuestionNoQuery);
                Program.myReader.Read();
                nextQuestionNo = Program.myReader.GetInt32(0).ToString();
                //nextQuestionNo = Program.myReader.GetInt32(0);
                //seQuestionNo.EditValue = nextQuestionNo;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsFailedToGetNextQuestionNoErrorMsg, ex.Message));
            }
            finally
            {
                Program.CloseSqlDataReader();
            }
            return nextQuestionNo;
        }

        private void InitializeCallBackActions()
        {
            callBackActions = new BindingList<CallBackAction>();
            callBackActions.RaiseListChangedEvents = true;
            callBackActions.ListChanged += new ListChangedEventHandler(callBackActions_ListChanged);
            this.bdsTopic.ListChanged += new ListChangedEventHandler(bdsTopic_ListChanged);
            callBackActions_ListChanged(null, null);
            bdsTopic_ListChanged(null, null);
        }

        private void callBackActions_ListChanged(object sender, ListChangedEventArgs e)
        {
            btnUndo.Enabled = callBackActions.Count != 0;

        }

        private void bdsTopic_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (this.bdsTopic.Count == 0)
            {
                btnDelete.Enabled = btnEdit.Enabled = false;
            }
            else
            {
                btnDelete.Enabled = btnEdit.Enabled = true;
            }
        }

        private void gvTopic_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!mode.Equals(ActionMode.Refresh))
            {
                this.position = this.bdsTopic.Position;
            }
            if (bdsTopic.Position >= 0)
            {
                string subjectId = FormUtils.GetBindingSourceData(bdsTopic, bdsTopic.Position, Database.TABLE_TOPIC_COL_SUBJECT_ID);
                int index = bdsSubject.Find(Database.TABLE_SUBJECT_COL_SUBJECT_ID, subjectId);
                cbxSubject.SelectedIndex = index;
            }

            GridView view = sender as GridView;
            if (e.FocusedRowHandle >= 0)
            {
                string s = view.GetRowCellDisplayText(e.FocusedRowHandle, view.Columns[Database.TABLE_TOPIC_COL_TEACHER_ID]).Trim();
                if (s != Program.username)
                {

                    //gvTopic.Appearance.FocusedRow.BackColor = Color.FromArgb(98, 106, 150);
                    //gvTopic.Appearance.FocusedRow.ForeColor = Color.FromArgb(255, 255, 255);

                    //gvTopic.Appearance.SelectedRow.Assign(gvTopic.Appearance.FocusedRow);
                    //gvTopic.Appearance.FocusedCell.Assign(gvTopic.Appearance.FocusedRow);

                    FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem>
                    {
                        btnNew, btnEdit, btnDelete, btnCommit, btnUndo, btnCancel
                    });
                }
                else
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

                    this.taTopic.Connection.ConnectionString = Program.connstr;
                    this.taTopic.Update(this.DataSet.BODE);
                }
            }
        }

        private void gvTopic_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            GridView view = sender as GridView;
            if (e.RowHandle >= 0)
            {
                string subjectId = view.GetRowCellDisplayText(e.RowHandle, view.Columns[Database.TABLE_TOPIC_COL_TEACHER_ID]).Trim();
                if (subjectId != Program.username)
                {
                    //Skin currentSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
                    //Color color = currentSkin.Colors["Brush Minor"];
                    e.Appearance.BackColor = Color.FromArgb(171, 177, 207);
                    //e.Appearance.ForeColor = Color.FromArgb(255, 255, 255);
                }
            }
        }
    }
}
