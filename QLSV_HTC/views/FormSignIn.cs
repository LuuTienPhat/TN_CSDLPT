using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLSV_HTC
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
            if (teUsername.Text.Trim().Length == 0)
            {
                teUsername.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._usernameLabel);
                
            }
            if(tePassword.Text.Trim().Length == 0)
            {
                tePassword.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._passwordLabel);
            }
            else
            {
                // lấy mã cơ sở
                // lấy vị trí của mã đã chọn trên combobox
                //Program.MLogin = teUsername.Text;
                //Program.MPassword = tePassword.Text;

                //if(Program.)

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(connectionPublisher.State != ConnectionState.Closed)
            {
                connectionPublisher.Close();
            }

            Application.Exit();
            System.Environment.Exit(1);
        }
    }
}
