namespace TN_CSDLPT.views
{
    partial class Examination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Examination));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bdsTopic = new System.Windows.Forms.BindingSource(this.components);
            this.Dataset = new TN_CSDLPT.TN_CSDLPT_PRODDataSet();
            this.sidePanel4 = new DevExpress.XtraEditors.SidePanel();
            this.lcAnswerSheet = new DevExpress.XtraEditors.ListBoxControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.lbTimeLeft = new DevExpress.XtraBars.BarHeaderItem();
            this.progressBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.btnSubmit = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.taSubject = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter();
            this.taTopic = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.BODETableAdapter();
            this.gcExaminee = new DevExpress.XtraEditors.GroupControl();
            this.teClassName = new DevExpress.XtraEditors.LabelControl();
            this.lbTitleClassname = new DevExpress.XtraEditors.LabelControl();
            this.teClassId = new DevExpress.XtraEditors.LabelControl();
            this.lbTitleClassId = new DevExpress.XtraEditors.LabelControl();
            this.teName = new DevExpress.XtraEditors.LabelControl();
            this.lbTitleFullName = new DevExpress.XtraEditors.LabelControl();
            this.teId = new DevExpress.XtraEditors.LabelControl();
            this.lbTitleId = new DevExpress.XtraEditors.LabelControl();
            this.gcFindExam = new DevExpress.XtraEditors.GroupControl();
            this.btnFindExam = new DevExpress.XtraEditors.SimpleButton();
            this.seNumberOfExamTimes = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbxSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.deExamDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.gcExamInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.teTotalQuestions = new DevExpress.XtraEditors.TextEdit();
            this.teLevel = new DevExpress.XtraEditors.TextEdit();
            this.teTotalMinutes = new DevExpress.XtraEditors.TextEdit();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).BeginInit();
            this.sidePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcAnswerSheet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExaminee)).BeginInit();
            this.gcExaminee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindExam)).BeginInit();
            this.gcFindExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNumberOfExamTimes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExamInfo)).BeginInit();
            this.gcExamInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTotalQuestions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTotalMinutes.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.gcExamInfo);
            this.sidePanel1.Controls.Add(this.gcFindExam);
            this.sidePanel1.Controls.Add(this.gcExaminee);
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 28);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(327, 662);
            this.sidePanel1.TabIndex = 1;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.labelControl1.Size = new System.Drawing.Size(326, 57);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "EXAMINATION";
            // 
            // bdsTopic
            // 
            this.bdsTopic.DataMember = "BODE";
            this.bdsTopic.DataSource = this.Dataset;
            // 
            // Dataset
            // 
            this.Dataset.DataSetName = "TN_CSDLPT_PRODDataSet";
            this.Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sidePanel4
            // 
            this.sidePanel4.Controls.Add(this.lcAnswerSheet);
            this.sidePanel4.Controls.Add(this.flowLayoutPanel1);
            this.sidePanel4.Controls.Add(this.standaloneBarDockControl1);
            this.sidePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel4.Location = new System.Drawing.Point(327, 28);
            this.sidePanel4.Name = "sidePanel4";
            this.sidePanel4.Size = new System.Drawing.Size(1057, 662);
            this.sidePanel4.TabIndex = 2;
            this.sidePanel4.Text = "sidePanel4";
            // 
            // lcAnswerSheet
            // 
            this.lcAnswerSheet.Dock = System.Windows.Forms.DockStyle.Right;
            this.lcAnswerSheet.Location = new System.Drawing.Point(905, 44);
            this.lcAnswerSheet.Name = "lcAnswerSheet";
            this.lcAnswerSheet.Size = new System.Drawing.Size(152, 618);
            this.lcAnswerSheet.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1057, 618);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.Border = ((DevExpress.XtraBars.BarDockControlBorder)((((DevExpress.XtraBars.BarDockControlBorder.Left | DevExpress.XtraBars.BarDockControlBorder.Right) 
            | DevExpress.XtraBars.BarDockControlBorder.Top) 
            | DevExpress.XtraBars.BarDockControlBorder.Bottom)));
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1057, 44);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSubmit,
            this.barStaticItem1,
            this.lbTimeLeft,
            this.progressBar,
            this.btnExit,
            this.btnHelp});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 13;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1});
            // 
            // bar1
            // 
            this.bar1.BarName = "Custom 2";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar1.FloatLocation = new System.Drawing.Point(513, 238);
            this.bar1.FloatSize = new System.Drawing.Size(0, 50);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.lbTimeLeft),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.progressBar, "", false, true, true, 126),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSubmit)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar1.Text = "Custom 2";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Time left:";
            this.barStaticItem1.Id = 5;
            this.barStaticItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barStaticItem1.ImageOptions.SvgImage")));
            this.barStaticItem1.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.Caption = "00:00:00";
            this.lbTimeLeft.Id = 7;
            this.lbTimeLeft.Name = "lbTimeLeft";
            // 
            // progressBar
            // 
            this.progressBar.Caption = "barEditItem1";
            this.progressBar.Edit = this.repositoryItemProgressBar1;
            this.progressBar.Id = 9;
            this.progressBar.Name = "progressBar";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Caption = "Submit";
            this.btnSubmit.Id = 3;
            this.btnSubmit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSubmit.ImageOptions.SvgImage")));
            this.btnSubmit.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSubmit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSubmit_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 3";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHelp)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DisableCustomization = true;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Custom 3";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 11;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "Help";
            this.btnHelp.Id = 12;
            this.btnHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHelp.ImageOptions.SvgImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1384, 28);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1384, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 28);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 662);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1384, 28);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 662);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsSubject
            // 
            this.bdsSubject.DataMember = "MONHOC";
            this.bdsSubject.DataSource = this.Dataset;
            // 
            // taSubject
            // 
            this.taSubject.ClearBeforeFill = true;
            // 
            // taTopic
            // 
            this.taTopic.ClearBeforeFill = true;
            // 
            // gcExaminee
            // 
            this.gcExaminee.Controls.Add(this.teClassName);
            this.gcExaminee.Controls.Add(this.lbTitleClassname);
            this.gcExaminee.Controls.Add(this.teClassId);
            this.gcExaminee.Controls.Add(this.lbTitleClassId);
            this.gcExaminee.Controls.Add(this.teName);
            this.gcExaminee.Controls.Add(this.lbTitleFullName);
            this.gcExaminee.Controls.Add(this.teId);
            this.gcExaminee.Controls.Add(this.lbTitleId);
            this.gcExaminee.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcExaminee.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.gcExaminee.Location = new System.Drawing.Point(0, 57);
            this.gcExaminee.Name = "gcExaminee";
            this.gcExaminee.Size = new System.Drawing.Size(326, 183);
            this.gcExaminee.TabIndex = 5;
            this.gcExaminee.Text = "STUDENT INFO";
            // 
            // teClassName
            // 
            this.teClassName.Location = new System.Drawing.Point(131, 135);
            this.teClassName.Name = "teClassName";
            this.teClassName.Size = new System.Drawing.Size(69, 15);
            this.teClassName.TabIndex = 7;
            this.teClassName.Text = "teClassName";
            // 
            // lbTitleClassname
            // 
            this.lbTitleClassname.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbTitleClassname.Appearance.Options.UseFont = true;
            this.lbTitleClassname.Location = new System.Drawing.Point(28, 135);
            this.lbTitleClassname.Name = "lbTitleClassname";
            this.lbTitleClassname.Size = new System.Drawing.Size(63, 15);
            this.lbTitleClassname.TabIndex = 6;
            this.lbTitleClassname.Text = "Class name:";
            // 
            // teClassId
            // 
            this.teClassId.Location = new System.Drawing.Point(131, 105);
            this.teClassId.Name = "teClassId";
            this.teClassId.Size = new System.Drawing.Size(47, 15);
            this.teClassId.TabIndex = 5;
            this.teClassId.Text = "teClassId";
            // 
            // lbTitleClassId
            // 
            this.lbTitleClassId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbTitleClassId.Appearance.Options.UseFont = true;
            this.lbTitleClassId.Location = new System.Drawing.Point(28, 105);
            this.lbTitleClassId.Name = "lbTitleClassId";
            this.lbTitleClassId.Size = new System.Drawing.Size(43, 15);
            this.lbTitleClassId.TabIndex = 4;
            this.lbTitleClassId.Text = "Class Id:";
            // 
            // teName
            // 
            this.teName.Location = new System.Drawing.Point(131, 74);
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(42, 15);
            this.teName.TabIndex = 3;
            this.teName.Text = "teName";
            // 
            // lbTitleFullName
            // 
            this.lbTitleFullName.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbTitleFullName.Appearance.Options.UseFont = true;
            this.lbTitleFullName.Location = new System.Drawing.Point(28, 74);
            this.lbTitleFullName.Name = "lbTitleFullName";
            this.lbTitleFullName.Size = new System.Drawing.Size(58, 15);
            this.lbTitleFullName.TabIndex = 2;
            this.lbTitleFullName.Text = "Full Name:";
            // 
            // teId
            // 
            this.teId.Location = new System.Drawing.Point(131, 44);
            this.teId.Name = "teId";
            this.teId.Size = new System.Drawing.Size(20, 15);
            this.teId.TabIndex = 1;
            this.teId.Text = "teId";
            // 
            // lbTitleId
            // 
            this.lbTitleId.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbTitleId.Appearance.Options.UseFont = true;
            this.lbTitleId.Location = new System.Drawing.Point(28, 44);
            this.lbTitleId.Name = "lbTitleId";
            this.lbTitleId.Size = new System.Drawing.Size(16, 15);
            this.lbTitleId.TabIndex = 0;
            this.lbTitleId.Text = "ID:";
            // 
            // gcFindExam
            // 
            this.gcFindExam.Controls.Add(this.btnFindExam);
            this.gcFindExam.Controls.Add(this.seNumberOfExamTimes);
            this.gcFindExam.Controls.Add(this.labelControl3);
            this.gcFindExam.Controls.Add(this.cbxSubject);
            this.gcFindExam.Controls.Add(this.labelControl4);
            this.gcFindExam.Controls.Add(this.deExamDate);
            this.gcFindExam.Controls.Add(this.labelControl6);
            this.gcFindExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcFindExam.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.gcFindExam.Location = new System.Drawing.Point(0, 240);
            this.gcFindExam.Name = "gcFindExam";
            this.gcFindExam.Size = new System.Drawing.Size(326, 208);
            this.gcFindExam.TabIndex = 6;
            this.gcFindExam.Text = "FIND EXAM";
            // 
            // btnFindExam
            // 
            this.btnFindExam.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.btnFindExam.Appearance.Options.UseBackColor = true;
            this.btnFindExam.Location = new System.Drawing.Point(24, 143);
            this.btnFindExam.Name = "btnFindExam";
            this.btnFindExam.Size = new System.Drawing.Size(278, 30);
            this.btnFindExam.TabIndex = 51;
            this.btnFindExam.Text = "Find Exam";
            this.btnFindExam.Click += new System.EventHandler(this.btnFindExam_Click);
            // 
            // seNumberOfExamTimes
            // 
            this.seNumberOfExamTimes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seNumberOfExamTimes.Location = new System.Drawing.Point(127, 105);
            this.seNumberOfExamTimes.Name = "seNumberOfExamTimes";
            this.seNumberOfExamTimes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seNumberOfExamTimes.Size = new System.Drawing.Size(175, 22);
            this.seNumberOfExamTimes.TabIndex = 45;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 15);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Subject:";
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(127, 49);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Size = new System.Drawing.Size(175, 22);
            this.cbxSubject.TabIndex = 48;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(24, 80);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 15);
            this.labelControl4.TabIndex = 49;
            this.labelControl4.Text = "Date:";
            // 
            // deExamDate
            // 
            this.deExamDate.EditValue = null;
            this.deExamDate.Location = new System.Drawing.Point(127, 77);
            this.deExamDate.Name = "deExamDate";
            this.deExamDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExamDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExamDate.Size = new System.Drawing.Size(175, 22);
            this.deExamDate.TabIndex = 46;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 108);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 15);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "No. Exam Times:";
            // 
            // gcExamInfo
            // 
            this.gcExamInfo.Controls.Add(this.labelControl11);
            this.gcExamInfo.Controls.Add(this.btnStart);
            this.gcExamInfo.Controls.Add(this.labelControl10);
            this.gcExamInfo.Controls.Add(this.labelControl8);
            this.gcExamInfo.Controls.Add(this.teTotalQuestions);
            this.gcExamInfo.Controls.Add(this.teLevel);
            this.gcExamInfo.Controls.Add(this.teTotalMinutes);
            this.gcExamInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExamInfo.Location = new System.Drawing.Point(0, 448);
            this.gcExamInfo.Name = "gcExamInfo";
            this.gcExamInfo.Size = new System.Drawing.Size(326, 214);
            this.gcExamInfo.TabIndex = 53;
            this.gcExamInfo.Text = "EXAM INFO";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(24, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(87, 15);
            this.labelControl11.TabIndex = 44;
            this.labelControl11.Text = "Total questions:";
            // 
            // btnStart
            // 
            this.btnStart.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnStart.Appearance.Options.UseBackColor = true;
            this.btnStart.Location = new System.Drawing.Point(24, 154);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(278, 30);
            this.btnStart.TabIndex = 48;
            this.btnStart.Text = "START";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(24, 83);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(33, 15);
            this.labelControl10.TabIndex = 45;
            this.labelControl10.Text = "Level:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(24, 111);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(79, 15);
            this.labelControl8.TabIndex = 47;
            this.labelControl8.Text = "Total minutes:";
            // 
            // teTotalQuestions
            // 
            this.teTotalQuestions.EditValue = "";
            this.teTotalQuestions.Location = new System.Drawing.Point(127, 52);
            this.teTotalQuestions.Name = "teTotalQuestions";
            this.teTotalQuestions.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.teTotalQuestions.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.teTotalQuestions.Size = new System.Drawing.Size(175, 22);
            this.teTotalQuestions.TabIndex = 49;
            // 
            // teLevel
            // 
            this.teLevel.Location = new System.Drawing.Point(127, 80);
            this.teLevel.Name = "teLevel";
            this.teLevel.Size = new System.Drawing.Size(175, 22);
            this.teLevel.TabIndex = 46;
            // 
            // teTotalMinutes
            // 
            this.teTotalMinutes.EditValue = "";
            this.teTotalMinutes.Location = new System.Drawing.Point(127, 108);
            this.teTotalMinutes.Name = "teTotalMinutes";
            this.teTotalMinutes.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.teTotalMinutes.Size = new System.Drawing.Size(175, 22);
            this.teTotalMinutes.TabIndex = 50;
            // 
            // Examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 690);
            this.Controls.Add(this.sidePanel4);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Examination";
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dataset)).EndInit();
            this.sidePanel4.ResumeLayout(false);
            this.sidePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcAnswerSheet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExaminee)).EndInit();
            this.gcExaminee.ResumeLayout(false);
            this.gcExaminee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFindExam)).EndInit();
            this.gcFindExam.ResumeLayout(false);
            this.gcFindExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seNumberOfExamTimes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcExamInfo)).EndInit();
            this.gcExamInfo.ResumeLayout(false);
            this.gcExamInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teTotalQuestions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTotalMinutes.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel sidePanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SidePanel sidePanel4;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnSubmit;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarHeaderItem lbTimeLeft;
        private DevExpress.XtraBars.BarEditItem progressBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TN_CSDLPT_PRODDataSet Dataset;
        private TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.ListBoxControl lcAnswerSheet;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private System.Windows.Forms.BindingSource bdsSubject;
        private TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter taSubject;
        private System.Windows.Forms.BindingSource bdsTopic;
        private TN_CSDLPT_PRODDataSetTableAdapters.BODETableAdapter taTopic;
        private DevExpress.XtraEditors.GroupControl gcExamInfo;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit teTotalQuestions;
        private DevExpress.XtraEditors.TextEdit teLevel;
        private DevExpress.XtraEditors.TextEdit teTotalMinutes;
        private DevExpress.XtraEditors.GroupControl gcFindExam;
        private DevExpress.XtraEditors.SimpleButton btnFindExam;
        private DevExpress.XtraEditors.SpinEdit seNumberOfExamTimes;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSubject;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit deExamDate;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl gcExaminee;
        private DevExpress.XtraEditors.LabelControl teClassName;
        private DevExpress.XtraEditors.LabelControl lbTitleClassname;
        private DevExpress.XtraEditors.LabelControl teClassId;
        private DevExpress.XtraEditors.LabelControl lbTitleClassId;
        private DevExpress.XtraEditors.LabelControl teName;
        private DevExpress.XtraEditors.LabelControl lbTitleFullName;
        private DevExpress.XtraEditors.LabelControl teId;
        private DevExpress.XtraEditors.LabelControl lbTitleId;
    }
}