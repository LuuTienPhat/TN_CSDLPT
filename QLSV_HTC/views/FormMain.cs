using DevExpress.XtraBars;
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

        public void FormMain_Load(object sender, EventArgs e)
        {
            //nếu là quyền cơ sở thì tất cả đều enable
            this.rpManagement.Visible = true;
            this.rpgSignUp.Visible = true;
            this.rpgTopic.Visible = true;
            this.rpgTeacherRegistration.Visible = true;
            this.rpgExam.Visible = true;

            // vì xem danh sách đăng kí cả 2 cơ sở nên chỉ cho trường xem
            this.rpgExamRegistrationList.Visible = false;
            this.rpgSubjectScoreSheet.Visible = true;

            if (Program.mGroup == Database.ROLE_STUDENT)
            {
                this.rpManagement.Visible = false;
                this.rpgSignUp.Visible = false;
                this.rpgTeacherRegistration.Visible = false;
                this.rpgExam.Visible = true;
                this.rpgSubjectScoreSheet.Visible = false;

                return;
            }

            if (Program.mGroup == Database.ROLE_TEACHER)
            {
                //Managment
                this.rpgSchool.Visible = false;
                this.rpgHuman.Visible = false;
                this.rpgSubject.Visible = false;

                //Report
                this.rpgTeacherRegistration.Visible = false;
                this.rpgExamRegistrationList.Visible = false;

                //System
                this.rpgSignUp.Visible = false;

                return;
            }

            if (Program.mGroup == Database.ROLE_SCHOOL)
            {
                // report danh sách đăng kí thi cả 2 cơ sở, nên chỉ cho trường xem
                this.rpgExamRegistrationList.Visible = true;
                this.rpgExam.Visible = false;

                return;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnSignOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            // lặp qua các form đang mở trên mdi và đóng tất
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
                frm.Close();
            }

            Program.username = "";
            Program.maSinhVien = "";
            Program.mHoTen = "";
            Program.mGroup = "";
            Program.mlogin = "";
            Program.password = "";
            Program.mLoginDN = "";
            Program.passwordDN = "";
            Program.databaseConnection.Close();

            this.Hide();

            Program.formSignIn.tePassword.Text = "";
            Program.formSignIn.Show();
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

        private void btnExamResultReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormExamResult));
            if (frm != null) frm.Activate();
            else
            {
                FormExamResult f = new FormExamResult();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSubjectScoreSheet_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormReportSubjectScoreTable));
            if (frm != null) frm.Activate();
            else
            {
                FormReportSubjectScoreTable f = new FormReportSubjectScoreTable();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnExamRegistrationList_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormRegisterList2Location));
            if (frm != null) frm.Activate();
            else
            {
                FormRegisterList2Location f = new FormRegisterList2Location();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTeacherRegistration_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTeacherRegistration));
            if (frm != null) frm.Activate();
            else
            {
                FormTeacherRegistration f = new FormTeacherRegistration();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoExam_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTest));
            if (frm != null) frm.Activate();
            else
            {
                FormTest f = new FormTest();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCreateLogin_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormSignUp));
            if (frm != null) frm.Activate();
            else
            {
                FormSignUp f = new FormSignUp();
                f.MdiParent = this;
                f.StartPosition = FormStartPosition.CenterScreen;
                f.Show();
            }
        }

        private void btnChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnLocation_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}