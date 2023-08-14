using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //chỉ có mỗi bảng bộ đề khỏi cần dòng này cũng đc, nhưng thêm vào cho chắc
            this.DataSet.EnforceConstraints = false;

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

            //vì lúc thêm mã giáo viên lấy từ username (mã gv) bên Program.cs, 
            //và lúc sửa thì k cho sửa mã giáo viên nốt, nên ta disable nó từ đầu
            teTeacherId.Enabled = false;
            seQuestionNo.Enabled = false;

            //load danh sách môn học vào comboBox
            //DataTable dt = Program.ExecSqlDataTable("EXEC SP_LAY_DS_MONHOC");
            //comboBoxMaMonHoc.DataSource = dt;
            //comboBoxMaMonHoc.DisplayMember = "MAMH";
            //comboBoxMaMonHoc.DisplayMember = "TENMH";
            //comboBoxMaMonHoc.ValueMember = "MAMH";

            //FormUtils.FillComboBox(cbxSubject, dt, "MAMH");

            DatabaseUtils.FillCbxAnswer(cbxAnswer);
            DatabaseUtils.FillCbxLevel(cbxLevel);

            gcInfo.Enabled = false;

        }

        private void btnNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mode = ActionMode.Add;
            this.bdsTopic.AddNew();

            //string query = "EXEC SP_LAY_STT_CAUHOI_TIEPTHEO";
            //try
            //{
            //    Program.myReader = Program.ExecSqlDataReader(query);
            //    Program.myReader.Read();
            //    int nextQuestionNo = Program.myReader.GetInt32(0);
            //    seQuestionNo.EditValue = nextQuestionNo;
            //    Program.myReader.Close();
            //    Program.databaseConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, $"Can't get next question number\n{ex.Message}");
            //    Program.myReader.Close();
            //    Program.databaseConnection.Close();
            //    return;
            //}

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
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTopic, (int)this.bdsTopic.Current, Database.TABLE_TOPIC_TEACHER_ID).Trim();

            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Edit;

                string subjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_SUBJECT_ID);
                string level = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_LEVEL);
                string answer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER);

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
            //teacher Id không thể sửa, khi thêm mới sẽ lấy từ Program.maGiaoVien
            string oldQuestionNo = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_QUESTION_NO);
            string oldSubjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_SUBJECT_ID);
            string oldLevel = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_LEVEL);
            string oldContent = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_CONTENT);
            string oldAnswerA = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_A);
            string oldAnswerB = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_B);
            string oldAnswerC = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_C);
            string oldAnswerD = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_D);
            string oldAnswer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER);

            if (mode.Equals(ActionMode.Edit))
            {
                if (ValidateInput())
                {
                    string teacherId = teTeacherId.Text.Trim();
                    CommitDB();
                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery(Database.SP_UPDATE_TOPIC, new string[]
                            {
                                oldQuestionNo, oldSubjectId, oldLevel, oldContent, oldAnswerA, oldAnswerB, oldAnswerC, oldAnswerD, oldAnswer, teacherId
                            }) //tính ra khỏi cần sửa mã giáo viên cũng đc, vì có chỉnh sửa gì đâu nó bị disable r mà
                        ));
                }
                else
                {
                    return;
                }

            }
            else if (mode.Equals(ActionMode.Add))
            {
                if (ValidateInput())
                {
                    CommitDB();
                    callBackActions.Add(
                        new CallBackAction(
                            mode,
                            DatabaseUtils.BuildQuery2(Database.SP_DELETE_TOPIC, new string[]
                            {
                                oldQuestionNo
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
            gcTopic.Enabled = true;

            btnRefresh.PerformClick();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            string teacherId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_TEACHER_ID).Trim();
            string questionNo = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_QUESTION_NO);
            if (DoesTeacherAllowToEdit(teacherId))
            {
                mode = ActionMode.Delete;
                //callBackActions.Add(mode);

                DialogResult result = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING,
                    string.Format(Translation._argsDeleteWarningMsg, $"Question No {questionNo}"));

                if (result.Equals(DialogResult.OK))
                {
                    string subjectId = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_SUBJECT_ID);
                    string level = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_LEVEL);
                    string content = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_CONTENT);
                    string a = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_A);
                    string b = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_B);
                    string c = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_C);
                    string d = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER_D);
                    string answer = FormUtils.GetBindingSourceData(this.bdsTopic, this.bdsTopic.Position, Database.TABLE_TOPIC_ANSWER);

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

                        taTopic.Update(this.DataSet.BODE);
                        this.bdsTopic.Position = this.bdsTopic.Find(Database.TABLE_TOPIC_QUESTION_NO, questionNo);
                        return;
                    }

                    mode = ActionMode.None;

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

                int affectedId = Program.myReader.GetInt32(0);
                if (affectedId != -1)
                {
                    this.bdsTopic.Position = this.bdsTopic.Find(Database.TABLE_TOPIC_QUESTION_NO, affectedId);
                }
                btnRefresh.PerformClick();
                callBackActions.RemoveAt(callBackActions.Count - 1); //Remove the last action
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsUndoErrorMsg, ex.Message));
                this.taTopic.Update(this.DataSet.BODE);
            }
            finally
            {
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
        }

        private void btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                mode = ActionMode.Refresh;
                //this.bdsTopic.EndEdit();
                this.taTopic.Connection.ConnectionString = Program.connstr;
                this.taTopic.Fill(this.DataSet.BODE);
                this.bdsTopic.Position = this.position;
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
            bool doesTeacherAllowToEdit = false;
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

        private void CommitDB()
        {
            try
            {
                this.bdsTopic.EndEdit();
                this.bdsTopic.ResetCurrentItem();
                this.taTopic.Connection.ConnectionString = Program.connstr;
                this.taTopic.Update(this.DataSet.BODE);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitErrorMsg, ex.Message));
                this.taTopic.Update(this.DataSet);
            }
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

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboBox = (ComboBoxEdit)sender;
            comboBox.SelectedIndex = 0;
            comboBox.EditValue = 5;

        }

        private void gvTopic_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (!mode.Equals(ActionMode.Refresh))
            {
                this.position = this.bdsTopic.Position;
            }
        }
    }
}
