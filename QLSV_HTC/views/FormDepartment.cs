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
            this.bdsDepartment.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.COSO' table. You can move, or remove it, as needed.
            this.taLocation.Fill(this.DataSet.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.taTeacher.Fill(this.DataSet.GIAOVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.KHOA' table. You can move, or remove it, as needed.
            this.taDepartment.Fill(this.DataSet.KHOA);

        }

        private void gcTeacherInfo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}