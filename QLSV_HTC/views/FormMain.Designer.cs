namespace TN_CSDLPT.views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSignOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnLocation = new DevExpress.XtraBars.BarButtonItem();
            this.btnClass = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubjectManagement = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamResultReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnSubjectScoreSheet = new DevExpress.XtraBars.BarButtonItem();
            this.btnExamRegistrationList = new DevExpress.XtraBars.BarButtonItem();
            this.lbUserId = new DevExpress.XtraBars.BarStaticItem();
            this.lbUserFullName = new DevExpress.XtraBars.BarStaticItem();
            this.lbUserRole = new DevExpress.XtraBars.BarStaticItem();
            this.btnTeacherRegistration = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoExam = new DevExpress.XtraBars.BarButtonItem();
            this.btnTopic = new DevExpress.XtraBars.BarButtonItem();
            this.rpSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSignUp = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpManagement = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSchool = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgHuman = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSubject = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgTopic = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpExamination = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgTeacherRegistration = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExam = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpReport = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgSubjectScoreSheet = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgExamRegistrationList = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSignOut,
            this.btnLocation,
            this.btnClass,
            this.btnTeacher,
            this.btnStudent,
            this.btnSubjectManagement,
            this.btnCreateLogin,
            this.btnChangePassword,
            this.btnExamResultReport,
            this.btnSubjectScoreSheet,
            this.btnExamRegistrationList,
            this.lbUserId,
            this.lbUserFullName,
            this.lbUserRole,
            this.btnTeacherRegistration,
            this.btnDoExam,
            this.btnTopic});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rpSystem,
            this.rpManagement,
            this.rpExamination,
            this.rpReport});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1165, 175);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // btnSignOut
            // 
            this.btnSignOut.Caption = "Sign Out";
            this.btnSignOut.Id = 1;
            this.btnSignOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSignOut.ImageOptions.SvgImage")));
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSignOut_ItemClick);
            // 
            // btnLocation
            // 
            this.btnLocation.Caption = "Location";
            this.btnLocation.Id = 2;
            this.btnLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLocation.ImageOptions.SvgImage")));
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnLocation.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLocation_ItemClick);
            // 
            // btnClass
            // 
            this.btnClass.Caption = "Class";
            this.btnClass.Id = 3;
            this.btnClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClass.ImageOptions.SvgImage")));
            this.btnClass.Name = "btnClass";
            this.btnClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClass_ItemClick);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Teacher";
            this.btnTeacher.Id = 4;
            this.btnTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeacher.ImageOptions.SvgImage")));
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacher_ItemClick);
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Student";
            this.btnStudent.Id = 5;
            this.btnStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStudent.ImageOptions.SvgImage")));
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStudent_ItemClick);
            // 
            // btnSubjectManagement
            // 
            this.btnSubjectManagement.Caption = "Subject\r\n";
            this.btnSubjectManagement.Id = 6;
            this.btnSubjectManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSubjectManagement.ImageOptions.SvgImage")));
            this.btnSubjectManagement.Name = "btnSubjectManagement";
            this.btnSubjectManagement.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubjectManagement_ItemClick);
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Caption = "New Account";
            this.btnCreateLogin.Id = 7;
            this.btnCreateLogin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCreateLogin.ImageOptions.SvgImage")));
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateLogin_ItemClick);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Caption = "Change Password";
            this.btnChangePassword.Id = 8;
            this.btnChangePassword.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangePassword.ImageOptions.SvgImage")));
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePassword_ItemClick);
            // 
            // btnExamResultReport
            // 
            this.btnExamResultReport.Caption = "Exam Result";
            this.btnExamResultReport.Id = 9;
            this.btnExamResultReport.Name = "btnExamResultReport";
            this.btnExamResultReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamResultReport_ItemClick);
            // 
            // btnSubjectScoreSheet
            // 
            this.btnSubjectScoreSheet.Caption = "Subject Score Sheet";
            this.btnSubjectScoreSheet.Id = 10;
            this.btnSubjectScoreSheet.Name = "btnSubjectScoreSheet";
            this.btnSubjectScoreSheet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubjectScoreSheet_ItemClick);
            // 
            // btnExamRegistrationList
            // 
            this.btnExamRegistrationList.Caption = "Exam Registration List";
            this.btnExamRegistrationList.Id = 11;
            this.btnExamRegistrationList.Name = "btnExamRegistrationList";
            this.btnExamRegistrationList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExamRegistrationList_ItemClick);
            // 
            // lbUserId
            // 
            this.lbUserId.Caption = "USER ID";
            this.lbUserId.Id = 12;
            this.lbUserId.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lbUserId.ItemAppearance.Normal.Options.UseFont = true;
            this.lbUserId.Name = "lbUserId";
            // 
            // lbUserFullName
            // 
            this.lbUserFullName.Caption = "FULL NAME";
            this.lbUserFullName.Id = 13;
            this.lbUserFullName.Name = "lbUserFullName";
            // 
            // lbUserRole
            // 
            this.lbUserRole.Caption = "ROLE";
            this.lbUserRole.Id = 14;
            this.lbUserRole.ItemAppearance.Normal.FontStyleDelta = System.Drawing.FontStyle.Bold;
            this.lbUserRole.ItemAppearance.Normal.Options.UseFont = true;
            this.lbUserRole.Name = "lbUserRole";
            // 
            // btnTeacherRegistration
            // 
            this.btnTeacherRegistration.Caption = "Teacher Registration";
            this.btnTeacherRegistration.Id = 15;
            this.btnTeacherRegistration.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeacherRegistration.ImageOptions.SvgImage")));
            this.btnTeacherRegistration.Name = "btnTeacherRegistration";
            this.btnTeacherRegistration.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeacherRegistration_ItemClick);
            // 
            // btnDoExam
            // 
            this.btnDoExam.Caption = "Do Exam";
            this.btnDoExam.Id = 16;
            this.btnDoExam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDoExam.ImageOptions.SvgImage")));
            this.btnDoExam.Name = "btnDoExam";
            this.btnDoExam.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoExam_ItemClick);
            // 
            // btnTopic
            // 
            this.btnTopic.Caption = "Topic";
            this.btnTopic.Id = 17;
            this.btnTopic.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTopic.ImageOptions.SvgImage")));
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTopic_ItemClick);
            // 
            // rpSystem
            // 
            this.rpSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.rpgSignUp});
            this.rpSystem.ImageOptions.ImageToTextIndent = 10;
            this.rpSystem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rpSystem.ImageOptions.SvgImage")));
            this.rpSystem.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.rpSystem.Name = "rpSystem";
            this.rpSystem.Text = "System";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSignOut);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Account";
            // 
            // rpgSignUp
            // 
            this.rpgSignUp.ItemLinks.Add(this.btnCreateLogin);
            this.rpgSignUp.Name = "rpgSignUp";
            this.rpgSignUp.Text = "Sign Up";
            // 
            // rpManagement
            // 
            this.rpManagement.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSchool,
            this.rpgHuman,
            this.rpgSubject,
            this.rpgTopic});
            this.rpManagement.ImageOptions.ImageToTextIndent = 10;
            this.rpManagement.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rpManagement.ImageOptions.SvgImage")));
            this.rpManagement.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.rpManagement.Name = "rpManagement";
            this.rpManagement.Text = "Management";
            // 
            // rpgSchool
            // 
            this.rpgSchool.ItemLinks.Add(this.btnLocation);
            this.rpgSchool.ItemLinks.Add(this.btnClass);
            this.rpgSchool.Name = "rpgSchool";
            this.rpgSchool.Text = "School";
            // 
            // rpgHuman
            // 
            this.rpgHuman.ItemLinks.Add(this.btnTeacher);
            this.rpgHuman.ItemLinks.Add(this.btnStudent);
            this.rpgHuman.Name = "rpgHuman";
            this.rpgHuman.Text = "Human";
            // 
            // rpgSubject
            // 
            this.rpgSubject.AllowTextClipping = false;
            this.rpgSubject.ItemLinks.Add(this.btnSubjectManagement);
            this.rpgSubject.Name = "rpgSubject";
            this.rpgSubject.Text = "Subject";
            // 
            // rpgTopic
            // 
            this.rpgTopic.ItemLinks.Add(this.btnTopic);
            this.rpgTopic.Name = "rpgTopic";
            this.rpgTopic.Text = "Topic";
            // 
            // rpExamination
            // 
            this.rpExamination.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgTeacherRegistration,
            this.rpgExam});
            this.rpExamination.ImageOptions.ImageToTextIndent = 10;
            this.rpExamination.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rpExamination.ImageOptions.SvgImage")));
            this.rpExamination.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.rpExamination.Name = "rpExamination";
            this.rpExamination.Text = "Examination";
            // 
            // rpgTeacherRegistration
            // 
            this.rpgTeacherRegistration.ItemLinks.Add(this.btnTeacherRegistration);
            this.rpgTeacherRegistration.Name = "rpgTeacherRegistration";
            this.rpgTeacherRegistration.Text = "__________";
            // 
            // rpgExam
            // 
            this.rpgExam.ItemLinks.Add(this.btnDoExam);
            this.rpgExam.Name = "rpgExam";
            this.rpgExam.Text = "__________";
            // 
            // rpReport
            // 
            this.rpReport.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.rpgSubjectScoreSheet,
            this.rpgExamRegistrationList});
            this.rpReport.ImageOptions.ImageToTextIndent = 10;
            this.rpReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rpReport.ImageOptions.SvgImage")));
            this.rpReport.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.rpReport.Name = "rpReport";
            this.rpReport.Text = "Report";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnExamResultReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "__________";
            // 
            // rpgSubjectScoreSheet
            // 
            this.rpgSubjectScoreSheet.ItemLinks.Add(this.btnSubjectScoreSheet);
            this.rpgSubjectScoreSheet.Name = "rpgSubjectScoreSheet";
            this.rpgSubjectScoreSheet.Text = "__________";
            // 
            // rpgExamRegistrationList
            // 
            this.rpgExamRegistrationList.ItemLinks.Add(this.btnExamRegistrationList);
            this.rpgExamRegistrationList.Name = "rpgExamRegistrationList";
            this.rpgExamRegistrationList.Text = "__________";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbUserId);
            this.ribbonStatusBar.ItemLinks.Add(this.lbUserFullName);
            this.ribbonStatusBar.ItemLinks.Add(this.lbUserRole);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 423);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1165, 26);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSchool;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSignOut;
        private DevExpress.XtraBars.BarButtonItem btnLocation;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgHuman;
        private DevExpress.XtraBars.BarButtonItem btnSubjectManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSubject;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSignUp;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnExamResultReport;
        private DevExpress.XtraBars.BarButtonItem btnSubjectScoreSheet;
        private DevExpress.XtraBars.BarButtonItem btnExamRegistrationList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSubjectScoreSheet;
        public DevExpress.XtraBars.BarStaticItem lbUserId;
        public DevExpress.XtraBars.BarStaticItem lbUserFullName;
        public DevExpress.XtraBars.BarStaticItem lbUserRole;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpExamination;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTeacherRegistration;
        private DevExpress.XtraBars.BarButtonItem btnTeacherRegistration;
        private DevExpress.XtraBars.BarButtonItem btnDoExam;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExam;
        private DevExpress.XtraBars.BarButtonItem btnTopic;
        private DevExpress.XtraBars.Ribbon.RibbonPage rpManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgTopic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgExamRegistrationList;
    }
}