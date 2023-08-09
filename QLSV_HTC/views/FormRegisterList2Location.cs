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
using TN_CSDLPT.constants;

namespace TN_CSDLPT.views
{
    public partial class FormRegisterList2Location : DevExpress.XtraEditors.XtraForm
    {
        public FormRegisterList2Location()
        {
            InitializeComponent();
        }

        private void FormRegisterList2Location_Load(object sender, EventArgs e)
        {
            Program.FillLocationCombobox(btnLocation, cbxLocation);
            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                //chỉ trường mới có quyền xem trên cơ sở khác, nhưng ở đây false luôn vì báo cáo cả 2
                cbxLocation.Enabled = false;
            }
            else
            {
                cbxLocation.Enabled = false;

            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            if(ValidateInput())
            {

            }
        }

        private bool ValidateInput()
        {
            bool isValidated = true;
            if (deFrom.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "From Date"));
                deFrom.Focus();
                isValidated = false;
                return isValidated;
            }

            if (deTo.Text.Trim().Length == 0)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    Translation._errorTitle, string.Format(Translation._argsNotEmptyMsg, "To Date"));
                deTo.Focus();
                isValidated = false;
                return isValidated;
            }

            if (this.deTo.DateTime.Date < this.deFrom.DateTime.Date)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                     Translation._errorTitle, string.Format(Translation._argFieldNotValidErrorMsg, "Form Date"));
                deFrom.Focus();
                return isValidated;
            }
            return isValidated;
        }

        private void cbxLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit comboboxEdit = (ComboBoxEdit)sender;
            if (comboboxEdit.SelectedItem.ToString() != "System.Data.DataRowView")
            {
                Program.servername = FormUtils.GetBindingSourceData(Program.bdsSubcriber, comboboxEdit.SelectedIndex, Database.VIEW_ALL_LOCATION_COL_LOCATION_SERVER);
                if (comboboxEdit.SelectedIndex != Program.indexCoSo)
                {
                    Program.mlogin = Program.remoteLogin;
                    Program.password = Program.remotePassword;
                }
                else
                {
                    Program.mlogin = Program.mLoginDN;
                    Program.password = Program.passwordDN;
                }
                if (!Program.ConnectDatabase())
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDatabaseConnectErrorMsg, comboboxEdit.SelectedText));
                }
            }
        }

        
    }
}