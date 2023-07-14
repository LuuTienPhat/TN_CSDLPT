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
    public partial class FormSubject : DevExpress.XtraEditors.XtraForm
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void FormSubject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet.COSO' table. You can move, or remove it, as needed.
            this.cOSOTableAdapter.Fill(this.DataSet.COSO);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void mONHOCBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSubject.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DataSet);

        }

        private void btnCommit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void cbxLocation_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }
    }
}