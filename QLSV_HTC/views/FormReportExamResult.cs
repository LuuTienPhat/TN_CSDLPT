﻿using DevExpress.XtraEditors;
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
    public partial class FormReportExamResult : DevExpress.XtraEditors.XtraForm
    {
        public FormReportExamResult()
        {
            InitializeComponent();
        }

        private void FormReportExamResult_Load(object sender, EventArgs e)
        {

            FillTableAdapters();
            FillFormComboBoxes();

            Program.FillLocationCombobox(btnLocation, cbxLocation);
            //chỉ trường mới có quyền xem trên cơ sở khác
            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                cbxLocation.Enabled = true;
            }
            else
            {
                cbxLocation.Enabled = false;

            }

            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                cbxStudent.SelectedText = Program.maSinhVien.Trim();
                cbxStudent.Enabled = false;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                FillTableAdapters();
                FillFormComboBoxes();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    string.Format(Translation._argsRefreshErrorMsg, ex.Message));
            }
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
                else
                {
                    FillTableAdapters();
                    FillFormComboBoxes();
                }
            }
        }

        private void FillTableAdapters()
        {
            DataSet.EnforceConstraints = false;
            this.tableAdapterManager.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            this.taStudent.Fill(this.DataSet.SINHVIEN);
            // TODO: This line of code loads data into the 'tN_CSDLPT_PRODDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.taSubject.Fill(this.DataSet.MONHOC);
        }

        private void FillFormComboBoxes()
        {
            FormUtils.FillComboBox(cbxStudent, this.bdsStudent, new string[] { Database.TABLE_STUDENT_COL_STUDENT_ID , Database.TABLE_STUDENT_COL_STUDENT_FIRSTNAME});
            FormUtils.FillComboBox(cbxSubject, this.bdsSubject, new string[] { Database.TABLE_SUBJECT_COL_SUBJECT_ID, Database.TABLE_SUBJECT_COL_SUBJECT_NAME });
        }
    }
}