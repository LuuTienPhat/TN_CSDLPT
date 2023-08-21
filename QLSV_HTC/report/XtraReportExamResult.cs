using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.report
{
    public partial class XtraReportExamResult : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportExamResult()
        {
            InitializeComponent();
        }

        public XtraReportExamResult(string studentId, string subjectId, int numberOfExamTimes)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = studentId;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = subjectId;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = numberOfExamTimes;
            this.sqlDataSource1.Fill();

        }

        //xử lý lựa chọn abcd thành các dòng trong 1 ô trong report
        private void tcChoices_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            // lấy nguồn sự kiện thành tablecell
            XRTableCell cell = sender as XRTableCell;
            // lấy giá trị trong cell
            string choicesString = cell.Report.GetCurrentColumnValue("LUACHON").ToString();
            // phân tách theo dấu ; (khi lấy các lựa chọn trong sql đã concat với ;)
            string[] choices = choicesString.Split(';');
            choicesString = "";
            foreach (string choice in choices)
            {
                choicesString = choicesString + choice + Environment.NewLine;
            }
            //cell.BackColor = Color.Khaki;
            cell.Text = choicesString;
        }
    }
}
