using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.report
{
    public partial class XtraReportSubjectGradeSheet : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportSubjectGradeSheet()
        {
            InitializeComponent();
        }

        public XtraReportSubjectGradeSheet(string classId, string subjectId, int numberOfExamTimes)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = classId;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = subjectId;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = numberOfExamTimes;
            this.sqlDataSource1.Fill();
        }

    }
}
