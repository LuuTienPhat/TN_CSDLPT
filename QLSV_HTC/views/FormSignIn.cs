using DevExpress.XtraEditors;
using TN_CSDLPT.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    public partial class FormSignIn : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection connectionPublisher = new SqlConnection();

        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            //if (ConnectDatabase())
            //{
            //    return;
            //}

            //LayDanhSachPhanManh("SELECT * FROM VIEW_DS_KHOA");

            //Database.servername = cbxDepartment.SelectedItem.ToString();

        }

        private bool ConnectDatabase()
        {
            if (connectionPublisher != null && connectionPublisher.State == ConnectionState.Open)
            {
                connectionPublisher.Close();
            }

            try
            {
                connectionPublisher.ConnectionString = Database.connectionStringPublisher;
                connectionPublisher.Open();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format(Translation._argsDatabaseConnectErrorMsg, ex.Message.ToString()), Translation._errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void LayDanhSachPhanManh(String cmd)
        {
            DataTable dt = new DataTable();
            if (connectionPublisher.State == ConnectionState.Closed)
            {
                connectionPublisher.Open();
            }
            SqlDataAdapter sda = new SqlDataAdapter(cmd, connectionPublisher);
            sda.Fill(dt);
            connectionPublisher.Close();
            //Program.bds_DanhSachPhanManh.DataSource = dt;
            //comboBoxCoSo.DataSource = Program.bds_DanhSachPhanManh;
            //cbxDepartment.DisplayMember = "TENCS";
            //cbxDepartment.ValueMember = "TENSERVER";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Validate the input username and password
            if(ValidateInput())
            {
                // lấy mã cơ sở
                // lấy vị trí của mã đã chọn trên combobox
                //Program.MLogin = teUsername.Text;
                //Program.MPassword = tePassword.Text;

                //if(Program.)

                FormMain formMain = new FormMain();
                this.Hide();
                formMain.Show();


            }
        }

        private bool ValidateInput()
        {
            bool validated = true;
            if (teUsername.Text.Trim().Length == 0)
            {
                teUsername.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._usernameLabel);
                validated = false;
            }
            if (tePassword.Text.Trim().Length == 0)
            {
                tePassword.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._passwordLabel);
                validated = false;
            }
            return validated;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Check connection to database, in case of being actived then close
            if (connectionPublisher.State != ConnectionState.Closed)
            {
                connectionPublisher.Close();
            }

            //Close the application, Shutdown all running threads
            Application.Exit();
            System.Environment.Exit(1);
        }

        private void ceTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (ceTeacher.Checked)
            {
                ceTeacher.CheckState = CheckState.Checked;
                ceStudent.CheckState = CheckState.Unchecked;
                lbUsername.Text = Translation._usernameTeacherLabel;
            }
        }

        private void ceStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (ceStudent.Checked)
            {
                ceStudent.CheckState = CheckState.Checked;
                ceTeacher.CheckState = CheckState.Unchecked;
                lbUsername.Text = Translation._usernameStudentLabel;
            }
        }


    }
}
