using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TN_CSDLPT.constants;

namespace TN_CSDLPT.views
{
    public partial class FormSignUp : DevExpress.XtraEditors.XtraForm
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string loginName = "";
                string username = teUsername.Text;
                string password = tePassword.Text;
                string role = "";

                if (!checkUsernameAlreadyExists(username))
                {
                    if (!checkLoginNameAlreadyExists(loginName))
                    {
                        string createLoginQuery = string.Format(Database.SP_CREATE_LOGIN, loginName, username, password, role);
                        SqlDataReader myReader = Program.ExecSqlDataReader(createLoginQuery);
                        myReader.Close();

                        CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._infomationTitle, Translation._signUpSuccessfullyMsg);
                    }
                    else
                    {
                        CustomMessageBox.Show(CustomMessageBox.Type.WARNING, Translation._warningTitle, Translation._loginNameExistsMsg);
                    }
                }
                else
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.WARNING, Translation._warningTitle, Translation._userNameExistsMsg);
                }
            }
        }

        private bool ValidateInput()
        {
            bool isValidated = false;

            if (teUsername.Text.Trim().Length == 0)
            {
                isValidated = false;
                teUsername.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._usernameLabel);
            }
            else if (tePassword.Text.Trim().Length == 0)
            {
                isValidated = false;
                tePassword.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._passwordLabel);
            }

            return isValidated;
        }

        private bool checkUsernameAlreadyExists(string username)
        {
            bool exists = false;
            string query = string.Format(Database.SP_CHECK_USERNAME_EXISTS, username);

            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            if (myReader.HasRows)
            {
                exists = true;
                myReader.Close();
            }

            return exists;
        }

        private bool checkLoginNameAlreadyExists(string loginName)
        {
            bool exists = false;
            string query = string.Format(Database.SP_CHECK_LOGINNAME_EXISTS, loginName);

            SqlDataReader myReader = Program.ExecSqlDataReader(query);
            myReader.Read();
            if (myReader.HasRows)
            {
                exists = true;
                myReader.Close();
            }

            return exists;
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            var items = new[] {
                new { Text = "Trường", Value = "TRUONG" },

                };
            var items2 = new[] {
                new { Text = "Cơ sở", Value = "COSO" },
                new { Text = "Giảng viên", Value = "GIANGVIEN" },
                };
            if (Program.mGroup == "TRUONG")
            {
                //cbxLocation.DataSource = items;
            }
            else if (Program.mGroup == "COSO")
            {
                //cbxLocation.DataSource = items2;
            }

            //cbxLocation.SelectedIndex = 0;
        }
    }
}