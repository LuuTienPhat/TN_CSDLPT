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

namespace TN_CSDLPT.views
{
    public partial class FormTest : DevExpress.XtraEditors.XtraForm
    {
        public static List<CauHoi> questionList = new List<CauHoi>();
        System.Timers.Timer timer;
        Boolean isSubmitted = false;
        int h, m, s;

        public FormTest()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Dataset.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.Dataset.BODE);
            this.Dataset.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'Dataset.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.Dataset.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.BODE' table. You can move, or remove it, as needed.
            //this.bODETableAdapter.Fill(this.Dataset.BODE);

            // để khi vừa vào đã ấn thoát thì thoát luôn
            isSubmitted = true;

            FormUtils.FillComboBox(cbxSubject, bdsSubject,
                new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });
            seTotalQuestions.Enabled = seTotalMinutes.Enabled = cbxLevel.Enabled;
            btnSubmit.Enabled = btnStart.Enabled = false;
            deExamDate.DateTime = DateTime.Now;


            //if the login role is TEACHER OR LOCATION
            if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
            {
                gcExaminee.Text = Translation._teacherInfoLabel;
                //lbTitleId.Text = "Teacher Id:";
                lbTitleFullName.Text = Program.mHoTen;
                teId.Text = "";//lấy mã giáo viên

                lbTitleClassname.Text = "";
                lbTitleClassId.Text = "";
                teClassId.Text = "";
                teClassName.Text = "";
            }

            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                teName.Text = Program.mHoTen;
                teId.Text = Program.maSinhVien;
                teClassId.Text = Program.maLop;
                teClassName.Text = Program.tenLop;
            }

        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;
        }

        private void onTimeEvent(object sender, ElapsedEventArgs e)
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

        private bool CommitExamDetail()
        {
            bool commitSucessfully = false;

            if (Program.ConnectDatabase())
            {

                SqlTransaction trans = Program.databaseConnection.BeginTransaction();
                SqlCommand cmd = new SqlCommand(
                        "INSERT INTO CT_BAITHI (CAUSO, MASV, MAMH, LAN, CAUHOI, DACHON) " +
                        " VALUES (@CAUSO, @MASV, @MAMH, @LAN, @CAUHOI, @DACHON)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = Program.databaseConnection;
                cmd.Transaction = trans;
                cmd.Parameters.AddWithValue("@CAUSO", DbType.Int16);
                cmd.Parameters.AddWithValue("@MASV", DbType.String);
                cmd.Parameters.AddWithValue("@MAMH", DbType.String);
                cmd.Parameters.AddWithValue("@LAN", DbType.Int16);
                cmd.Parameters.AddWithValue("@CAUHOI", DbType.Int16);
                cmd.Parameters.AddWithValue("@DACHON", DbType.String);

                try
                {
                    foreach (var question in questionList)
                    {
                        cmd.Parameters[0].Value = question.CauSo;
                        cmd.Parameters[1].Value = Program.maSinhVien.Trim();
                        cmd.Parameters[2].Value = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, "MAMH").Trim();
                        cmd.Parameters[3].Value = decimal.ToInt16(seNumberOfExamTimes.Value);
                        cmd.Parameters[4].Value = question.IDDe;
                        cmd.Parameters[5].Value = question.CauDaChon;

                        cmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    commitSucessfully = true;
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsCommitDatabaseErrorMsg, ex.Message));
                }
                finally
                {
                    Program.databaseConnection.Close();
                }

            }
            else
            {

            }
            return commitSucessfully;
        }

        private bool CommitScoreList()
        {
            bool commitSucessfully = false;

            string examDate = DateTimeHelper.DateTimeToString(deExamDate.DateTime, "yyyy-MM-dd");
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID).Trim();

            string query = DatabaseUtils.BuildQuery2(Database.SP_INSERT_SCORE, new string[]
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

            //Nếu là sinh viên thi thì ghi vào DB
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                CommitExamDetail();
                CommitScoreList();
            }

            DialogResult dialogResult = DialogResult.OK;
            double grade = GetGrade();

            if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
            {
                dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_INFORMATION, string.Format(Translation._teacherExamResultMsg, grade));
            }
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_INFORMATION, string.Format(Translation._studentExamResultMsg, grade));

                if (dialogResult == DialogResult.OK)
                {
                    //this.moXtraReportKetQuaThi(); //report
                }
            }

            isSubmitted = true;
            questionList.Clear(); //clear question list

            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                        btnSubmit
                    });

            cbxSubject.Enabled = seNumberOfExamTimes.Enabled = btnFindExam.Enabled = deExamDate.Enabled = true;
            btnStart.Enabled = false;

            //Remove all question carđ
            while (flowLayoutPanel1.Controls.Count > 0)
            {
                flowLayoutPanel1.Controls.RemoveAt(0);
            }

            flowLayoutPanel1.Enabled = false;

            lbTimeLeft.Caption = "00:00:00";
        }

        private void btnSubmit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!checkUserNotChooseAllTheQuestion()) //tất cả đã chọn
            {
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_WARNING, "Confirmation",
                    "You still HAVEN'T finished all question! Are you sure to submit your examination.");
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                else if (dialogResult == DialogResult.OK)
                {
                    FinishExam();
                }

            }

        }

        private double GetGrade()
        {
            double mark = 0;
            double markPerRightAnswer = (double)10 / Decimal.ToDouble(seTotalQuestions.Value);
            foreach (CauHoi question in questionList)
            {
                if (question.CauDaChon == question.CauDapAn)
                {
                    mark = mark + markPerRightAnswer;
                }
            }
            return mark;
        }

        private void btnFindExam_Click(object sender, EventArgs e)
        {
            if (validateSearchExamInput())
            {
                string studentId = Program.maSinhVien.Trim();
                string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
                string examDate = DateTimeHelper.DateTimeToString(deExamDate.DateTime, "yyyy-MM-dd");

                string queryFindExamSubject = "";
                if (Program.mGroup == Database.ROLE_STUDENT)
                {
                    queryFindExamSubject = DatabaseUtils.BuildQuery2(Database.SP_FIND_EXAM_SUBECT, new string[]
                    {
                        studentId, subjectId, examDate, seNumberOfExamTimes.Value.ToString()
                    });
                }

                //nếu là giáo viên thi thử hoặc giáo viên quyền COSO thì tìm môn thi để THI THỬ
                if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
                {
                    queryFindExamSubject = "EXEC SP_TIM_MONTHI_GVTHITHU '" + FormUtils.getSelectedStringOfComboBox(null, cbxSubject, "MAMH") + "', '" +
                        deExamDate.DateTime.ToString("yyyy-MM-dd") + "', " + seNumberOfExamTimes.Value;
                }

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(queryFindExamSubject);
                    Program.myReader.Read();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsExamSubjectNotFoundMsg, ex.Message));
                    Program.myReader.Close();
                    Program.databaseConnection.Close();
                    return;
                }

                try
                {
                    seTotalQuestions.Value = Program.myReader.GetInt16(3);
                    cbxLevel.Text = Program.myReader.GetString(4);
                    seTotalMinutes.Value = Program.myReader.GetInt16(5);
                    btnStart.Enabled = true;
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._examSubjectNotFoundMsg);
                    btnStart.Enabled = false;
                }
                finally
                {
                    Program.myReader.Close();
                    Program.databaseConnection.Close();
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> {
                btnSubmit
            });
            btnFindExam.Enabled = false;

            string studentId = Program.maSinhVien.Trim();
            string subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string queryCheckStudentAlreadyFinisedExam = DatabaseUtils.BuildQuery2(Database.SP_CHECK_STUDENT_ALREADY_FINISHED_EXAM, new string[]
            {
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

            string level = cbxLevel.SelectedText.Trim();
            subjectId = FormUtils.GetBindingSourceData(bdsSubject, cbxSubject.SelectedIndex, Database.TABLE_SUBJECT_COL_SUBJECT_ID);
            string queryRetrieveQuestions = DatabaseUtils.BuildQuery2(Database.SP_GET_QUESTIONS, new string[]
            {
                subjectId, level, seTotalQuestions.Value.ToString()
            });

            try
            {
                Program.myReader = Program.ExecSqlDataReader(queryRetrieveQuestions);
                int i = 0;
                while (Program.myReader.Read())
                {
                    i = i + 1;
                    CauHoi ch = new CauHoi();
                    ch.IDDe = int.Parse(Program.myReader["CAUHOI"].ToString());
                    //ch.IDBaiThi = -1;
                    ch.CauSo = i;
                    ch.NDCauHoi = Program.myReader["NOIDUNG"].ToString();
                    ch.CauA = Program.myReader["A"].ToString();
                    ch.CauB = Program.myReader["B"].ToString();
                    ch.CauC = Program.myReader["C"].ToString();
                    ch.CauD = Program.myReader["D"].ToString();
                    ch.CauDapAn = Program.myReader["DAP_AN"].ToString();

                    questionList.Add(ch);
                    flowLayoutPanel1.Enabled = true;
                    flowLayoutPanel1.Controls.Add(ch);

                }

                int thoiGianGiay = decimal.ToInt16(seTotalMinutes.Value) * 60;

                //thoiGianGiay = 100; // de test

                h = thoiGianGiay / 3600;
                thoiGianGiay = thoiGianGiay - h * 3600;
                m = thoiGianGiay / 60;
                thoiGianGiay = thoiGianGiay - m * 60;
                s = thoiGianGiay;

                timer.Start();

                btnStart.Enabled = false;
                cbxSubject.Enabled = false;
                seNumberOfExamTimes.Enabled = false;
                deExamDate.Enabled = false;
                btnSubmit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm đủ câu, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                btnSubmit.Enabled = false;
                cbxSubject.Enabled = true;
                seNumberOfExamTimes.Enabled = true;
                deExamDate.Enabled = true;
                btnStart.Enabled = false;
                btnFindExam.Enabled = true;
                return;
            }
            finally
            {
                Program.myReader.Close();
                Program.databaseConnection.Close();
            }
            //totalsecs = int.Parse(spinEditThoiGian.Value.ToString()) * 60;
        }

        private void ShowExamResultReport()
        {

        }

        private bool checkUserNotChooseAllTheQuestion()
        {
            bool isAllChosen = true;
            string msg = "NOT answered questions: ";

            foreach (CauHoi question in questionList)
            {
                if (question.CauDaChon.Length == 0)
                {
                    isAllChosen = false;
                    msg += $"{question.CauSo}, ";
                }
            }
            if (!isAllChosen)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.WARNING, "Confirmation!", msg);

            }

            return isAllChosen;
        }

        private void btnExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (isSubmitted == false)
            {
                btnSubmit.PerformClick();
            }

            Dispose();
        }

        private bool validateSearchExamInput()
        {
            bool isValid = false;
            if (deExamDate.Text.Trim().Length == 0)
            {
                isValid = false;
                CustomMessageBox.Show(CustomMessageBox.Type.WARNING, "Please choose Exam Date", "Warning");
            }
            return isValid;
        }

        private bool validateStartExamInput()
        {
            bool isValid = false;


            return isValid;
        }

        private void RetrieveAllQuestion()
        {

        }
    }
}