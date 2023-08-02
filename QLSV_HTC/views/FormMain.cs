﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN_CSDLPT.views
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }

        public void FormMain_Load(object sender, EventArgs e)
        {
            //nếu là quyền cơ sở thì tất cả đều enable


        }

        private void btnSignOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            // lặp qua các form đang mở trên mdi và đóng tất
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }

            //Program.username = "";
            //Program.maSinhVien = "";
            //Program.mHoTen = "";
            //Program.mGroup = "";
            //Program.mlogin = "";
            //Program.password = "";
            //Program.mLoginDN = "";
            //Program.passwordDN = "";
            //Program.conn.Close();
            this.Hide();
            //Program.formDangNhap.textBoxMatKhau.Text = "";
            //Program.formSignIn.Show();
        }

        private void btnSubjectManagement_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSubject));
            if (frm != null) frm.Activate();
            else
            {
                FormSubject f = new FormSubject();
                f.MdiParent = this;
                f.Show();
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


    }
}