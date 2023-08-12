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
            this.rbSystem = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.btnDoExam});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbSystem,
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1165, 175);
            this.ribbon.StatusBar = this.ribbonStatusBar;
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
            // 
            // btnTeacher
            // 
            this.btnTeacher.Caption = "Teacher";
            this.btnTeacher.Id = 4;
            this.btnTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeacher.ImageOptions.SvgImage")));
            this.btnTeacher.Name = "btnTeacher";
            // 
            // btnStudent
            // 
            this.btnStudent.Caption = "Student";
            this.btnStudent.Id = 5;
            this.btnStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStudent.ImageOptions.SvgImage")));
            this.btnStudent.Name = "btnStudent";
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
            // rbSystem
            // 
            this.rbSystem.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup6});
            this.rbSystem.ImageOptions.ImageToTextIndent = 10;
            this.rbSystem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("rbSystem.ImageOptions.SvgImage")));
            this.rbSystem.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Text = "System";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSignOut);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChangePassword);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Account";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnCreateLogin);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Sign Up";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.ImageOptions.ImageToTextIndent = 10;
            this.ribbonPage1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage1.ImageOptions.SvgImage")));
            this.ribbonPage1.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Management";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLocation);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClass);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "School";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTeacher);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnStudent);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Human";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSubjectManagement);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Subject";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribbonPage2.ImageOptions.ImageToTextIndent = 10;
            this.ribbonPage2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage2.ImageOptions.SvgImage")));
            this.ribbonPage2.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Report";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnExamResultReport);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "__________";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnSubjectScoreSheet);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "__________";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnExamRegistrationList);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "__________";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9,
            this.ribbonPageGroup10});
            this.ribbonPage3.ImageOptions.ImageToTextIndent = 10;
            this.ribbonPage3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPage3.ImageOptions.SvgImage")));
            this.ribbonPage3.ImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Examination";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnTeacherRegistration);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "__________";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnDoExam);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "__________";
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
            this.Text = "Management";
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbSystem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnSignOut;
        private DevExpress.XtraBars.BarButtonItem btnLocation;
        private DevExpress.XtraBars.BarButtonItem btnClass;
        private DevExpress.XtraBars.BarButtonItem btnTeacher;
        private DevExpress.XtraBars.BarButtonItem btnStudent;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnSubjectManagement;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnChangePassword;
        private DevExpress.XtraBars.BarButtonItem btnExamResultReport;
        private DevExpress.XtraBars.BarButtonItem btnSubjectScoreSheet;
        private DevExpress.XtraBars.BarButtonItem btnExamRegistrationList;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        public DevExpress.XtraBars.BarStaticItem lbUserId;
        public DevExpress.XtraBars.BarStaticItem lbUserFullName;
        public DevExpress.XtraBars.BarStaticItem lbUserRole;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnTeacherRegistration;
        private DevExpress.XtraBars.BarButtonItem btnDoExam;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
    }
}