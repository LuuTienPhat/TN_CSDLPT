using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using TN_CSDLPT.views;

namespace TN_CSDLPT
{
    internal static class Program
    {
        // dùng để thực thi lệnh
        //public static SqlCommand Sqlcmd = new SqlCommand();

        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection conn = new SqlConnection();

        //public static SqlDataReader myReader;

        // lưu danh sách các nhóm quyền
        //public static string[] NhomQuyen = new string[3] { "PGV", "KHOA", "PKeToan" };


        //public static SqlConnection conn = new SqlConnection();
        public static String connstr = "";
        public static String connstr_publisher = "Data Source=MSI;Initial Catalog=TN_CSDLPT_PROD;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String servername = "";
        public static String username = "";
        public static String mlogin = "";
        public static String password = "";

        public static String database = "TN_CSDLPT";
        public static String remoteLogin = "HTKN";
        public static String remotePassword = "123456";

        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";
        public static String maCoSo = "";
        public static int indexCoSo = -1;

        public static String maSinhVien = "";
        public static String maLop = "";
        public static String tenLop = "";


        public static BindingSource bds_DanhSachPhanManh = new BindingSource();

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSignIn());
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
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";Password=" + Program.password;
                
                Program.conn.ConnectionString = Program.connstr;

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

        public static void FillComboxBox(ComboBoxEdit comboBox, DataTable dataTable, string rowName)
        {
            ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
            itemsCollection.BeginUpdate();
            try
            {
                foreach (DataRowView item in dataTable.Rows)
                {
                    itemsCollection.Add(item.Row[rowName]);
                }

            }
            finally
            {
                itemsCollection.EndUpdate();
            }
        }


        /// <summary>
        ///     Fill input ComboboxEdit with DataSource and auto select first item if the DataSource was not empty.
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="dataSource"></param>
        /// <param name="rowName">Row </param>
        public static void FillComboxBox(ComboBoxEdit comboBox, BindingSource dataSource, string rowName)
        {
            IList rows = dataSource.List;
            if(rows.Count > 0)
            {
                ComboBoxItemCollection itemsCollection = comboBox.Properties.Items;
                itemsCollection.BeginUpdate();
                try
                {
                    foreach (DataRowView item in rows)
                    {
                        itemsCollection.Add(item.Row[rowName]);
                    }

                }
                finally
                {
                    itemsCollection.EndUpdate();
                    comboBox.SelectedIndex = 0;
                }
            }    
        }
    }
}
