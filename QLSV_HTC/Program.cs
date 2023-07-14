using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace TN_CSDLPT
{
    internal static class Program
    {
        // dùng để thực thi lệnh
        public static SqlCommand Sqlcmd = new SqlCommand();

        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection conn = new SqlConnection();

        public static SqlDataReader MyReader;

        // lưu danh sách các nhóm quyền
        public static string[] NhomQuyen = new string[3] { "PGV", "KHOA", "PKeToan" };

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormSignIn());
        }

        public static bool ConnectDatabase()
        {
            bool isConnected = false;

            if (Program.conn != null && Program.conn.State == System.Data.ConnectionState.Open)
            {
                Program.conn.Close();
            }

            try
            {
                //Program.URL_Connect = "Data Source=" + Program.ServerName + ";Initial Catalog=" +
                //      Program.Database + ";User ID=" +
                //      Program.MLogin + ";Password=" + Program.MPassword;
                //Program.conn.ConnectionString = Program.URL_Connect;

                // mở đối tượng kết nối
                Program.conn.Open();
                isConnected = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(string.Format(Translation._argsDatabaseConnectErrorMsg, ex.Message.ToString()), Translation._errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isConnected;
        }

        public static SqlDataReader ExecSqlDataReader(string query)
        {
            SqlDataReader sqlDataReader = null;

            SqlCommand cmd = new SqlCommand(query, Program.conn);
            cmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();
            }

            try
            {
                sqlDataReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Program.conn.Close();
                XtraMessageBox.Show(ex.ToString(), Translation._errorTitle,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sqlDataReader;
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(string strlenh)
        {

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;// 5 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                return 0;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State; // lấy trạng thái lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }
    }
}
