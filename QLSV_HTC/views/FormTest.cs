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
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.BODE' table. You can move, or remove it, as needed.
            //this.bODETableAdapter.Fill(this.Dataset.BODE);
            //NOT ALLOW TO RUN BACK
            isSubmitted = true;

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;

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

            this.Dataset.EnforceConstraints = false;
            FormUtils.FillCombobox(cbxSubject, Program.connstr, "", "TENMH");



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
                    //timer.Stop();
                    //if (ghiVaoBangDiem())
                    //{
                    //    MessageBox.Show("Hết giờ, điểm thi: " + tinhDiem());

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Ghi điểm thất bại: " + tinhDiem());
                    //}
                    timer.Stop();
                    if (Program.mGroup == Database.ROLE_STUDENT)
                    {
                        insertExamlDetailTable(); //goi SP

                        //ghiVaoBangDiem();//goi SP
                    }

                    int xemChiTiet = -99;
                    if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
                    {
                        xemChiTiet = (int)MessageBox.Show("Kết quả thi của bạn là: " + GetGrade(), "Thông báo kết quả", MessageBoxButtons.OKCancel);
                    }
                    if (Program.mGroup == Database.ROLE_STUDENT)
                    {
                        xemChiTiet = (int)MessageBox.Show("Kết quả thi của bạn là: " + GetGrade() + "\nNhấn OK để xem chi tiết", "Thông báo kết quả", MessageBoxButtons.OKCancel);
                        if (xemChiTiet == (int)DialogResult.OK)
                        {
                            //this.moXtraReportKetQuaThi(); //report
                        }
                    }

                    isSubmitted = true;

                    FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { btnSubmit });
                    cbxSubject.Enabled = true;
                    seNumberOfTimes.Enabled = true;
                    deExamDate.Enabled = true;
                    btnStart.Enabled = false;
                    btnFindExam.Enabled = true;
                    while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
                    flowLayoutPanel1.Enabled = false;
                    questionList.Clear();
                    lbTimeLeft.Caption = "00:00:00";
                }

            }));
        }

        private void bODEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            //this.bODEBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.Dataset);

        }

        //goi
        private void insertExamlDetailTable()
        {

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
            }

            timer.Stop();

            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                insertExamlDetailTable();
                //ghiVaoBangDiem();
                DialogResult dialogResult = CustomMessageBox.Show(CustomMessageBox.Type.QUESTION_INFORMATION, "Exam Result", $"Your grade is: + {GetGrade()}\nPress OK to see result!");
                if (dialogResult == DialogResult.OK)
                {
                    ShowExamResultReport();
                }
            }

            if (Program.mGroup == Database.ROLE_TEACHER)
            {

            }

            isSubmitted = true;
            btnSubmit.Enabled = false;
            cbxSubject.Enabled = true;
            seNumberOfTimes.Enabled = true;
            deExamDate.Enabled = true;
            btnStart.Enabled = false;
            btnFindExam.Enabled = true;
            while (flowLayoutPanel1.Controls.Count > 0) flowLayoutPanel1.Controls.RemoveAt(0);
            flowLayoutPanel1.Enabled = false;
            questionList.Clear();
            lbTimeLeft.Caption = "00:00:00";

        }

        private double GetGrade()
        {
            double mark = 0;
            double markPerRightAnswer = (double)10 / Decimal.ToDouble(seTotalQuestions.Value);
            foreach (CauHoi ch in questionList)
            {
                if (ch.CauDaChon == ch.CauDapAn)
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
                string query = "EXEC SP_TIM_MONTHI '" + Program.maSinhVien + "', '" + cbxSubject.SelectedItem.ToString() + "', '" +
                    deExamDate.DateTime.ToString("yyyy-MM-dd") + "', " + seNumberOfTimes.Value;

                if (Program.mGroup == Database.ROLE_TEACHER || Program.mGroup == Database.ROLE_LOCATION)
                {
                    query = "EXEC SP_TIM_MONTHI_GVTHITHU '" + FormUtils.getSelectedStringOfComboBox(null, cbxSubject, "MAMH") + "', '" +
                        deExamDate.DateTime.ToString("yyyy-MM-dd") + "', " + seNumberOfTimes.Value;
                }

                try
                {
                    Program.myReader = Program.ExecSqlDataReader(query);
                    Program.myReader.Read();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không tìm thấy môn thi, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    Program.myReader.Close();
                    Program.conn.Close();
                    return;
                }

                Program.myReader.Close();
                Program.conn.Close();

                btnStart.Enabled = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FormUtils.DisableBarMangagerItems(barManager1, new List<BarItem> { btnSubmit });
            btnFindExam.Enabled = false;

            string query = "EXEC SP_KT_SINHVIEN_DATHI '" + Program.maSinhVien.Trim() + "', '" +
                FormUtils.getSelectedStringOfComboBox(null, cbxSubject, "MAMH") + "', " + seNumberOfTimes.Value;

            // chỉ có sinh viên mới kiểm tra xem đã thi k, giáo viên thi thử thì k cần
            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                int executedResult = Program.ExecSqlNonQuery(query);
                if (executedResult == 1)
                {
                    btnFindExam.Enabled = true;
                    return;
                }

            }

            isSubmitted = false;

            query = "EXEC MY_SP_LAY_CAUHOI '" + FormUtils.getSelectedStringOfComboBox(null, cbxLevel, "MAMH").Trim() + "', '" +
              FormUtils.getSelectedStringOfComboBox(null, cbxLevel, "").Trim() + "', " + seNumberOfTimes.Value;
            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
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

                int thoiGianGiay = Decimal.ToInt16(seTotalMinutes.Value) * 60;

                //thoiGianGiay = 100; // de test

                h = thoiGianGiay / 3600;
                thoiGianGiay = thoiGianGiay - h * 3600;
                m = thoiGianGiay / 60;
                thoiGianGiay = thoiGianGiay - m * 60;
                s = thoiGianGiay;

                timer.Start();

                btnStart.Enabled = false;
                cbxSubject.Enabled = false;
                seNumberOfTimes.Enabled = false;
                deExamDate.Enabled = false;
                btnSubmit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tìm đủ câu, hãy thử lại\n" + ex.Message, "", MessageBoxButtons.OK);
                Program.myReader.Close();
                Program.conn.Close();
                btnSubmit.Enabled = false;
                cbxSubject.Enabled = true;
                seNumberOfTimes.Enabled = true;
                deExamDate.Enabled = true;
                btnStart.Enabled = false;
                btnFindExam.Enabled = true;
                return;
            }
            //totalsecs = int.Parse(spinEditThoiGian.Value.ToString()) * 60;

            Program.myReader.Close();
            Program.conn.Close();
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
            if(isSubmitted == false)
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

    }
}