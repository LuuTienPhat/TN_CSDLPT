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
using System.Timers;
using TN_CSDLPT.constants;
using DevExpress.XtraBars;
using TN_CSDLPT.utils;
using System.Data.SqlClient;
using System.Globalization;
using TN_CSDLPT.report;
using DevExpress.XtraReports.UI;
using TN_CSDLPT.models;

namespace TN_CSDLPT.views
{
    public partial class Examination : DevExpress.XtraEditors.XtraForm
    {
        //public static List<CauHoi> questionList = new List<CauHoi>();
        public static List<Question> questionList2 = new List<Question>();
        public int currentQuestion = -1;

        System.Timers.Timer timer;
        Boolean isSubmitted = false;
        int h, m, s;

        public Examination()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            FillTables();
            FormUtils.SetDefaultPropertiesForSpinEdits(new SpinEdit[] { seNumberOfExamTimes });
            FormUtils.FillComboBox(cbxSubject, this.bdsSubject, new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });
            //DatabaseUtils.FillCbxLevel(teLevel);

            // để khi vừa vào đã ấn thoát thì thoát luôn
            isSubmitted = true;

            //if the login role is TEACHER OR LOCATION
            if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
            {
                gcExaminee.Text = Translation._teacherInfoLabel.ToUpper();
                teName.Text = Program.mHoTen;
                teId.Text = Program.username;//lấy mã giáo viên

                lbTitleClassname.Text = "";
                lbTitleClassId.Text = "";
                teClassId.Text = "";
                teClassName.Text = "";
            }

            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                gcExaminee.Text = Translation._studentInfoLabel.ToUpper();
                teName.Text = Program.mHoTen;
                teId.Text = Program.maSinhVien;
                teClassId.Text = Program.maLop;
                teClassName.Text = Program.tenLop;
            }

            teTotalQuestions.Enabled = teTotalMinutes.Enabled = teLevel.Enabled = false;
            btnSubmit.Enabled = btnStart.Enabled = false;
            deExamDate.DateTime = DateTime.Now;
            gcExam.Enabled = false;
            DisableExamControls();

        }

        private void btnFindExam_Click(object sender, EventArgs e)
        {
            if (ValidateSearchExamInput())
            {
                string studentId = Program.maSinhVien.Trim();
                string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
                string examDate = DateTimeHelper.DateTimeToString(deExamDate.DateTime, "yyyy-MM-dd");
                string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();

                string queryFindExamSubject = "";
                //nếu là sinh viên thi thì phải ĐĂNG KÝ được tạo bởi giáo viên
                if (Program.mGroup == Database.ROLE_STUDENT)
                {
                    queryFindExamSubject = DatabaseUtils.BuildQuery2(Database.SP_FIND_EXAM_FOR_STUDENT, new string[]
                    {
                        studentId, subjectId, examDate, numberOfExamTimes
                    });
                }

                //nếu user có quyền GIAOVIEN hoặc COSO => giáo viên thi thử
                if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
                {
                    queryFindExamSubject = DatabaseUtils.BuildQuery2(Database.SP_FIND_EXAM_FOR_TEACHER, new string[]
                    {
                        subjectId, examDate, numberOfExamTimes
                    });
                }

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(queryFindExamSubject);
                    Program.myReader.Read();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsExamSubjectNotFoundMsg, ex.Message));
                    //Program.myReader.Close();
                    //Program.databaseConnection.Close();
                    return;
                }

                try
                {
                    teTotalQuestions.Text = Program.myReader.GetInt16(3).ToString();
                    teLevel.Text = Program.myReader.GetString(4);
                    teTotalMinutes.Text = Program.myReader.GetInt16(5).ToString();

                    CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._examSubjectFoundMsg);
                    btnStart.Enabled = true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._examSubjectNotFoundMsg);
                    btnStart.Enabled = false;
                }
                finally
                {
                    Program.CloseSqlDataReader();
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string studentId = Program.maSinhVien.Trim();
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string level = teLevel.Text;
            string totalQuestions = teTotalQuestions.Text;

            string queryCheckStudentAlreadyFinisedExam = DatabaseUtils.BuildQuery2(Database.SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM, new string[] {
                studentId, subjectId, seNumberOfExamTimes.Value.ToString()
            });

            // chỉ có sinh viên mới kiểm tra xem đã thi k, giáo viên thi thử thì k cần
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                int executedResult = Program.ExecSqlNonQuery(queryCheckStudentAlreadyFinisedExam);
                if (executedResult == 1) //sinh viên đã thi
                {
                    btnFindExam.Enabled = true;
                    return;
                }
                else
                {
                    isSubmitted = false;
                }

            }

            string queryRetrieveQuestions = DatabaseUtils.BuildQuery2(Database.SP_GET_QUESTIONS, new string[]
            {
                subjectId, level, totalQuestions
            });

            try
            {
                Program.myReader = Program.ExecSqlDataReader(queryRetrieveQuestions);
                int i = 0;
                while (Program.myReader.Read())
                {
                    //i = i + 1;
                    //CauHoi ch = new CauHoi();
                    //ch.IDDe = int.Parse(Program.myReader["CAUHOI"].ToString());
                    ////ch.IDBaiThi = -1;
                    //ch.CauSo = i;
                    //ch.NDCauHoi = Program.myReader["NOIDUNG"].ToString();
                    //ch.CauA = Program.myReader["A"].ToString();
                    //ch.CauB = Program.myReader["B"].ToString();
                    //ch.CauC = Program.myReader["C"].ToString();
                    //ch.CauD = Program.myReader["D"].ToString();
                    //ch.CauDapAn = Program.myReader["DAP_AN"].ToString();

                    //questionList.Add(ch);
                    //flowLayoutPanel1.Enabled = true;
                    //flowLayoutPanel1.Controls.Add(ch);

                    Question q = new Question();
                    q.QuestionID = int.Parse(Program.myReader["CAUHOI"].ToString());
                    //ch.IDBaiThi = -1;
                    q.QuestionNo = (i + 1);
                    q.Content = Program.myReader["NOIDUNG"].ToString();
                    q.AnswerA = Program.myReader["A"].ToString();
                    q.AnswerB = Program.myReader["B"].ToString();
                    q.AnswerC = Program.myReader["C"].ToString();
                    q.AnswerD = Program.myReader["D"].ToString();
                    q.Answer = Program.myReader["DAP_AN"].ToString();
                    questionList2.Add(q);
                    i += 1;

                }

                //Add to lcAnswerSheet
                foreach(Question q in questionList2)
                {
                    lcAnswerSheet.Items.Add($"{q.QuestionNo}.");
                }

                //Enable Exam Area Controls
                gcExam.Enabled = true;

                currentQuestion = 0;                
                UpdateWhenClickNextBack(currentQuestion);
                EnableExamControls();


                int thoiGianGiay = Convert.ToInt16(teTotalMinutes.Text) * 60;

                //thoiGianGiay = 100; // de test

                h = thoiGianGiay / 3600;
                thoiGianGiay = thoiGianGiay - h * 3600;
                m = thoiGianGiay / 60;
                thoiGianGiay = thoiGianGiay - m * 60;
                s = thoiGianGiay;

                timer.Start();

                //btnStart.Enabled = false;
                //cbxSubject.Enabled = false;
                //seNumberOfExamTimes.Enabled = false;
                //deExamDate.Enabled = false;
                //btnSubmit.Enabled = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsRetrieveQuestionsErrorMsg, ex.Message));
                //btnSubmit.Enabled = false;
                //cbxSubject.Enabled = true;
                //seNumberOfExamTimes.Enabled = true;
                //deExamDate.Enabled = true;
                //btnStart.Enabled = true;
                //btnFindExam.Enabled = true;
                return;
            }
            finally
            {
                Program.CloseSqlDataReader();
            }

            FormUtils.EnableBarMangagerItems(barManager1, new List<BarItem> {
                btnSubmit
            });
            gcExamInfo.Enabled = false;
            gcFindExam.Enabled = false;
            btnStart.Enabled = false;
            //totalsecs = int.Parse(spinEditThoiGian.Value.ToString()) * 60;
        }

        private void btnSubmit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!checkUserNotChooseAllTheQuestion()) //tất cả đã chọn
            {
                DialogResult dialogResult1 = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, "Confirmation",
                    "You still HAVEN'T finished all question! Are you sure to submit your examination.");
                if (dialogResult1 == DialogResult.Cancel)
                {
                    return;
                }

            }

            DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, "Confirmation",
                   "Are you sure to submit your Exan?");
            if (dialogResult == DialogResult.Cancel)
            {
                return;
            }

            FinishExam();
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isSubmitted == false)
            {
                btnSubmit.PerformClick();
            }

            this.Dispose();
        }

        private bool CommitExamDetail()
        {
            bool commitSucessfully = false;
            string connectionString = Program.connstr;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // tạo transaction
                using (SqlTransaction trans = conn.BeginTransaction())
                {

                    SqlCommand cmd =
                    new SqlCommand(
                        "INSERT INTO CT_BAITHI (CAUSO, MASV, MAMH, LAN, CAUHOI, DACHON) " +
                        " VALUES (@CAUSO, @MASV, @MAMH, @LAN, @CAUHOI, @DACHON)");

                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    cmd.Transaction = trans;
                    cmd.Parameters.AddWithValue("@CAUSO", DbType.Int16);
                    cmd.Parameters.AddWithValue("@MASV", DbType.String);
                    cmd.Parameters.AddWithValue("@MAMH", DbType.String);
                    cmd.Parameters.AddWithValue("@LAN", DbType.Int16);
                    cmd.Parameters.AddWithValue("@CAUHOI", DbType.Int16);
                    cmd.Parameters.AddWithValue("@DACHON", DbType.String);

                    string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();
                    int numberOfExamTimes = decimal.ToInt16(seNumberOfExamTimes.Value);

                    foreach (Question question in questionList2)
                    {
                        cmd.Parameters[0].Value = question.QuestionNo;
                        cmd.Parameters[1].Value = Program.maSinhVien.Trim();
                        cmd.Parameters[2].Value = subjectId;
                        cmd.Parameters[3].Value = numberOfExamTimes;
                        cmd.Parameters[4].Value = question.QuestionID;
                        cmd.Parameters[5].Value = question.SelectedAnswer;

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    commitSucessfully = true;
                }
                conn.Close();
            }


            //if (Program.ConnectDatabase())
            //{

            //    SqlTransaction trans = Program.databaseConnection.BeginTransaction();
            //    SqlCommand cmd = new SqlCommand(
            //            "INSERT INTO CT_BAITHI (CAUSO, MASV, MAMH, LAN, CAUHOI, DACHON) " +
            //            " VALUES (@CAUSO, @MASV, @MAMH, @LAN, @CAUHOI, @DACHON)");

            //    cmd.CommandType = CommandType.Text;
            //    cmd.Connection = Program.databaseConnection;
            //    cmd.Transaction = trans;
            //    cmd.Parameters.AddWithValue("@CAUSO", DbType.Int16);
            //    cmd.Parameters.AddWithValue("@MASV", DbType.String);
            //    cmd.Parameters.AddWithValue("@MAMH", DbType.String);
            //    cmd.Parameters.AddWithValue("@LAN", DbType.Int16);
            //    cmd.Parameters.AddWithValue("@CAUHOI", DbType.Int16);
            //    cmd.Parameters.AddWithValue("@DACHON", DbType.String);

            //    try
            //    {

            //        string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();
            //        int numberOfExamTimes = decimal.ToInt16(seNumberOfExamTimes.Value);

            //        foreach (Question question in questionList2)
            //        {
            //            cmd.Parameters[0].Value = question.QuestionNo;
            //            cmd.Parameters[1].Value = Program.maSinhVien.Trim();
            //            cmd.Parameters[2].Value = subjectId;
            //            cmd.Parameters[3].Value = numberOfExamTimes;
            //            cmd.Parameters[4].Value = question.QuestionID;
            //            cmd.Parameters[5].Value = question.SelectedAnswer;

            //            cmd.ExecuteNonQuery();
            //        }

            //        trans.Commit();
            //        commitSucessfully = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        trans.Rollback();
            //        CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
            //    }
            //    finally
            //    {
            //        Program.databaseConnection.Close();
            //    }

            //}
            //else
            //{

            //}
            return commitSucessfully;
        }

        private bool CommitScoreList()
        {
            bool commitSucessfully = false;

            string examDate = DateTimeHelper.DateTimeToString(deExamDate.DateTime, "yyyy-MM-dd");
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();

            string query = DatabaseUtils.BuildQuery2(Database.SP_INSERT_GRADE, new string[]
            {
                Program.maSinhVien.Trim(), subjectId, seNumberOfExamTimes.Value.ToString(), examDate, GetGrade().ToString()
            });

            int result = Program.ExecSqlNonQuery(query);
            if (result == 1) commitSucessfully = true;

            return commitSucessfully;
        }

        private void FinishExam()
        {
            timer.Stop(); //dừng đồng hồ bấm giờ


            //Nếu là sinh viên thi thì ghi vào CT_BAITHI và BANGDIEM
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                CommitExamDetail();
                CommitScoreList();
            }

            DialogResult dialogResult = DialogResult.OK;
            double grade = GetGrade();

            if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
            {
                dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, string.Format(Translation._teacherExamResultMsg, grade));
            }
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, string.Format(Translation._studentExamResultMsg, grade));
            }

            if (dialogResult == DialogResult.OK)
            {
                ShowExamResultReport();
            }

            isSubmitted = true;

            //questionList.Clear(); //clear question list

            //while (flowLayoutPanel1.Controls.Count > 0) //Remove all question carđ
            //{
            //    flowLayoutPanel1.Controls.RemoveAt(0);
            //}

            questionList2.Clear();
            lcAnswerSheet.Items.Clear();

            lbTimeLeft.Caption = "00:00:00";
            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnSubmit
            });

            //flowLayoutPanel1.Enabled = false;
            gcExam.Enabled = false;

            gcFindExam.Enabled = true;
            gcExamInfo.Enabled = true;
            btnStart.Enabled = false;
            btnFindExam.Enabled = true;

            teTotalQuestions.Text = "";
            teTotalMinutes.Text = "";
            teLevel.Text = "";
            DisableExamControls();
            //Exam

        }

        private double GetGrade()
        {
            double mark = 0;
            double markPerRightAnswer = (double)10 / Convert.ToDouble(teTotalQuestions.Text);
            //foreach (CauHoi question in questionList)
            //{
            //    if (question.CauDaChon == question.CauDapAn)
            //    {
            //        mark = mark + markPerRightAnswer;
            //    }
            //}

            foreach (Question question in questionList2)
            {
                if (question.SelectedAnswer == question.Answer)
                {
                    mark += markPerRightAnswer;
                }
            }

            return mark;
        }

        private void ShowExamResultReport()
        {
            string stringFormat = "{0} - {1}";
            string studentId = Program.maSinhVien.Trim();
            string subjectId = FormUtils.GetBindingSourceData(this.bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string subjectName = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_NAME).Trim();
            string examDate = DateTimeHelper.DateTimeToString(deExamDate.DateTime, "yyyy-MM-dd");
            string numberOfExamTimes = seNumberOfExamTimes.Value.ToString();

            XtraReportExamResult ExamResultReport = new XtraReportExamResult(studentId, subjectId, int.Parse(numberOfExamTimes));

            ///xtraReportKQThi.labelTieuDe.Text = "KẾT QUẢ THI MÔN " + this.comboBoxMaMonHoc.Text.Trim() + " CỦA SINH VIÊN " + hoTenSinhVien;
            ExamResultReport.xrlbFullName.Text = Program.mHoTen;
            ExamResultReport.xrlbClass.Text = Program.tenLop;

            ExamResultReport.xrlbExamDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ExamResultReport.xrlbSubject.Text = string.Format(stringFormat, new string[] { subjectId, subjectName });
            ExamResultReport.xrlbNumberOfExamTimes.Text = numberOfExamTimes;

            ReportPrintTool printTool = new ReportPrintTool(ExamResultReport);
            printTool.ShowPreviewDialog();
        }

        private bool checkUserNotChooseAllTheQuestion()
        {
            bool isAllChosen = true;
            string msg = "NOT answered questions: ";

            //foreach (CauHoi question in questionList)
            //{
            //    if (question.CauDaChon.Length == 0)
            //    {
            //        isAllChosen = false;
            //        msg += $"{question.CauSo}, ";
            //    }
            //}

            foreach (Question question in questionList2)
            {
                if (question.SelectedAnswer.Length == 0)
                {
                    isAllChosen = false;
                    msg += $"{question.QuestionNo}, ";
                }
            }

            if (!isAllChosen)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.WARNING, "Confirmation!", msg);

            }

            return isAllChosen;
        }

        private bool ValidateSearchExamInput()
        {
            bool isValidated = true;
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

            int numberOfExamTimes = int.Parse(seNumberOfExamTimes.Value.ToString());
            if (numberOfExamTimes < 1 || numberOfExamTimes > 2)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._incorrectNumberOfExamTimesErrorMsg);
                seNumberOfExamTimes.Focus();
                isValidated = false;
                return isValidated;
            }
            return isValidated;
        }

        private bool validateStartExamInput()
        {
            bool isValid = false;


            return isValid;
        }

        private void RetrieveAllQuestion()
        {

        }

        private void FillTables()
        {
            this.Dataset.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'Dataset.BODE' table. You can move, or remove it, as needed.
            this.taTopic.Connection.ConnectionString = Program.connstr;
            this.taTopic.Fill(this.Dataset.BODE);
            // TODO: This line of code loads data into the 'Dataset.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Connection.ConnectionString = Program.connstr;
            this.taSubject.Fill(this.Dataset.MONHOC);
        }

        private void btnNext_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentQuestion += 1;
            UpdateWhenClickNextBack(currentQuestion);
        }

        private void btnBack_ItemClick(object sender, ItemClickEventArgs e)
        {
            currentQuestion -= 1;
            UpdateWhenClickNextBack(currentQuestion);
        }

        private void UpdateWhenClickNextBack(int currentQuestion)
        {
            Question question = questionList2[currentQuestion];
            lbQuestionNo.Caption = $"Question {question.QuestionNo}";
            lbQuestion.Text = question.Content;
            ceAnswerA.Text = question.AnswerA;
            ceAnswerB.Text = question.AnswerB;
            ceAnswerC.Text = question.AnswerC;
            ceAnswerD.Text = question.AnswerD;

            //Update PageNumber
            lbPage.Caption = $"{question.QuestionNo}/{questionList2.Count}";

            UpdateCheckBox(question.SelectedAnswer);

            if (currentQuestion == questionList2.Count - 1)
            {
                btnNext.Enabled = false;
            }
            else if(currentQuestion != 0)
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
            }

            if (currentQuestion == 0)
            {
                btnBack.Enabled = false;
            }
            else if (currentQuestion != questionList2.Count - 1)
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
            }

            lcAnswerSheet.SelectedIndex = currentQuestion;
        }

        private void ceAnswerA_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAnswerA.Checked)
            {
                UpdateSelectedAnswer("A");
                UpdateCheckBox("A");
            }
            //else
            //{
            //    UpdateSelectedAnswer("");
            //}
            
        }

        private void ceAnswerB_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAnswerB.Checked)
            {
                UpdateSelectedAnswer("B");
                UpdateCheckBox("B");
            }
            //else
            //{
            //    UpdateSelectedAnswer("");
            //}
        }

        private void ceAnswerC_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAnswerC.Checked)
            {
                UpdateSelectedAnswer("C");
                UpdateCheckBox("C");
            }
            //else
            //{
            //    UpdateSelectedAnswer("");
            //}
        }

        private void ceAnswerD_CheckedChanged(object sender, EventArgs e)
        {
            if (ceAnswerD.Checked)
            {
                UpdateSelectedAnswer("D");
                UpdateCheckBox("D");
            }
            //else
            //{
            //    UpdateSelectedAnswer("");
            //}
        }

        private void UpdateSelectedAnswer(string selectedAnswer)
        {
            Question question = questionList2[currentQuestion];
            question.SelectedAnswer = selectedAnswer;
            questionList2[currentQuestion] = question;

            lcAnswerSheet.Items[currentQuestion] = $"{question.QuestionNo}. {question.SelectedAnswer}";

            //UpdateCheckBox(question.SelectedAnswer);
        }

        private void UpdateCheckBox(string selectedAnswer)
        {

            switch (selectedAnswer)
            {
                case "A":
                    ceAnswerA.Checked = true;
                    ceAnswerB.Checked = ceAnswerC.Checked = ceAnswerD.Checked = false;
                    break;
                case "B":
                    ceAnswerB.Checked = true;
                    ceAnswerA.Checked = ceAnswerC.Checked = ceAnswerD.Checked = false;
                    break;
                case "C":
                    ceAnswerC.Checked = true;
                    ceAnswerA.Checked = ceAnswerB.Checked = ceAnswerD.Checked = false;
                    break;
                case "D":
                    ceAnswerD.Checked = true;
                    ceAnswerA.Checked = ceAnswerB.Checked = ceAnswerC.Checked = false;
                    break;
                default:
                    ceAnswerA.Checked = ceAnswerB.Checked = ceAnswerC.Checked = ceAnswerD.Checked = false;
                    break;
            }

        }

        private void lcAnswerSheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lcAnswerSheet.SelectedIndex > -1 && lcAnswerSheet.SelectedIndex < questionList2.Count)
            {
                currentQuestion = lcAnswerSheet.SelectedIndex;
                UpdateWhenClickNextBack(currentQuestion);
            }
        }

        private void Examination_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnSubmit.PerformClick();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
        {
            if (IsHandleCreated)
            {
                Invoke(new Action(() =>
                {
                    if (s == 0)
                    {
                    }
                    else
                    {
                        s = s - 1;
                    }

                    if (s == 0 && m > 0)
                    {
                        s = 59;
                        m = m - 1;
                    }
                    if (m == 0 && h > 0)
                    {
                        m = 59;
                        h = h - 1;
                    }

                    lbTimeLeft.Caption = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
                    // khi hết giờ
                    if (h == 0 && m == 0 && s == 0)
                    {
                        FinishExam();
                    }

                }));
            }

        }
    
        private void DisableExamControls()
        {
            gcExam.Enabled = false;
            barExamControl.Visible = false;
            pcExam.Visible = false;
            lbQuestion.Visible = false;
            lcAnswerSheet.Visible = false;
        }

        private void EnableExamControls()
        {
            gcExam.Enabled = true;
            barExamControl.Visible = true;
            pcExam.Visible = true;
            lbQuestion.Visible = true;
            lcAnswerSheet.Visible = true;
        }
    }
}