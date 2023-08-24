namespace TN_CSDLPT.views
{
    partial class FormTeacherRegistration
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
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tRINHDOLabel;
            System.Windows.Forms.Label nGAYTHILabel;
            System.Windows.Forms.Label lANLabel;
            System.Windows.Forms.Label sOCAUTHILabel;
            System.Windows.Forms.Label tHOIGIANLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherRegistration));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCommit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnLocation = new DevExpress.XtraBars.BarEditItem();
            this.cbxLocation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DataSet = new TN_CSDLPT.TN_CSDLPT_PRODDataSet();
            this.bdsTeacher_Registration = new System.Windows.Forms.BindingSource(this.components);
            this.taTeacher_Registration = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager();
            this.gcTeacher_Registration = new DevExpress.XtraGrid.GridControl();
            this.gvTeacher_Registration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTRINHDO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCAUTHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOIGIAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxTeacher = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxLevel = new DevExpress.XtraEditors.ComboBoxEdit();
            this.seTotalMinutes = new DevExpress.XtraEditors.SpinEdit();
            this.seTotalQuestions = new DevExpress.XtraEditors.SpinEdit();
            this.seNumberOfExamTimes = new DevExpress.XtraEditors.SpinEdit();
            this.deExamDate = new DevExpress.XtraEditors.DateEdit();
            this.cbxClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbxSubject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bdsTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.taTeacher = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIENTableAdapter();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.taSubject = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter();
            this.bdsClass = new System.Windows.Forms.BindingSource(this.components);
            this.taClass = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.LOPTableAdapter();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tRINHDOLabel = new System.Windows.Forms.Label();
            nGAYTHILabel = new System.Windows.Forms.Label();
            lANLabel = new System.Windows.Forms.Label();
            sOCAUTHILabel = new System.Windows.Forms.Label();
            tHOIGIANLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher_Registration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher_Registration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher_Registration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLevel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalMinutes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalQuestions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seNumberOfExamTimes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).BeginInit();
            this.SuspendLayout();
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(97, 60);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(50, 15);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "Teacher:";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(98, 88);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(49, 15);
            mAMHLabel.TabIndex = 2;
            mAMHLabel.Text = "Subject:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(110, 116);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(37, 15);
            mALOPLabel.TabIndex = 4;
            mALOPLabel.Text = "Class:";
            // 
            // tRINHDOLabel
            // 
            tRINHDOLabel.AutoSize = true;
            tRINHDOLabel.Location = new System.Drawing.Point(110, 144);
            tRINHDOLabel.Name = "tRINHDOLabel";
            tRINHDOLabel.Size = new System.Drawing.Size(37, 15);
            tRINHDOLabel.TabIndex = 6;
            tRINHDOLabel.Text = "Level:";
            // 
            // nGAYTHILabel
            // 
            nGAYTHILabel.AutoSize = true;
            nGAYTHILabel.Location = new System.Drawing.Point(710, 60);
            nGAYTHILabel.Name = "nGAYTHILabel";
            nGAYTHILabel.Size = new System.Drawing.Size(66, 15);
            nGAYTHILabel.TabIndex = 8;
            nGAYTHILabel.Text = "Exam Date:";
            // 
            // lANLabel
            // 
            lANLabel.AutoSize = true;
            lANLabel.Location = new System.Drawing.Point(642, 88);
            lANLabel.Name = "lANLabel";
            lANLabel.Size = new System.Drawing.Size(134, 15);
            lANLabel.TabIndex = 10;
            lANLabel.Text = "Number of Exam Times:";
            // 
            // sOCAUTHILabel
            // 
            sOCAUTHILabel.AutoSize = true;
            sOCAUTHILabel.Location = new System.Drawing.Point(685, 116);
            sOCAUTHILabel.Name = "sOCAUTHILabel";
            sOCAUTHILabel.Size = new System.Drawing.Size(91, 15);
            sOCAUTHILabel.TabIndex = 12;
            sOCAUTHILabel.Text = "Total Questions:";
            // 
            // tHOIGIANLabel
            // 
            tHOIGIANLabel.AutoSize = true;
            tHOIGIANLabel.Location = new System.Drawing.Point(723, 144);
            tHOIGIANLabel.Name = "tHOIGIANLabel";
            tHOIGIANLabel.Size = new System.Drawing.Size(53, 15);
            tHOIGIANLabel.TabIndex = 14;
            tHOIGIANLabel.Text = "Minutes:";
            // 
            // barManager1
            // 
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnNew,
            this.btnEdit,
            this.btnCommit,
            this.btnDelete,
            this.btnUndo,
            this.btnCancel,
            this.btnExit,
            this.btnRefresh,
            this.btnHelp,
            this.btnLocation});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxLocation});
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCommit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.Text = "Tools";
            // 
            // btnNew
            // 
            this.btnNew.Caption = "New";
            this.btnNew.Id = 2;
            this.btnNew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNew.ImageOptions.SvgImage")));
            this.btnNew.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnNew.Name = "btnNew";
            this.btnNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNew_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Edit";
            this.btnEdit.Id = 3;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnCommit
            // 
            this.btnCommit.Caption = "Commit";
            this.btnCommit.Id = 4;
            this.btnCommit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCommit.ImageOptions.SvgImage")));
            this.btnCommit.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCommit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCommit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Id = 5;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Id = 6;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Caption = "Cancel";
            this.btnCancel.Id = 7;
            this.btnCancel.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancel.ImageOptions.SvgImage")));
            this.btnCancel.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancel_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Id = 10;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarItemVertIndent = 10;
            this.bar3.BarName = "Main menu";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.btnLocation, "", false, true, true, 250),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHelp)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // btnLocation
            // 
            this.btnLocation.Caption = "Location";
            this.btnLocation.Edit = this.cbxLocation;
            this.btnLocation.Id = 14;
            this.btnLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLocation.ImageOptions.SvgImage")));
            this.btnLocation.Name = "btnLocation";
            this.btnLocation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // cbxLocation
            // 
            this.cbxLocation.AutoHeight = false;
            this.cbxLocation.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLocation.Name = "cbxLocation";
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 9;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "info";
            this.btnHelp.Id = 11;
            this.btnHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHelp.ImageOptions.SvgImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 80);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 80);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 610);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 80);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 610);
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "TN_CSDLPT_PRODDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTeacher_Registration
            // 
            this.bdsTeacher_Registration.DataMember = "GIAOVIEN_DANGKY";
            this.bdsTeacher_Registration.DataSource = this.DataSet;
            // 
            // taTeacher_Registration
            // 
            this.taTeacher_Registration.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = this.taTeacher_Registration;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcTeacher_Registration
            // 
            this.gcTeacher_Registration.DataSource = this.bdsTeacher_Registration;
            this.gcTeacher_Registration.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTeacher_Registration.Location = new System.Drawing.Point(0, 80);
            this.gcTeacher_Registration.MainView = this.gvTeacher_Registration;
            this.gcTeacher_Registration.MenuManager = this.barManager1;
            this.gcTeacher_Registration.Name = "gcTeacher_Registration";
            this.gcTeacher_Registration.Size = new System.Drawing.Size(1280, 400);
            this.gcTeacher_Registration.TabIndex = 5;
            this.gcTeacher_Registration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTeacher_Registration});
            // 
            // gvTeacher_Registration
            // 
            this.gvTeacher_Registration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colMAMH,
            this.colMALOP,
            this.colTRINHDO,
            this.colNGAYTHI,
            this.colLAN,
            this.colSOCAUTHI,
            this.colTHOIGIAN});
            this.gvTeacher_Registration.GridControl = this.gcTeacher_Registration;
            this.gvTeacher_Registration.Name = "gvTeacher_Registration";
            this.gvTeacher_Registration.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvTeacher_Registration_FocusedRowChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 1;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 2;
            // 
            // colTRINHDO
            // 
            this.colTRINHDO.FieldName = "TRINHDO";
            this.colTRINHDO.Name = "colTRINHDO";
            this.colTRINHDO.Visible = true;
            this.colTRINHDO.VisibleIndex = 3;
            // 
            // colNGAYTHI
            // 
            this.colNGAYTHI.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.colNGAYTHI.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colNGAYTHI.FieldName = "NGAYTHI";
            this.colNGAYTHI.Name = "colNGAYTHI";
            this.colNGAYTHI.Visible = true;
            this.colNGAYTHI.VisibleIndex = 4;
            // 
            // colLAN
            // 
            this.colLAN.FieldName = "LAN";
            this.colLAN.Name = "colLAN";
            this.colLAN.Visible = true;
            this.colLAN.VisibleIndex = 5;
            // 
            // colSOCAUTHI
            // 
            this.colSOCAUTHI.FieldName = "SOCAUTHI";
            this.colSOCAUTHI.Name = "colSOCAUTHI";
            this.colSOCAUTHI.Visible = true;
            this.colSOCAUTHI.VisibleIndex = 6;
            // 
            // colTHOIGIAN
            // 
            this.colTHOIGIAN.FieldName = "THOIGIAN";
            this.colTHOIGIAN.Name = "colTHOIGIAN";
            this.colTHOIGIAN.Visible = true;
            this.colTHOIGIAN.VisibleIndex = 7;
            // 
            // gcInfo
            // 
            this.gcInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcInfo.CaptionImageOptions.SvgImage")));
            this.gcInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcInfo.Controls.Add(this.cbxTeacher);
            this.gcInfo.Controls.Add(this.cbxLevel);
            this.gcInfo.Controls.Add(tHOIGIANLabel);
            this.gcInfo.Controls.Add(this.seTotalMinutes);
            this.gcInfo.Controls.Add(sOCAUTHILabel);
            this.gcInfo.Controls.Add(this.seTotalQuestions);
            this.gcInfo.Controls.Add(lANLabel);
            this.gcInfo.Controls.Add(this.seNumberOfExamTimes);
            this.gcInfo.Controls.Add(nGAYTHILabel);
            this.gcInfo.Controls.Add(this.deExamDate);
            this.gcInfo.Controls.Add(tRINHDOLabel);
            this.gcInfo.Controls.Add(mALOPLabel);
            this.gcInfo.Controls.Add(this.cbxClass);
            this.gcInfo.Controls.Add(mAMHLabel);
            this.gcInfo.Controls.Add(this.cbxSubject);
            this.gcInfo.Controls.Add(mAGVLabel);
            this.gcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInfo.Location = new System.Drawing.Point(0, 480);
            this.gcInfo.Name = "gcInfo";
            this.gcInfo.Size = new System.Drawing.Size(1280, 210);
            this.gcInfo.TabIndex = 6;
            this.gcInfo.Text = "Info";
            // 
            // cbxTeacher
            // 
            this.cbxTeacher.Location = new System.Drawing.Point(153, 57);
            this.cbxTeacher.MenuManager = this.barManager1;
            this.cbxTeacher.Name = "cbxTeacher";
            this.cbxTeacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxTeacher.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxTeacher.Size = new System.Drawing.Size(400, 22);
            this.cbxTeacher.TabIndex = 17;
            // 
            // cbxLevel
            // 
            this.cbxLevel.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher_Registration, "TRINHDO", true));
            this.cbxLevel.Location = new System.Drawing.Point(153, 141);
            this.cbxLevel.MenuManager = this.barManager1;
            this.cbxLevel.Name = "cbxLevel";
            this.cbxLevel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLevel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLevel.Size = new System.Drawing.Size(400, 22);
            this.cbxLevel.TabIndex = 16;
            // 
            // seTotalMinutes
            // 
            this.seTotalMinutes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher_Registration, "THOIGIAN", true));
            this.seTotalMinutes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotalMinutes.Location = new System.Drawing.Point(782, 141);
            this.seTotalMinutes.MenuManager = this.barManager1;
            this.seTotalMinutes.Name = "seTotalMinutes";
            this.seTotalMinutes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalMinutes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotalMinutes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotalMinutes.Properties.IsFloatValue = false;
            this.seTotalMinutes.Properties.MaskSettings.Set("mask", "N00");
            this.seTotalMinutes.Size = new System.Drawing.Size(400, 22);
            this.seTotalMinutes.TabIndex = 15;
            // 
            // seTotalQuestions
            // 
            this.seTotalQuestions.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher_Registration, "SOCAUTHI", true));
            this.seTotalQuestions.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seTotalQuestions.Location = new System.Drawing.Point(782, 113);
            this.seTotalQuestions.MenuManager = this.barManager1;
            this.seTotalQuestions.Name = "seTotalQuestions";
            this.seTotalQuestions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seTotalQuestions.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotalQuestions.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seTotalQuestions.Properties.IsFloatValue = false;
            this.seTotalQuestions.Properties.MaskSettings.Set("mask", "N00");
            this.seTotalQuestions.Size = new System.Drawing.Size(400, 22);
            this.seTotalQuestions.TabIndex = 13;
            // 
            // seNumberOfExamTimes
            // 
            this.seNumberOfExamTimes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher_Registration, "LAN", true));
            this.seNumberOfExamTimes.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seNumberOfExamTimes.Location = new System.Drawing.Point(782, 85);
            this.seNumberOfExamTimes.MenuManager = this.barManager1;
            this.seNumberOfExamTimes.Name = "seNumberOfExamTimes";
            this.seNumberOfExamTimes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seNumberOfExamTimes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seNumberOfExamTimes.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.seNumberOfExamTimes.Properties.IsFloatValue = false;
            this.seNumberOfExamTimes.Properties.MaskSettings.Set("mask", "N00");
            this.seNumberOfExamTimes.Size = new System.Drawing.Size(400, 22);
            this.seNumberOfExamTimes.TabIndex = 11;
            // 
            // deExamDate
            // 
            this.deExamDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher_Registration, "NGAYTHI", true));
            this.deExamDate.EditValue = null;
            this.deExamDate.Location = new System.Drawing.Point(782, 57);
            this.deExamDate.MenuManager = this.barManager1;
            this.deExamDate.Name = "deExamDate";
            this.deExamDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExamDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deExamDate.Size = new System.Drawing.Size(400, 22);
            this.deExamDate.TabIndex = 9;
            // 
            // cbxClass
            // 
            this.cbxClass.Location = new System.Drawing.Point(153, 113);
            this.cbxClass.MenuManager = this.barManager1;
            this.cbxClass.Name = "cbxClass";
            this.cbxClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxClass.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxClass.Size = new System.Drawing.Size(400, 22);
            this.cbxClass.TabIndex = 5;
            // 
            // cbxSubject
            // 
            this.cbxSubject.Location = new System.Drawing.Point(153, 85);
            this.cbxSubject.MenuManager = this.barManager1;
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxSubject.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxSubject.Size = new System.Drawing.Size(400, 22);
            this.cbxSubject.TabIndex = 3;
            // 
            // bdsTeacher
            // 
            this.bdsTeacher.DataMember = "GIAOVIEN";
            this.bdsTeacher.DataSource = this.DataSet;
            // 
            // taTeacher
            // 
            this.taTeacher.ClearBeforeFill = true;
            // 
            // bdsSubject
            // 
            this.bdsSubject.DataMember = "MONHOC";
            this.bdsSubject.DataSource = this.DataSet;
            // 
            // taSubject
            // 
            this.taSubject.ClearBeforeFill = true;
            // 
            // bdsClass
            // 
            this.bdsClass.DataMember = "LOP";
            this.bdsClass.DataSource = this.DataSet;
            // 
            // taClass
            // 
            this.taClass.ClearBeforeFill = true;
            // 
            // FormTeacherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.gcInfo);
            this.Controls.Add(this.gcTeacher_Registration);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTeacherRegistration";
            this.Text = "Exam Registration";
            this.Load += new System.EventHandler(this.FormTeacherRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher_Registration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher_Registration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher_Registration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLevel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalMinutes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seTotalQuestions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seNumberOfExamTimes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deExamDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnCommit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarEditItem btnLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbxLocation;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsTeacher_Registration;
        private TN_CSDLPT_PRODDataSet DataSet;
        private TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter taTeacher_Registration;
        private TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcTeacher_Registration;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTeacher_Registration;
        private DevExpress.XtraEditors.GroupControl gcInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxSubject;
        private DevExpress.XtraEditors.ComboBoxEdit cbxClass;
        private DevExpress.XtraEditors.DateEdit deExamDate;
        private DevExpress.XtraEditors.SpinEdit seNumberOfExamTimes;
        private DevExpress.XtraEditors.SpinEdit seTotalQuestions;
        private DevExpress.XtraEditors.SpinEdit seTotalMinutes;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLevel;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraGrid.Columns.GridColumn colTRINHDO;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colLAN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCAUTHI;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOIGIAN;
        private DevExpress.XtraEditors.ComboBoxEdit cbxTeacher;
        private System.Windows.Forms.BindingSource bdsTeacher;
        private TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIENTableAdapter taTeacher;
        private System.Windows.Forms.BindingSource bdsSubject;
        private TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter taSubject;
        private System.Windows.Forms.BindingSource bdsClass;
        private TN_CSDLPT_PRODDataSetTableAdapters.LOPTableAdapter taClass;
    }
}