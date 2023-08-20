namespace TN_CSDLPT.views
{
    partial class FormClass
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
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel1;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClass));
            this.DataSet = new TN_CSDLPT.TN_CSDLPT_PRODDataSet();
            this.bdsClass = new System.Windows.Forms.BindingSource(this.components);
            this.taClass = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager();
            this.taStudent = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.SINHVIENTableAdapter();
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCtxAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxDeleteStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxEditStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxMoveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxSaveStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxUndoStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCtxRefreshStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsStudent = new System.Windows.Forms.BindingSource(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barClass = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCommit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnLocation = new DevExpress.XtraBars.BarEditItem();
            this.cbxLocation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.btnMode = new DevExpress.XtraBars.BarEditItem();
            this.swMode = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.barStudent = new DevExpress.XtraBars.Bar();
            this.btnNewStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnCommitStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshStudent = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeStudentClass = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bdsDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.pcClass = new DevExpress.XtraEditors.PanelControl();
            this.gcClassInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teClassName = new DevExpress.XtraEditors.TextEdit();
            this.teClassId = new DevExpress.XtraEditors.TextEdit();
            this.gcClass = new DevExpress.XtraGrid.GridControl();
            this.gvClass = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALOP1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.taDepartment = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.KHOATableAdapter();
            this.pcStudent = new DevExpress.XtraEditors.PanelControl();
            this.gcStudentInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxStudentClass = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.deBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teStudentId = new DevExpress.XtraEditors.TextEdit();
            this.gcStudent = new DevExpress.XtraGrid.GridControl();
            this.gvStudent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALOP = new DevExpress.XtraGrid.Columns.GridColumn();
            mAKHLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel1 = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).BeginInit();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClass)).BeginInit();
            this.pcClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcClassInfo)).BeginInit();
            this.gcClassInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClassName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClassId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).BeginInit();
            this.pcStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).BeginInit();
            this.gcStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudentClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStudentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(38, 116);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(45, 15);
            mAKHLabel.TabIndex = 5;
            mAKHLabel.Text = "MAKH:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(30, 88);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(53, 15);
            tENLOPLabel.TabIndex = 3;
            tENLOPLabel.Text = "TENLOP:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(32, 60);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(51, 15);
            mALOPLabel.TabIndex = 1;
            mALOPLabel.Text = "MALOP:";
            // 
            // tENLOPLabel1
            // 
            tENLOPLabel1.AutoSize = true;
            tENLOPLabel1.Location = new System.Drawing.Point(336, 60);
            tENLOPLabel1.Name = "tENLOPLabel1";
            tENLOPLabel1.Size = new System.Drawing.Size(53, 15);
            tENLOPLabel1.TabIndex = 10;
            tENLOPLabel1.Text = "TENLOP:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(35, 172);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(49, 15);
            dIACHILabel.TabIndex = 8;
            dIACHILabel.Text = "DIACHI:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(16, 144);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(68, 15);
            nGAYSINHLabel.TabIndex = 6;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(53, 116);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(31, 15);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(56, 88);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(28, 15);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.Location = new System.Drawing.Point(42, 60);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(42, 15);
            mASVLabel.TabIndex = 0;
            mASVLabel.Text = "MASV:";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "TN_CSDLPT_PRODDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.taClass;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = this.taStudent;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taStudent
            // 
            this.taStudent.ClearBeforeFill = true;
            // 
            // ctxMenu
            // 
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCtxAddStudent,
            this.btnCtxDeleteStudent,
            this.btnCtxEditStudent,
            this.btnCtxMoveStudent,
            this.btnCtxSaveStudent,
            this.btnCtxUndoStudent,
            this.btnCtxRefreshStudent});
            this.ctxMenu.Name = "contextMenuStrip1";
            this.ctxMenu.Size = new System.Drawing.Size(210, 158);
            // 
            // btnCtxAddStudent
            // 
            this.btnCtxAddStudent.Name = "btnCtxAddStudent";
            this.btnCtxAddStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxAddStudent.Text = "New Student";
            // 
            // btnCtxDeleteStudent
            // 
            this.btnCtxDeleteStudent.Name = "btnCtxDeleteStudent";
            this.btnCtxDeleteStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxDeleteStudent.Text = "Delete Student";
            // 
            // btnCtxEditStudent
            // 
            this.btnCtxEditStudent.Name = "btnCtxEditStudent";
            this.btnCtxEditStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxEditStudent.Text = "Edit Student";
            // 
            // btnCtxMoveStudent
            // 
            this.btnCtxMoveStudent.Name = "btnCtxMoveStudent";
            this.btnCtxMoveStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxMoveStudent.Text = "Change Class For Student";
            // 
            // btnCtxSaveStudent
            // 
            this.btnCtxSaveStudent.Name = "btnCtxSaveStudent";
            this.btnCtxSaveStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxSaveStudent.Text = "Save Student";
            // 
            // btnCtxUndoStudent
            // 
            this.btnCtxUndoStudent.Name = "btnCtxUndoStudent";
            this.btnCtxUndoStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxUndoStudent.Text = "Undo";
            // 
            // btnCtxRefreshStudent
            // 
            this.btnCtxRefreshStudent.Name = "btnCtxRefreshStudent";
            this.btnCtxRefreshStudent.Size = new System.Drawing.Size(209, 22);
            this.btnCtxRefreshStudent.Text = "Refresh List";
            // 
            // bdsStudent
            // 
            this.bdsStudent.DataMember = "FK_SINHVIEN_LOP";
            this.bdsStudent.DataSource = this.bdsClass;
            // 
            // barManager1
            // 
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barClass,
            this.bar1,
            this.barStudent});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl2);
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
            this.btnLocation,
            this.btnChangeStudentClass,
            this.btnMode,
            this.btnNewStudent,
            this.btnEditStudent,
            this.btnCancelStudent,
            this.btnDeleteStudent,
            this.btnUndoStudent,
            this.btnRefreshStudent,
            this.btnCommitStudent});
            this.barManager1.MainMenu = this.bar1;
            this.barManager1.MaxItemId = 28;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxLocation,
            this.swMode});
            // 
            // barClass
            // 
            this.barClass.BarName = "Bar Class";
            this.barClass.DockCol = 0;
            this.barClass.DockRow = 0;
            this.barClass.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barClass.FloatLocation = new System.Drawing.Point(61, 234);
            this.barClass.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCommit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.barClass.OptionsBar.AllowQuickCustomization = false;
            this.barClass.OptionsBar.DisableCustomization = true;
            this.barClass.OptionsBar.DrawDragBorder = false;
            this.barClass.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.barClass.Text = "Tools";
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
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.AutoSize = true;
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl2.Manager = this.barManager1;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(636, 42);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
            // 
            // bar1
            // 
            this.bar1.BarItemVertIndent = 10;
            this.bar1.BarName = "Tool Bar";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.btnLocation, "", false, true, true, 250),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHelp),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnMode)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
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
            this.cbxLocation.SelectedIndexChanged += new System.EventHandler(this.cbxLocation_SelectedIndexChanged);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 9;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            // 
            // btnHelp
            // 
            this.btnHelp.Caption = "info";
            this.btnHelp.Id = 11;
            this.btnHelp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHelp.ImageOptions.SvgImage")));
            this.btnHelp.Name = "btnHelp";
            // 
            // btnMode
            // 
            this.btnMode.Caption = "Mode";
            this.btnMode.Edit = this.swMode;
            this.btnMode.Id = 19;
            this.btnMode.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMode.ImageOptions.SvgImage")));
            this.btnMode.Name = "btnMode";
            this.btnMode.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // swMode
            // 
            this.swMode.AllowFocused = false;
            this.swMode.AutoWidth = true;
            this.swMode.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.swMode.Name = "swMode";
            this.swMode.OffText = "Class";
            this.swMode.OnText = "Student";
            // 
            // barStudent
            // 
            this.barStudent.BarName = "barStudent";
            this.barStudent.DockCol = 0;
            this.barStudent.DockRow = 0;
            this.barStudent.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barStudent.FloatLocation = new System.Drawing.Point(574, 247);
            this.barStudent.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCommitStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshStudent),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeStudentClass)});
            this.barStudent.OptionsBar.AllowQuickCustomization = false;
            this.barStudent.OptionsBar.DisableCustomization = true;
            this.barStudent.OptionsBar.DrawDragBorder = false;
            this.barStudent.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.barStudent.Text = "Custom 4";
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Caption = "New";
            this.btnNewStudent.Id = 21;
            this.btnNewStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewStudent.ImageOptions.SvgImage")));
            this.btnNewStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNewStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewStudent_Click);
            // 
            // btnEditStudent
            // 
            this.btnEditStudent.Caption = "Edit";
            this.btnEditStudent.Id = 22;
            this.btnEditStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditStudent.ImageOptions.SvgImage")));
            this.btnEditStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEditStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditStudent_ItemClick);
            // 
            // btnCommitStudent
            // 
            this.btnCommitStudent.Caption = "Commit";
            this.btnCommitStudent.Id = 27;
            this.btnCommitStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCommitStudent.ImageOptions.SvgImage")));
            this.btnCommitStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCommitStudent.Name = "btnCommitStudent";
            this.btnCommitStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCommitStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCommitStudent_ItemClick);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Caption = "Delete";
            this.btnDeleteStudent.Id = 24;
            this.btnDeleteStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteStudent.ImageOptions.SvgImage")));
            this.btnDeleteStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeleteStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteStudent_ItemClick);
            // 
            // btnUndoStudent
            // 
            this.btnUndoStudent.Caption = "Undo";
            this.btnUndoStudent.Id = 25;
            this.btnUndoStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoStudent.ImageOptions.SvgImage")));
            this.btnUndoStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnUndoStudent.Name = "btnUndoStudent";
            this.btnUndoStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndoStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoStudent_ItemClick);
            // 
            // btnCancelStudent
            // 
            this.btnCancelStudent.Caption = "Cancel";
            this.btnCancelStudent.Id = 23;
            this.btnCancelStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelStudent.ImageOptions.SvgImage")));
            this.btnCancelStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelStudent.Name = "btnCancelStudent";
            this.btnCancelStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancelStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelStudent_ItemClick);
            // 
            // btnRefreshStudent
            // 
            this.btnRefreshStudent.Caption = "Refresh";
            this.btnRefreshStudent.Id = 26;
            this.btnRefreshStudent.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshStudent.ImageOptions.SvgImage")));
            this.btnRefreshStudent.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreshStudent.Name = "btnRefreshStudent";
            this.btnRefreshStudent.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshStudent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshStudent_ItemClick);
            // 
            // btnChangeStudentClass
            // 
            this.btnChangeStudentClass.Caption = "Change Class";
            this.btnChangeStudentClass.Id = 15;
            this.btnChangeStudentClass.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChangeStudentClass.ImageOptions.SvgImage")));
            this.btnChangeStudentClass.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnChangeStudentClass.Name = "btnChangeStudentClass";
            this.btnChangeStudentClass.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnChangeStudentClass.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeStudentClass_ItemClick);
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(796, 42);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1440, 38);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1440, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 38);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 652);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1440, 38);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 652);
            // 
            // bdsDepartment
            // 
            this.bdsDepartment.DataMember = "KHOA";
            this.bdsDepartment.DataSource = this.DataSet;
            // 
            // pcClass
            // 
            this.pcClass.Controls.Add(this.gcClassInfo);
            this.pcClass.Controls.Add(this.gcClass);
            this.pcClass.Controls.Add(this.standaloneBarDockControl2);
            this.pcClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcClass.Location = new System.Drawing.Point(0, 38);
            this.pcClass.Name = "pcClass";
            this.pcClass.Size = new System.Drawing.Size(640, 652);
            this.pcClass.TabIndex = 12;
            // 
            // gcClassInfo
            // 
            this.gcClassInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcClassInfo.CaptionImageOptions.SvgImage")));
            this.gcClassInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcClassInfo.Controls.Add(mAKHLabel);
            this.gcClassInfo.Controls.Add(this.cbxDepartment);
            this.gcClassInfo.Controls.Add(tENLOPLabel);
            this.gcClassInfo.Controls.Add(this.teClassName);
            this.gcClassInfo.Controls.Add(mALOPLabel);
            this.gcClassInfo.Controls.Add(this.teClassId);
            this.gcClassInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcClassInfo.Location = new System.Drawing.Point(2, 444);
            this.gcClassInfo.Name = "gcClassInfo";
            this.gcClassInfo.Size = new System.Drawing.Size(636, 206);
            this.gcClassInfo.TabIndex = 11;
            this.gcClassInfo.Text = "Class Info";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Location = new System.Drawing.Point(88, 113);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartment.Size = new System.Drawing.Size(200, 22);
            this.cbxDepartment.TabIndex = 6;
            // 
            // teClassName
            // 
            this.teClassName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsClass, "TENLOP", true));
            this.teClassName.Location = new System.Drawing.Point(88, 85);
            this.teClassName.Name = "teClassName";
            this.teClassName.Size = new System.Drawing.Size(200, 22);
            this.teClassName.TabIndex = 4;
            // 
            // teClassId
            // 
            this.teClassId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsClass, "MALOP", true));
            this.teClassId.Location = new System.Drawing.Point(88, 57);
            this.teClassId.Name = "teClassId";
            this.teClassId.Size = new System.Drawing.Size(200, 22);
            this.teClassId.TabIndex = 2;
            // 
            // gcClass
            // 
            this.gcClass.DataSource = this.bdsClass;
            this.gcClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcClass.Location = new System.Drawing.Point(2, 44);
            this.gcClass.MainView = this.gvClass;
            this.gcClass.Name = "gcClass";
            this.gcClass.Size = new System.Drawing.Size(636, 400);
            this.gcClass.TabIndex = 10;
            this.gcClass.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClass});
            // 
            // gvClass
            // 
            this.gvClass.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALOP1,
            this.colTENLOP,
            this.colMAKH});
            this.gvClass.GridControl = this.gcClass;
            this.gvClass.Name = "gvClass";
            this.gvClass.OptionsBehavior.Editable = false;
            this.gvClass.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvClass_FocusedRowChanged);
            // 
            // colMALOP1
            // 
            this.colMALOP1.FieldName = "MALOP";
            this.colMALOP1.Name = "colMALOP1";
            this.colMALOP1.Visible = true;
            this.colMALOP1.VisibleIndex = 0;
            // 
            // colTENLOP
            // 
            this.colTENLOP.FieldName = "TENLOP";
            this.colTENLOP.Name = "colTENLOP";
            this.colTENLOP.Visible = true;
            this.colTENLOP.VisibleIndex = 1;
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 2;
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnChangeStudentClass)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // taDepartment
            // 
            this.taDepartment.ClearBeforeFill = true;
            // 
            // pcStudent
            // 
            this.pcStudent.Controls.Add(this.gcStudentInfo);
            this.pcStudent.Controls.Add(this.gcStudent);
            this.pcStudent.Controls.Add(this.standaloneBarDockControl1);
            this.pcStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcStudent.Location = new System.Drawing.Point(640, 38);
            this.pcStudent.Name = "pcStudent";
            this.pcStudent.Size = new System.Drawing.Size(800, 652);
            this.pcStudent.TabIndex = 17;
            // 
            // gcStudentInfo
            // 
            this.gcStudentInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcStudentInfo.CaptionImageOptions.SvgImage")));
            this.gcStudentInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcStudentInfo.Controls.Add(tENLOPLabel1);
            this.gcStudentInfo.Controls.Add(this.cbxStudentClass);
            this.gcStudentInfo.Controls.Add(dIACHILabel);
            this.gcStudentInfo.Controls.Add(this.teAddress);
            this.gcStudentInfo.Controls.Add(nGAYSINHLabel);
            this.gcStudentInfo.Controls.Add(this.deBirthDate);
            this.gcStudentInfo.Controls.Add(tENLabel);
            this.gcStudentInfo.Controls.Add(this.teFirstName);
            this.gcStudentInfo.Controls.Add(hOLabel);
            this.gcStudentInfo.Controls.Add(this.teLastName);
            this.gcStudentInfo.Controls.Add(mASVLabel);
            this.gcStudentInfo.Controls.Add(this.teStudentId);
            this.gcStudentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcStudentInfo.Location = new System.Drawing.Point(2, 444);
            this.gcStudentInfo.Name = "gcStudentInfo";
            this.gcStudentInfo.Size = new System.Drawing.Size(796, 206);
            this.gcStudentInfo.TabIndex = 3;
            this.gcStudentInfo.Text = "Student Info";
            // 
            // cbxStudentClass
            // 
            this.cbxStudentClass.Location = new System.Drawing.Point(395, 57);
            this.cbxStudentClass.MenuManager = this.barManager1;
            this.cbxStudentClass.Name = "cbxStudentClass";
            this.cbxStudentClass.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxStudentClass.Size = new System.Drawing.Size(200, 22);
            this.cbxStudentClass.TabIndex = 11;
            // 
            // teAddress
            // 
            this.teAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "DIACHI", true));
            this.teAddress.Location = new System.Drawing.Point(90, 169);
            this.teAddress.MenuManager = this.barManager1;
            this.teAddress.Name = "teAddress";
            this.teAddress.Size = new System.Drawing.Size(200, 22);
            this.teAddress.TabIndex = 9;
            // 
            // deBirthDate
            // 
            this.deBirthDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "NGAYSINH", true));
            this.deBirthDate.EditValue = null;
            this.deBirthDate.Location = new System.Drawing.Point(90, 141);
            this.deBirthDate.MenuManager = this.barManager1;
            this.deBirthDate.Name = "deBirthDate";
            this.deBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deBirthDate.Size = new System.Drawing.Size(200, 22);
            this.deBirthDate.TabIndex = 7;
            // 
            // teFirstName
            // 
            this.teFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "TEN", true));
            this.teFirstName.Location = new System.Drawing.Point(90, 113);
            this.teFirstName.MenuManager = this.barManager1;
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Size = new System.Drawing.Size(200, 22);
            this.teFirstName.TabIndex = 5;
            // 
            // teLastName
            // 
            this.teLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "HO", true));
            this.teLastName.Location = new System.Drawing.Point(90, 85);
            this.teLastName.MenuManager = this.barManager1;
            this.teLastName.Name = "teLastName";
            this.teLastName.Size = new System.Drawing.Size(200, 22);
            this.teLastName.TabIndex = 3;
            // 
            // teStudentId
            // 
            this.teStudentId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsStudent, "MASV", true));
            this.teStudentId.Location = new System.Drawing.Point(90, 57);
            this.teStudentId.MenuManager = this.barManager1;
            this.teStudentId.Name = "teStudentId";
            this.teStudentId.Size = new System.Drawing.Size(200, 22);
            this.teStudentId.TabIndex = 1;
            // 
            // gcStudent
            // 
            this.gcStudent.ContextMenuStrip = this.ctxMenu;
            this.gcStudent.DataSource = this.bdsStudent;
            this.gcStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcStudent.Location = new System.Drawing.Point(2, 44);
            this.gcStudent.MainView = this.gvStudent;
            this.gcStudent.Name = "gcStudent";
            this.gcStudent.Size = new System.Drawing.Size(796, 400);
            this.gcStudent.TabIndex = 2;
            this.gcStudent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStudent});
            // 
            // gvStudent
            // 
            this.gvStudent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHO,
            this.colTEN,
            this.colNGAYSINH,
            this.colDIACHI,
            this.colMALOP});
            this.gvStudent.GridControl = this.gcStudent;
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.OptionsBehavior.Editable = false;
            this.gvStudent.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvStudent_FocusedRowChanged);
            // 
            // colMASV
            // 
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 3;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            // 
            // colMALOP
            // 
            this.colMALOP.FieldName = "MALOP";
            this.colMALOP.Name = "colMALOP";
            this.colMALOP.Visible = true;
            this.colMALOP.VisibleIndex = 5;
            // 
            // FormClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1440, 690);
            this.Controls.Add(this.pcStudent);
            this.Controls.Add(this.pcClass);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormClass";
            this.Text = "Class Management";
            this.Load += new System.EventHandler(this.FormClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsClass)).EndInit();
            this.ctxMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcClass)).EndInit();
            this.pcClass.ResumeLayout(false);
            this.pcClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcClassInfo)).EndInit();
            this.gcClassInfo.ResumeLayout(false);
            this.gcClassInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClassName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teClassId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcStudent)).EndInit();
            this.pcStudent.ResumeLayout(false);
            this.pcStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudentInfo)).EndInit();
            this.gcStudentInfo.ResumeLayout(false);
            this.gcStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxStudentClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teStudentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdsClass;
        private TN_CSDLPT_PRODDataSet DataSet;
        private TN_CSDLPT_PRODDataSetTableAdapters.LOPTableAdapter taClass;
        private TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPT_PRODDataSetTableAdapters.SINHVIENTableAdapter taStudent;
        private System.Windows.Forms.BindingSource bdsStudent;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barClass;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnCommit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarEditItem btnLocation;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem btnCtxAddStudent;
        private DevExpress.XtraEditors.PanelControl pcClass;
        private System.Windows.Forms.ToolStripMenuItem btnCtxDeleteStudent;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnChangeStudentClass;
        private System.Windows.Forms.BindingSource bdsDepartment;
        private TN_CSDLPT_PRODDataSetTableAdapters.KHOATableAdapter taDepartment;
        private System.Windows.Forms.ToolStripMenuItem btnCtxEditStudent;
        private System.Windows.Forms.ToolStripMenuItem btnCtxMoveStudent;
        private System.Windows.Forms.ToolStripMenuItem btnCtxSaveStudent;
        private System.Windows.Forms.ToolStripMenuItem btnCtxUndoStudent;
        private System.Windows.Forms.ToolStripMenuItem btnCtxRefreshStudent;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cbxLocation;
        private DevExpress.XtraBars.BarEditItem btnMode;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch swMode;
        private DevExpress.XtraEditors.PanelControl pcStudent;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.Bar barStudent;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraGrid.GridControl gcClass;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClass;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOP;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraEditors.GroupControl gcClassInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDepartment;
        private DevExpress.XtraEditors.TextEdit teClassName;
        private DevExpress.XtraEditors.TextEdit teClassId;
        private DevExpress.XtraGrid.GridControl gcStudent;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStudent;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMALOP;
        private DevExpress.XtraEditors.GroupControl gcStudentInfo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxStudentClass;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.DateEdit deBirthDate;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraEditors.TextEdit teStudentId;
        private DevExpress.XtraBars.BarButtonItem btnNewStudent;
        private DevExpress.XtraBars.BarButtonItem btnEditStudent;
        private DevExpress.XtraBars.BarButtonItem btnCancelStudent;
        private DevExpress.XtraBars.BarButtonItem btnDeleteStudent;
        private DevExpress.XtraBars.BarButtonItem btnCommitStudent;
        private DevExpress.XtraBars.BarButtonItem btnUndoStudent;
        private DevExpress.XtraBars.BarButtonItem btnRefreshStudent;
    }
}