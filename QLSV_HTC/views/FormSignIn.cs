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
using DevExpress.XtraEditors.Controls;
using TN_CSDLPT.constants;
using TN_CSDLPT.utils;

namespace TN_CSDLPT
{
    public partial class FormSignIn : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection databaseConnection = new SqlConnection();

        public FormSignIn()
        {
            InitializeComponent();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            if (IsDatabaseOnline()) //Database online
            {
                RetrieveAllSubcriber();
                FormUtils.FillComboxBox(cbxLocation, Program.bdsSubcriber, Database.VIEW_ALL_LOCATION_COL_LOCATION_NAME);
                Program.servername = FormUtils.GetBindingSourceData(Program.bdsSubcriber, cbxLocation.SelectedIndex, Database.VIEW_ALL_LOCATION_COL_LOCATION_SERVER);

                ceTeacher.Select();

                //set Tooltip for username/student code field
                this.teUsername.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._usernameTeacherLabel);
                this.teUsername.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                //set Tooltip for password field
                this.tePassword.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._passwordLabel);
                this.tePassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            }

        }

        private bool IsDatabaseOnline()
        {
            if (databaseConnection != null && databaseConnection.State == ConnectionState.Open)
            {
                databaseConnection.Close();
            }

            try
            {
                databaseConnection.ConnectionString = Program.connstr_publisher;
                databaseConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format(Translation._argsDatabaseConnectErrorMsg, ex.Message.ToString()),
                    Translation._errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void RetrieveAllSubcriber()
        {
            string queryRetrieveAllLocation = DatabaseUtils.BuildQuery(Database.STATEMENT_SELECT_ALL, Database.VIEW_ALL_LOCATIONS);

            DataTable dt = new DataTable();
            //https://stackoverflow.com/questions/6943933/check-if-sql-connection-is-open-or-closed
            if (databaseConnection.State != ConnectionState.Open)
            {
                databaseConnection.Close();
                databaseConnection.Open();
            }

            SqlDataAdapter sda = new SqlDataAdapter(queryRetrieveAllLocation, databaseConnection);
            sda.Fill(dt);
            databaseConnection.Close();
            Program.bdsSubcriber.DataSource = dt;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                Program.mlogin = teUsername.Text;
                Program.password = tePassword.Text;
                Program.indexCoSo = cbxLocation.SelectedIndex;

                if (ceTeacher.Checked)
                {
                    if (!Program.ConnectDatabase())
                    {
                        return;
                    }
                    else
                    {
                        Program.mLoginDN = Program.mlogin;
                        Program.passwordDN = Program.password;

                        string getTeacherLoginInfoQuery = DatabaseUtils.BuildQuery(Database.SP_GET_TEACHER_LOGIN_INFO, Program.mlogin);
                        Program.myReader = Program.ExecSqlDataReader(getTeacherLoginInfoQuery);

                        if (Program.myReader != null)
                        {
                            Program.myReader.Read();
                            Program.username = Program.myReader.GetString(0);
                            if (Convert.IsDBNull(Program.username))
                            {
                                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, Translation._incorectSignInUsernamePasswordMsg);
                                //MessageBox.Show("Tài khoản bạn dùng không có quyền truy cập dữ liệu\nXem lại tên đăng nhập và mật khẩu", "", MessageBoxButtons.OK);
                                return;
                            }

                            Program.mHoTen = Program.myReader.GetString(1);
                            Program.mGroup = Program.myReader.GetString(2);
                            Program.myReader.Close();
                            Program.conn.Close();

                            Program.formMain.lbUserId.Caption = Program.username;
                            Program.formMain.lbUserFullName.Caption = Program.mHoTen;
                            Program.formMain.lbUserRole.Caption = Program.mGroup;
                        }
                    }
                }

                if (ceStudent.Checked)
                {
                    Program.mlogin = "sv_dungchung";
                    Program.password = "123";
                    if (!Program.ConnectDatabase())
                    {
                        return;
                    }
                    else
                    {
                        Program.mLoginDN = Program.mlogin;
                        Program.passwordDN = Program.password;
                        string strLenh = "EXEC SP_LAY_TT_SV '"
                            + teUsername.Text.Trim() + "', '" + tePassword.Text.Trim() + "'";
                        Program.myReader = Program.ExecSqlDataReader(strLenh);

                        if (Program.myReader != null)
                        {
                            Program.myReader.Read();
                            try
                            {
                                Program.maSinhVien = Program.myReader.GetString(0);
                                Program.mHoTen = Program.myReader.GetString(1);
                                Program.maLop = Program.myReader.GetString(2);
                                Program.tenLop = Program.myReader.GetString(3);
                                Program.mGroup = "SINHVIEN";
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Đăng nhập không thành công, xem lại mã sinh viên và mật khẩu:", "Lỗi", MessageBoxButtons.OK);
                                return;
                            }

                            if (Convert.IsDBNull(Program.username))
                            {
                                MessageBox.Show("Tài khoản bạn dùng không có quyền truy cập dữ liệu\nXem lại tên đăng nhập và mật khẩu", "", MessageBoxButtons.OK);
                                return;
                            }

                            Program.myReader.Close();
                            Program.conn.Close();

                            Program.formMain.lbUserId.Caption = Program.maSinhVien;
                            Program.formMain.lbUserFullName.Caption = Program.mHoTen;
                            Program.formMain.lbUserRole.Caption = Program.mGroup;
                        }
                    }
                }

                this.Hide();
                Program.formMain.FormMain_Load(sender, e);
                Program.formMain.Show();
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
            if (databaseConnection.State != ConnectionState.Closed)
            {
                databaseConnection.Close();
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

                //set Tooltip for username/student code field
                this.teUsername.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._usernameTeacherLabel);
                this.teUsername.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            }
        }

        private void ceStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (ceStudent.Checked)
            {
                ceStudent.CheckState = CheckState.Checked;
                ceTeacher.CheckState = CheckState.Unchecked;
                lbUsername.Text = Translation._usernameStudentLabel;

                //set Tooltip for username/student code field
                this.teUsername.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._usernameStudentLabel);
                this.teUsername.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            }
        }
    }
}
