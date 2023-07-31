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

namespace TN_CSDLPT
{
    public partial class FormDepartment : DevExpress.XtraEditors.XtraForm
    {
        public FormDepartment()
        {
            InitializeComponent();
        }

        private void kHOABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tN_CSDLPT_PRODDataSet);

        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Fill(this.tN_CSDLPT_PRODDataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.KHOA' table. You can move, or remove it, as needed.
            this.kHOATableAdapter.Fill(this.tN_CSDLPT_PRODDataSet.KHOA);

        }
    }
}