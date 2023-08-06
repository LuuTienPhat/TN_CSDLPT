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

namespace TN_CSDLPT.views
{
    public partial class FormReportExamResult : DevExpress.XtraEditors.XtraForm
    {
        public FormReportExamResult()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsClass.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormReportExamResult_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.LOP' table. You can move, or remove it, as needed.
            this.taClass.Fill(this.DataSet.LOP);

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }
    }
}