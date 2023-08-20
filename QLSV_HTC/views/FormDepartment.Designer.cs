namespace TN_CSDLPT
{
    partial class FormDepartment
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
            System.Windows.Forms.Label mACSLabel;
            System.Windows.Forms.Label tENKHLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mAKHLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartment));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDepartment = new DevExpress.XtraBars.Bar();
            this.btnNew = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnCommit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancel = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnLocation = new DevExpress.XtraBars.BarEditItem();
            this.cbxLocation = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barTeacher = new DevExpress.XtraBars.Bar();
            this.btnNewTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnCommitTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnDeleteTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndoTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnCancelTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefreshTeacher = new DevExpress.XtraBars.BarButtonItem();
            this.standaloneBarDockControl2 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DataSet = new TN_CSDLPT.TN_CSDLPT_PRODDataSet();
            this.bdsDepartment = new System.Windows.Forms.BindingSource(this.components);
            this.taDepartment = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.KHOATableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager();
            this.taTeacher = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIENTableAdapter();
            this.bdsTeacher = new System.Windows.Forms.BindingSource(this.components);
            this.pcDepartment = new DevExpress.XtraEditors.PanelControl();
            this.gcDepartmentInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxDepartmentLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bdsLocation = new System.Windows.Forms.BindingSource(this.components);
            this.teDepartmentName = new DevExpress.XtraEditors.TextEdit();
            this.teDepartmentId = new DevExpress.XtraEditors.TextEdit();
            this.gcDepartment = new DevExpress.XtraGrid.GridControl();
            this.gvDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pcTeacher = new DevExpress.XtraEditors.PanelControl();
            this.gcTeacherInfo = new DevExpress.XtraEditors.GroupControl();
            this.cbxDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teTeacherAddress = new DevExpress.XtraEditors.TextEdit();
            this.teTeacherFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teTeacherLastName = new DevExpress.XtraEditors.TextEdit();
            this.teTeacherId = new DevExpress.XtraEditors.TextEdit();
            this.gcTeacher = new DevExpress.XtraGrid.GridControl();
            this.gvTeacher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taLocation = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.COSOTableAdapter();
            mACSLabel = new System.Windows.Forms.Label();
            tENKHLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mAKHLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDepartment)).BeginInit();
            this.pcDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartmentInfo)).BeginInit();
            this.gcDepartmentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartmentLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDepartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDepartmentId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTeacher)).BeginInit();
            this.pcTeacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacherInfo)).BeginInit();
            this.gcTeacherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // mACSLabel
            // 
            mACSLabel.AutoSize = true;
            mACSLabel.Location = new System.Drawing.Point(35, 103);
            mACSLabel.Name = "mACSLabel";
            mACSLabel.Size = new System.Drawing.Size(43, 15);
            mACSLabel.TabIndex = 5;
            mACSLabel.Text = "MACS:";
            // 
            // tENKHLabel
            // 
            tENKHLabel.AutoSize = true;
            tENKHLabel.Location = new System.Drawing.Point(31, 75);
            tENKHLabel.Name = "tENKHLabel";
            tENKHLabel.Size = new System.Drawing.Size(47, 15);
            tENKHLabel.TabIndex = 3;
            tENKHLabel.Text = "TENKH:";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(33, 47);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(45, 15);
            mAKHLabel.TabIndex = 1;
            mAKHLabel.Text = "MAKH:";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(44, 47);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(44, 15);
            mAGVLabel.TabIndex = 0;
            mAGVLabel.Text = "MAGV:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(60, 75);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(28, 15);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(57, 103);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(31, 15);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(39, 131);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(49, 15);
            dIACHILabel.TabIndex = 6;
            dIACHILabel.Text = "DIACHI:";
            // 
            // mAKHLabel1
            // 
            mAKHLabel1.AutoSize = true;
            mAKHLabel1.Location = new System.Drawing.Point(362, 47);
            mAKHLabel1.Name = "mAKHLabel1";
            mAKHLabel1.Size = new System.Drawing.Size(45, 15);
            mAKHLabel1.TabIndex = 8;
            mAKHLabel1.Text = "MAKH:";
            // 
            // barManager1
            // 
            this.barManager1.AllowMoveBarOnToolbar = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barDepartment,
            this.bar3,
            this.barTeacher});
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
            this.btnNewTeacher,
            this.btnEditTeacher,
            this.btnCommitTeacher,
            this.btnDeleteTeacher,
            this.btnUndoTeacher,
            this.btnCancelTeacher,
            this.btnRefreshTeacher});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 22;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cbxLocation});
            // 
            // barDepartment
            // 
            this.barDepartment.BarName = "Bar Department";
            this.barDepartment.DockCol = 0;
            this.barDepartment.DockRow = 0;
            this.barDepartment.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barDepartment.FloatLocation = new System.Drawing.Point(262, 265);
            this.barDepartment.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCommit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancel),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefresh)});
            this.barDepartment.OptionsBar.DrawBorder = false;
            this.barDepartment.OptionsBar.DrawDragBorder = false;
            this.barDepartment.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.barDepartment.Text = "Tools";
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
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.AutoSize = true;
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(636, 42);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
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
            this.btnLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cbxLocation.ImageOptions.SvgImage")));
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
            // barTeacher
            // 
            this.barTeacher.BarName = "Bar Teacher";
            this.barTeacher.DockCol = 0;
            this.barTeacher.DockRow = 0;
            this.barTeacher.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.barTeacher.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEditTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCommitTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDeleteTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndoTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCancelTeacher),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRefreshTeacher)});
            this.barTeacher.OptionsBar.DrawBorder = false;
            this.barTeacher.OptionsBar.DrawDragBorder = false;
            this.barTeacher.StandaloneBarDockControl = this.standaloneBarDockControl2;
            this.barTeacher.Text = "Custom 4";
            // 
            // btnNewTeacher
            // 
            this.btnNewTeacher.Caption = "New";
            this.btnNewTeacher.Id = 15;
            this.btnNewTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNewTeacher.ImageOptions.SvgImage")));
            this.btnNewTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnNewTeacher.Name = "btnNewTeacher";
            this.btnNewTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnNewTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewTeacher_ItemClick);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Caption = "Edit";
            this.btnEditTeacher.Id = 16;
            this.btnEditTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditTeacher.ImageOptions.SvgImage")));
            this.btnEditTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnEditTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditTeacher_ItemClick);
            // 
            // btnCommitTeacher
            // 
            this.btnCommitTeacher.Caption = "Commit";
            this.btnCommitTeacher.Id = 17;
            this.btnCommitTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCommitTeacher.ImageOptions.SvgImage")));
            this.btnCommitTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCommitTeacher.Name = "btnCommitTeacher";
            this.btnCommitTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCommitTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCommitTeacher_ItemClick);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Caption = "Delete";
            this.btnDeleteTeacher.Id = 18;
            this.btnDeleteTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTeacher.ImageOptions.SvgImage")));
            this.btnDeleteTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDeleteTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDeleteTeacher_ItemClick);
            // 
            // btnUndoTeacher
            // 
            this.btnUndoTeacher.Caption = "Undo";
            this.btnUndoTeacher.Id = 19;
            this.btnUndoTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndoTeacher.ImageOptions.SvgImage")));
            this.btnUndoTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnUndoTeacher.Name = "btnUndoTeacher";
            this.btnUndoTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndoTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndoTeacher_ItemClick);
            // 
            // btnCancelTeacher
            // 
            this.btnCancelTeacher.Caption = "Cancel";
            this.btnCancelTeacher.Id = 20;
            this.btnCancelTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCancelTeacher.ImageOptions.SvgImage")));
            this.btnCancelTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnCancelTeacher.Name = "btnCancelTeacher";
            this.btnCancelTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnCancelTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCancelTeacher_ItemClick);
            // 
            // btnRefreshTeacher
            // 
            this.btnRefreshTeacher.Caption = "Refresh";
            this.btnRefreshTeacher.Id = 21;
            this.btnRefreshTeacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefreshTeacher.ImageOptions.SvgImage")));
            this.btnRefreshTeacher.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnRefreshTeacher.Name = "btnRefreshTeacher";
            this.btnRefreshTeacher.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRefreshTeacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefreshTeacher_ItemClick);
            // 
            // standaloneBarDockControl2
            // 
            this.standaloneBarDockControl2.AutoSize = true;
            this.standaloneBarDockControl2.CausesValidation = false;
            this.standaloneBarDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl2.Location = new System.Drawing.Point(2, 2);
            this.standaloneBarDockControl2.Manager = this.barManager1;
            this.standaloneBarDockControl2.Name = "standaloneBarDockControl2";
            this.standaloneBarDockControl2.Size = new System.Drawing.Size(796, 42);
            this.standaloneBarDockControl2.Text = "standaloneBarDockControl2";
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
            // DataSet
            // 
            this.DataSet.DataSetName = "TN_CSDLPT_PRODDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsDepartment
            // 
            this.bdsDepartment.DataMember = "KHOA";
            this.bdsDepartment.DataSource = this.DataSet;
            // 
            // taDepartment
            // 
            this.taDepartment.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BANGDIEMTableAdapter = null;
            this.tableAdapterManager.BODETableAdapter = null;
            this.tableAdapterManager.COSOTableAdapter = null;
            this.tableAdapterManager.CT_BAITHITableAdapter = null;
            this.tableAdapterManager.GIAOVIEN_DANGKYTableAdapter = null;
            this.tableAdapterManager.GIAOVIENTableAdapter = this.taTeacher;
            this.tableAdapterManager.KHOATableAdapter = this.taDepartment;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taTeacher
            // 
            this.taTeacher.ClearBeforeFill = true;
            // 
            // bdsTeacher
            // 
            this.bdsTeacher.DataMember = "FK_GIAOVIEN_KHOA";
            this.bdsTeacher.DataSource = this.bdsDepartment;
            // 
            // pcDepartment
            // 
            this.pcDepartment.Controls.Add(this.gcDepartmentInfo);
            this.pcDepartment.Controls.Add(this.gcDepartment);
            this.pcDepartment.Controls.Add(this.standaloneBarDockControl1);
            this.pcDepartment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcDepartment.Location = new System.Drawing.Point(0, 38);
            this.pcDepartment.Name = "pcDepartment";
            this.pcDepartment.Size = new System.Drawing.Size(640, 652);
            this.pcDepartment.TabIndex = 11;
            // 
            // gcDepartmentInfo
            // 
            this.gcDepartmentInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcDepartmentInfo.CaptionImageOptions.SvgImage")));
            this.gcDepartmentInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcDepartmentInfo.Controls.Add(this.cbxDepartmentLocation);
            this.gcDepartmentInfo.Controls.Add(mACSLabel);
            this.gcDepartmentInfo.Controls.Add(tENKHLabel);
            this.gcDepartmentInfo.Controls.Add(this.teDepartmentName);
            this.gcDepartmentInfo.Controls.Add(mAKHLabel);
            this.gcDepartmentInfo.Controls.Add(this.teDepartmentId);
            this.gcDepartmentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDepartmentInfo.Location = new System.Drawing.Point(2, 444);
            this.gcDepartmentInfo.Name = "gcDepartmentInfo";
            this.gcDepartmentInfo.Size = new System.Drawing.Size(636, 206);
            this.gcDepartmentInfo.TabIndex = 8;
            this.gcDepartmentInfo.Text = "Department Info";
            // 
            // cbxDepartmentLocation
            // 
            this.cbxDepartmentLocation.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLocation, "MACS", true));
            this.cbxDepartmentLocation.Location = new System.Drawing.Point(84, 100);
            this.cbxDepartmentLocation.MenuManager = this.barManager1;
            this.cbxDepartmentLocation.Name = "cbxDepartmentLocation";
            this.cbxDepartmentLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartmentLocation.Size = new System.Drawing.Size(200, 22);
            this.cbxDepartmentLocation.TabIndex = 6;
            // 
            // bdsLocation
            // 
            this.bdsLocation.DataMember = "COSO";
            this.bdsLocation.DataSource = this.DataSet;
            // 
            // teDepartmentName
            // 
            this.teDepartmentName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepartment, "TENKH", true));
            this.teDepartmentName.Location = new System.Drawing.Point(84, 72);
            this.teDepartmentName.MenuManager = this.barManager1;
            this.teDepartmentName.Name = "teDepartmentName";
            this.teDepartmentName.Size = new System.Drawing.Size(200, 22);
            this.teDepartmentName.TabIndex = 4;
            // 
            // teDepartmentId
            // 
            this.teDepartmentId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDepartment, "MAKH", true));
            this.teDepartmentId.Location = new System.Drawing.Point(84, 44);
            this.teDepartmentId.MenuManager = this.barManager1;
            this.teDepartmentId.Name = "teDepartmentId";
            this.teDepartmentId.Size = new System.Drawing.Size(200, 22);
            this.teDepartmentId.TabIndex = 2;
            // 
            // gcDepartment
            // 
            this.gcDepartment.DataSource = this.bdsDepartment;
            this.gcDepartment.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDepartment.Location = new System.Drawing.Point(2, 44);
            this.gcDepartment.MainView = this.gvDepartment;
            this.gcDepartment.MenuManager = this.barManager1;
            this.gcDepartment.Name = "gcDepartment";
            this.gcDepartment.Size = new System.Drawing.Size(636, 400);
            this.gcDepartment.TabIndex = 6;
            this.gcDepartment.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDepartment});
            // 
            // gvDepartment
            // 
            this.gvDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKH,
            this.colTENKH,
            this.colMACS});
            this.gvDepartment.GridControl = this.gcDepartment;
            this.gvDepartment.Name = "gvDepartment";
            this.gvDepartment.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDepartment_FocusedRowChanged);
            // 
            // colMAKH
            // 
            this.colMAKH.FieldName = "MAKH";
            this.colMAKH.Name = "colMAKH";
            this.colMAKH.Visible = true;
            this.colMAKH.VisibleIndex = 0;
            // 
            // colTENKH
            // 
            this.colTENKH.FieldName = "TENKH";
            this.colTENKH.Name = "colTENKH";
            this.colTENKH.Visible = true;
            this.colTENKH.VisibleIndex = 1;
            // 
            // colMACS
            // 
            this.colMACS.FieldName = "MACS";
            this.colMACS.Name = "colMACS";
            this.colMACS.Visible = true;
            this.colMACS.VisibleIndex = 2;
            // 
            // pcTeacher
            // 
            this.pcTeacher.Controls.Add(this.gcTeacherInfo);
            this.pcTeacher.Controls.Add(this.gcTeacher);
            this.pcTeacher.Controls.Add(this.standaloneBarDockControl2);
            this.pcTeacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcTeacher.Location = new System.Drawing.Point(640, 38);
            this.pcTeacher.Name = "pcTeacher";
            this.pcTeacher.Size = new System.Drawing.Size(800, 652);
            this.pcTeacher.TabIndex = 13;
            // 
            // gcTeacherInfo
            // 
            this.gcTeacherInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcTeacherInfo.CaptionImageOptions.SvgImage")));
            this.gcTeacherInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcTeacherInfo.Controls.Add(this.cbxDepartment);
            this.gcTeacherInfo.Controls.Add(mAKHLabel1);
            this.gcTeacherInfo.Controls.Add(dIACHILabel);
            this.gcTeacherInfo.Controls.Add(this.teTeacherAddress);
            this.gcTeacherInfo.Controls.Add(tENLabel);
            this.gcTeacherInfo.Controls.Add(this.teTeacherFirstName);
            this.gcTeacherInfo.Controls.Add(hOLabel);
            this.gcTeacherInfo.Controls.Add(this.teTeacherLastName);
            this.gcTeacherInfo.Controls.Add(mAGVLabel);
            this.gcTeacherInfo.Controls.Add(this.teTeacherId);
            this.gcTeacherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTeacherInfo.Location = new System.Drawing.Point(2, 444);
            this.gcTeacherInfo.Name = "gcTeacherInfo";
            this.gcTeacherInfo.Size = new System.Drawing.Size(796, 206);
            this.gcTeacherInfo.TabIndex = 15;
            this.gcTeacherInfo.Text = "Teacher Info";
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "MAKH", true));
            this.cbxDepartment.Location = new System.Drawing.Point(413, 44);
            this.cbxDepartment.MenuManager = this.barManager1;
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartment.Size = new System.Drawing.Size(200, 22);
            this.cbxDepartment.TabIndex = 10;
            // 
            // teTeacherAddress
            // 
            this.teTeacherAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "DIACHI", true));
            this.teTeacherAddress.Location = new System.Drawing.Point(94, 128);
            this.teTeacherAddress.MenuManager = this.barManager1;
            this.teTeacherAddress.Name = "teTeacherAddress";
            this.teTeacherAddress.Size = new System.Drawing.Size(200, 22);
            this.teTeacherAddress.TabIndex = 7;
            // 
            // teTeacherFirstName
            // 
            this.teTeacherFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "TEN", true));
            this.teTeacherFirstName.Location = new System.Drawing.Point(94, 100);
            this.teTeacherFirstName.MenuManager = this.barManager1;
            this.teTeacherFirstName.Name = "teTeacherFirstName";
            this.teTeacherFirstName.Size = new System.Drawing.Size(200, 22);
            this.teTeacherFirstName.TabIndex = 5;
            // 
            // teTeacherLastName
            // 
            this.teTeacherLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "HO", true));
            this.teTeacherLastName.Location = new System.Drawing.Point(94, 72);
            this.teTeacherLastName.MenuManager = this.barManager1;
            this.teTeacherLastName.Name = "teTeacherLastName";
            this.teTeacherLastName.Size = new System.Drawing.Size(200, 22);
            this.teTeacherLastName.TabIndex = 3;
            // 
            // teTeacherId
            // 
            this.teTeacherId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTeacher, "MAGV", true));
            this.teTeacherId.Location = new System.Drawing.Point(94, 44);
            this.teTeacherId.MenuManager = this.barManager1;
            this.teTeacherId.Name = "teTeacherId";
            this.teTeacherId.Size = new System.Drawing.Size(200, 22);
            this.teTeacherId.TabIndex = 1;
            // 
            // gcTeacher
            // 
            this.gcTeacher.DataSource = this.bdsTeacher;
            this.gcTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcTeacher.Location = new System.Drawing.Point(2, 44);
            this.gcTeacher.MainView = this.gvTeacher;
            this.gcTeacher.MenuManager = this.barManager1;
            this.gcTeacher.Name = "gcTeacher";
            this.gcTeacher.Size = new System.Drawing.Size(796, 400);
            this.gcTeacher.TabIndex = 14;
            this.gcTeacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTeacher});
            // 
            // gvTeacher
            // 
            this.gvTeacher.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colMAKH1});
            this.gvTeacher.GridControl = this.gcTeacher;
            this.gvTeacher.Name = "gvTeacher";
            this.gvTeacher.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvTeacher_FocusedRowChanged);
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 0;
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
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colMAKH1
            // 
            this.colMAKH1.FieldName = "MAKH";
            this.colMAKH1.Name = "colMAKH1";
            this.colMAKH1.Visible = true;
            this.colMAKH1.VisibleIndex = 4;
            // 
            // taLocation
            // 
            this.taLocation.ClearBeforeFill = true;
            // 
            // FormDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 690);
            this.Controls.Add(this.pcTeacher);
            this.Controls.Add(this.pcDepartment);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDepartment";
            this.Text = "Department Manager";
            this.Load += new System.EventHandler(this.FormDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcDepartment)).EndInit();
            this.pcDepartment.ResumeLayout(false);
            this.pcDepartment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartmentInfo)).EndInit();
            this.gcDepartmentInfo.ResumeLayout(false);
            this.gcDepartmentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartmentLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDepartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teDepartmentId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcTeacher)).EndInit();
            this.pcTeacher.ResumeLayout(false);
            this.pcTeacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacherInfo)).EndInit();
            this.gcTeacherInfo.ResumeLayout(false);
            this.gcTeacherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTeacherId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barDepartment;
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
        private System.Windows.Forms.BindingSource bdsDepartment;
        private TN_CSDLPT_PRODDataSet DataSet;
        private TN_CSDLPT_PRODDataSetTableAdapters.KHOATableAdapter taDepartment;
        private TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIENTableAdapter taTeacher;
        private System.Windows.Forms.BindingSource bdsTeacher;
        private DevExpress.XtraEditors.PanelControl pcDepartment;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraGrid.GridControl gcDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView gvDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMACS;
        private DevExpress.XtraEditors.GroupControl gcDepartmentInfo;
        private DevExpress.XtraEditors.TextEdit teDepartmentName;
        private DevExpress.XtraEditors.TextEdit teDepartmentId;
        private DevExpress.XtraEditors.PanelControl pcTeacher;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl2;
        private DevExpress.XtraBars.Bar barTeacher;
        private DevExpress.XtraGrid.GridControl gcTeacher;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTeacher;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKH1;
        private DevExpress.XtraEditors.GroupControl gcTeacherInfo;
        private DevExpress.XtraEditors.TextEdit teTeacherFirstName;
        private DevExpress.XtraEditors.TextEdit teTeacherLastName;
        private DevExpress.XtraEditors.TextEdit teTeacherId;
        private DevExpress.XtraEditors.TextEdit teTeacherAddress;
        private System.Windows.Forms.BindingSource bdsLocation;
        private TN_CSDLPT_PRODDataSetTableAdapters.COSOTableAdapter taLocation;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDepartmentLocation;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDepartment;
        private DevExpress.XtraBars.BarButtonItem btnNewTeacher;
        private DevExpress.XtraBars.BarButtonItem btnEditTeacher;
        private DevExpress.XtraBars.BarButtonItem btnCommitTeacher;
        private DevExpress.XtraBars.BarButtonItem btnDeleteTeacher;
        private DevExpress.XtraBars.BarButtonItem btnUndoTeacher;
        private DevExpress.XtraBars.BarButtonItem btnCancelTeacher;
        private DevExpress.XtraBars.BarButtonItem btnRefreshTeacher;
    }
}