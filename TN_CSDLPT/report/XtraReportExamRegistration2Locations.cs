using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace TN_CSDLPT.report
{
    public partial class XtraReportExamRegistration2Locations : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReportExamRegistration2Locations()
        {
            InitializeComponent();
        }

        public XtraReportExamRegistration2Locations(DateTime startDate, DateTime endDate)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = startDate;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = endDate;
            this.sqlDataSource1.Fill();
        }

    }
}
