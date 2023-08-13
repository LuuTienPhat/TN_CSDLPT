using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TN_CSDLPT.constants;
using TN_CSDLPT.views;

namespace TN_CSDLPT
{
    internal static class Program
    {
        // dùng để thực thi lệnh
        //public static SqlCommand Sqlcmd = new SqlCommand();

        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection databaseConnection = new SqlConnection();

        public static String connstr = "";
        public static String connstr_publisher = "Data Source=MSI;Initial Catalog=TN_CSDLPT_PROD;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TN_CSDLPT_PROD";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123";

        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static String maCoSo = "";
        public static int indexCoSo = -1;

        public static String maSinhVien = "";
        public static String maLop = "";
        public static String tenLop = "";


        public static BindingSource bdsSubcriber = new BindingSource();

        public static FormMain formMain;
        public static FormSignIn formSignIn;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();
            formSignIn = new FormSignIn();
            FormReportSubjectScoreTable formReportSubjectScoreTable = new FormReportSubjectScoreTable();
            Application.Run(formSignIn);
            //Application.Run(formReportSubjectScoreTable);
        }

        public static bool ConnectDatabase()
        {
            bool isConnected = false;

            if (Program.databaseConnection != null && Program.databaseConnection.State == System.Data.ConnectionState.Open)
            {
                Program.databaseConnection.Close();
            }

            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.databaseConnection.ConnectionString = Program.connstr;

                Program.databaseConnection.Open();
                isConnected = true;
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR,
                    string.Format(Translation._argsDatabaseConnectErrorMsg, ex.Message));
            }

            return isConnected;
        }

        public static SqlDataReader ExecSqlDataReader(string query)
        {
            SqlDataReader sqlDataReader = null;

            SqlCommand cmd = new SqlCommand(query, Program.databaseConnection);
            cmd.CommandType = CommandType.Text;
            //https://stackoverflow.com/questions/6943933/check-if-sql-connection-is-open-or-closed
            if (Program.databaseConnection.State != ConnectionState.Open)
            {
                Program.databaseConnection.Close();
                Program.databaseConnection.Open();
            }

            try
            {
                sqlDataReader = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {
                Program.databaseConnection.Close();
                CustomMessageBox.Show(CustomMessageBox.Type.ERROR, ex.Message);
            }

            return sqlDataReader;
        }

        public static bool CloseSqlDataReader()
        {
            bool isClosed = false;
            if (Program.myReader != null)
            {
                Program.myReader.Close();
                isClosed = true;
            }
            if (Program.databaseConnection != null)
            {
                Program.databaseConnection.Close();
            }
            return isClosed;
        }

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            //https://stackoverflow.com/questions/6943933/check-if-sql-connection-is-open-or-closed
            if (Program.databaseConnection.State != ConnectionState.Open)
            {
                Program.databaseConnection.Close();
                Program.databaseConnection.Open();
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd, databaseConnection);
            da.Fill(dt);
            databaseConnection.Close();
            return dt;
        }

        public static int ExecSqlNonQuery(string query)
        {
            //https://stackoverflow.com/questions/6943933/check-if-sql-connection-is-open-or-closed
            if (Program.databaseConnection.State != ConnectionState.Open)
            {
                Program.databaseConnection.Close();
                Program.databaseConnection.Open();
            }
            SqlCommand Sqlcmd = new SqlCommand(query, databaseConnection);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 300;// 5 phut 
            try
            {
                Sqlcmd.ExecuteNonQuery();
                int result = (int)Sqlcmd.Parameters["@RETURN_VALUE"].Value;
                return result;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                databaseConnection.Close();
                return ex.State; // lấy trạng thái lỗi gởi từ RAISERROR trong SQL Server qua
            }
        }

        public static void FillLocationCombobox(BarEditItem button, RepositoryItemComboBox cbxLocation)
        {
            FormUtils.FillComboBox(cbxLocation, Program.bdsSubcriber, Database.VIEW_ALL_LOCATION_COL_LOCATION_NAME);
            button.EditValue = cbxLocation.Items[Program.indexCoSo].ToString();

            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }
    }
}
