using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
using TN_CSDLPT.models;
using TN_CSDLPT.utils;

namespace TN_CSDLPT.views
{
    public partial class FormSignUp : DevExpress.XtraEditors.XtraForm
    {
        List<UserRole> userRoles = new List<UserRole>();

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                UserRole schoolRole = new UserRole("Trường", Database.ROLE_SCHOOL);
                userRoles.Add(schoolRole);
            }
            else if (Program.mGroup == Database.ROLE_LOCATION)
            {
                UserRole locationRole = new UserRole("Cơ sở", Database.ROLE_LOCATION);
                UserRole teacherRole = new UserRole("Giảng viên", Database.ROLE_TEACHER);
                userRoles.Add(locationRole);
                userRoles.Add(teacherRole);
            }

            ComboBoxItemCollection itemsCollection = cbxRole.Properties.Items;
            itemsCollection.BeginUpdate();
            try
            {
                foreach (UserRole userRole in userRoles)
                {
                    itemsCollection.Add(userRole.Text);
                }

            }
            finally
            {
                itemsCollection.EndUpdate();
                cbxRole.SelectedIndex = 0;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {

                string loginName = teLoginName.Text; //loginName
                string teacherId = teTeacherID.Text; //username
                string password = tePassword.Text;
                string role = userRoles[cbxRole.SelectedIndex].Value.ToString(); //role

                if (CheckUsernameAlreadyExists(teacherId))
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._userNameExistsMsg);
                    return;
                }

                if (CheckLoginNameAlreadyExists(loginName))
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._loginNameExistsMsg);
                    return;
                }

                if (Program.ConnectDatabase())
                {
                    try
                    {
                        string createLoginQuery = string.Format(Database.SP_CREATE_LOGIN, loginName, password, teacherId, role);
                        //Program.myReader = Program.ExecSqlDataReader(createLoginQuery);
                        //Program.myReader.Read();

                        int result = Program.ExecSqlNonQuery(createLoginQuery);
                        if (result == 0)
                        {
                            CustomMessageBox.Show(CustomMessageBox.Type.INFORMATION, Translation._signUpSuccessfullyMsg);
                        }
                        else
                        {
                            CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._signUpFailedMsg);
                        }
                    }

                    catch (Exception)
                    {
                        string deleteLoginQuery = DatabaseUtils.BuildQuery(Database.SP_DELETE_LOGIN, new string[]
                        {
                            loginName, teacherId
                        });
                        Program.ExecSqlNonQuery(deleteLoginQuery);
                    }
                    finally
                    {
                        this.teLoginName.Text = "";
                        this.tePassword.Text = "";
                        this.teTeacherID.Text = "";
                        this.cbxRole.SelectedIndex = 0;
                    }
                }
                else
                {
                    CustomMessageBox.Show(CustomMessageBox.Type.ERROR, string.Format(Translation._argsDatabaseConnectErrorMsg, Program.servername));
                }

            }
        }

        private bool ValidateInput()
        {
            bool isValidated = true;

            if (teLoginName.Text.Trim().Length == 0)
            {
                isValidated = false;
                teLoginName.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._usernameLabel);
            }
            else if (tePassword.Text.Trim().Length == 0)
            {
                isValidated = false;
                tePassword.ErrorText = string.Format(Translation._argsNotEmptyMsg, Translation._passwordLabel);
            }

            return isValidated;
        }

        private bool CheckUsernameAlreadyExists(string username)
        {
            bool exists = false;
            string query = DatabaseUtils.BuildQuery(Database.SP_CHECK_USERNAME_EXISTS, username);

            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    exists = true;

                }
            }
            finally
            {
                Program.myReader.Close();
            }

            return exists;
        }

        private bool CheckLoginNameAlreadyExists(string loginName)
        {
            bool exists = false;
            string query = DatabaseUtils.BuildQuery(Database.SP_CHECK_LOGINNAME_EXISTS, loginName);

            try
            {
                Program.myReader = Program.ExecSqlDataReader(query);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    exists = true;
                }
            }
            finally
            {
                Program.myReader.Close();
            }

            return exists;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


    }
}