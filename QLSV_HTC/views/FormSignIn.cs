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
            if (ConnectDatabase()) //Database connected successfully
            {
                LayDanhSachPhanManh(string.Format(Database.STATEMENT_SELECT_ALL, Database.VIEW_ALL_LOCATIONS));
                Program.servername = cbxLocation.SelectedText.ToString();
                ceTeacher.Select();

                //set Tooltip for username/student code field
                this.teUsername.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._usernameTeacherLabel);
                this.teUsername.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;

                //set Tooltip for password field
                this.tePassword.ToolTip = string.Format(Translation._argsInputFieldTooltipMsg, Translation._passwordLabel);
                this.tePassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            }

        }

        /// <summary>
        /// Check connetion to database is opened or not
        /// </summary>
        /// <returns> true if connected to dabase successfully; otherwise, false.</returns>
        private bool ConnectDatabase()
        {
            if (connectionPublisher != null && connectionPublisher.State == ConnectionState.Open)
            {
                connectionPublisher.Close();
            }

            try
            {
                connectionPublisher.ConnectionString = Program.connstr_publisher;
                connectionPublisher.Open();
                return true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format(Translation._argsDatabaseConnectErrorMsg, ex.Message.ToString()),
                    Translation._errorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Program.bds_DanhSachPhanManh.DataSource = dt;

            Program.FillComboxBox(cbxLocation, Program.bds_DanhSachPhanManh, "TENCS");
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Validate the input username and password
            if (ValidateInput())
            {
                // lấy mã cơ sở
                // lấy vị trí của mã đã chọn trên combobox
                Program.mlogin = teUsername.Text.Trim();
                Program.indexCoSo = cbxLocation.SelectedIndex;

                if (ceTeacher.Checked)
                {
                    Program.mlogin = teUsername.Text.Trim();
                    Program.password = tePassword.Text.Trim();
                    if (Program.ConnectDatabase())
                    {
                        Program.mLoginDN = Program.mlogin;
                        Program.passwordDN = Program.password;
                        string query = "EXEC SP_LAY_TT_GIANGVIEN_LOGIN '" + Program.mlogin + "'";
                        Program.myReader = Program.ExecSqlDataReader(query);

                        if (Program.myReader != null)
                        {
                            Program.myReader.Read();
                            Program.username = Program.myReader.GetString(0);
                            if (Convert.IsDBNull(Program.username))
                            {
                                MessageBox.Show("Tài khoản bạn dùng không có quyền truy cập dữ liệu\nXem lại tên đăng nhập và mật khẩu", "", MessageBoxButtons.OK);
                                return;
                            }

                            Program.mHoTen = Program.myReader.GetString(1);
                            Program.mGroup = Program.myReader.GetString(2);
                            Program.myReader.Close();
                            Program.conn.Close();


                        }
                    }

                    return;
                }

                if (ceStudent.Checked)
                {
                    Program.mlogin = "sv_dungchung";
                    Program.password = "123";
                    if (Program.ConnectDatabase())
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

                            //Program.formChinh.toolStripMaUser.Text = Program.maSinhVien;
                            //Program.formChinh.toolStripHoTen.Text = Program.mHoTen;
                            //Program.formChinh.toolStripNhomPhanQuyen.Text = Program.mGroup;
                        }
                    }

                    return;
                }
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
