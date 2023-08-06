namespace TN_CSDLPT.views
{
    partial class FormSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSubject));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.DataSet = new TN_CSDLPT.TN_CSDLPT_PRODDataSet();
            this.bdsSubject = new System.Windows.Forms.BindingSource(this.components);
            this.taSubject = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter();
            this.tableAdapterManager = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager();
            this.gcSubject = new DevExpress.XtraGrid.GridControl();
            this.gvSubject = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.cbxLocation = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnHelp = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gcInfo = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbId = new DevExpress.XtraEditors.LabelControl();
            this.teName = new DevExpress.XtraEditors.TextEdit();
            this.teID = new DevExpress.XtraEditors.TextEdit();
            this.bdsLocation = new System.Windows.Forms.BindingSource(this.components);
            this.taLocation = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.COSOTableAdapter();
            this.bdsScore = new System.Windows.Forms.BindingSource(this.components);
            this.taScore = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.BANGDIEMTableAdapter();
            this.bdsTopic = new System.Windows.Forms.BindingSource(this.components);
            this.taTopic = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.BODETableAdapter();
            this.bdsTeacher_Register = new System.Windows.Forms.BindingSource(this.components);
            this.taTeacher_Register = new TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).BeginInit();
            this.gcInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher_Register)).BeginInit();
            this.SuspendLayout();
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "TN_CSDLPT_PRODDataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = this.taSubject;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TN_CSDLPT.TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gcSubject
            // 
            this.gcSubject.DataSource = this.bdsSubject;
            this.gcSubject.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcSubject.Location = new System.Drawing.Point(0, 80);
            this.gcSubject.MainView = this.gvSubject;
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.Size = new System.Drawing.Size(1280, 388);
            this.gcSubject.TabIndex = 10;
            this.gcSubject.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSubject});
            // 
            // gvSubject
            // 
            this.gvSubject.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH});
            this.gvSubject.GridControl = this.gcSubject;
            this.gvSubject.Name = "gvSubject";
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "ID";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Name";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 1;
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
            this.cbxLocation});
            this.barManager1.MainMenu = this.bar3;
            this.barManager1.MaxItemId = 15;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSpinEdit1,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.cbxLocation, "", false, true, true, 250),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnHelp)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.MultiLine = true;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Main menu";
            // 
            // cbxLocation
            // 
            this.cbxLocation.Caption = "Location";
            this.cbxLocation.Edit = this.repositoryItemComboBox2;
            this.cbxLocation.Id = 14;
            this.cbxLocation.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("cbxLocation.ImageOptions.SvgImage")));
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
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
            // repositoryItemSpinEdit1
            // 
            this.repositoryItemSpinEdit1.AutoHeight = false;
            this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // gcInfo
            // 
            this.gcInfo.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("gcInfo.CaptionImageOptions.SvgImage")));
            this.gcInfo.CaptionImageOptions.SvgImageSize = new System.Drawing.Size(20, 20);
            this.gcInfo.Controls.Add(this.labelControl1);
            this.gcInfo.Controls.Add(this.lbId);
            this.gcInfo.Controls.Add(this.teName);
            this.gcInfo.Controls.Add(this.teID);
            this.gcInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcInfo.Location = new System.Drawing.Point(0, 468);
            this.gcInfo.Name = "gcInfo";
            this.gcInfo.Size = new System.Drawing.Size(1280, 222);
            this.gcInfo.TabIndex = 15;
            this.gcInfo.Text = "Info";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(87, 111);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 15);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Name:";
            // 
            // lbId
            // 
            this.lbId.Location = new System.Drawing.Point(87, 69);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(14, 15);
            this.lbId.TabIndex = 4;
            this.lbId.Text = "ID:";
            // 
            // teName
            // 
            this.teName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSubject, "TENMH", true));
            this.teName.Location = new System.Drawing.Point(149, 104);
            this.teName.MenuManager = this.barManager1;
            this.teName.Name = "teName";
            this.teName.Size = new System.Drawing.Size(289, 22);
            this.teName.TabIndex = 3;
            // 
            // teID
            // 
            this.teID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsSubject, "MAMH", true));
            this.teID.Location = new System.Drawing.Point(149, 62);
            this.teID.MenuManager = this.barManager1;
            this.teID.Name = "teID";
            this.teID.Size = new System.Drawing.Size(289, 22);
            this.teID.TabIndex = 1;
            // 
            // bdsLocation
            // 
            this.bdsLocation.DataMember = "COSO";
            this.bdsLocation.DataSource = this.DataSet;
            // 
            // taLocation
            // 
            this.taLocation.ClearBeforeFill = true;
            // 
            // bdsScore
            // 
            this.bdsScore.DataMember = "FK_BANGDIEM_MONHOC";
            this.bdsScore.DataSource = this.bdsSubject;
            // 
            // taScore
            // 
            this.taScore.ClearBeforeFill = true;
            // 
            // bdsTopic
            // 
            this.bdsTopic.DataMember = "FK_BODE_MONHOC";
            this.bdsTopic.DataSource = this.bdsSubject;
            // 
            // taTopic
            // 
            this.taTopic.ClearBeforeFill = true;
            // 
            // bdsTeacher_Register
            // 
            this.bdsTeacher_Register.DataMember = "FK_GIAOVIEN_DANGKY_MONHOC1";
            this.bdsTeacher_Register.DataSource = this.bdsSubject;
            // 
            // taTeacher_Register
            // 
            this.taTeacher_Register.ClearBeforeFill = true;
            // 
            // FormSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 690);
            this.Controls.Add(this.gcInfo);
            this.Controls.Add(this.gcSubject);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormSubject";
            this.Text = "Subject Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSubject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcInfo)).EndInit();
            this.gcInfo.ResumeLayout(false);
            this.gcInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTeacher_Register)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Bar bar1;
        private TN_CSDLPT_PRODDataSet DataSet;
        private System.Windows.Forms.BindingSource bdsSubject;
        private TN_CSDLPT_PRODDataSetTableAdapters.MONHOCTableAdapter taSubject;
        private TN_CSDLPT_PRODDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcSubject;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSubject;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.GroupControl gcInfo;
        private DevExpress.XtraBars.BarButtonItem btnNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnCommit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnCancel;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        private DevExpress.XtraBars.BarButtonItem btnHelp;
        private System.Windows.Forms.BindingSource bdsLocation;
        private TN_CSDLPT_PRODDataSetTableAdapters.COSOTableAdapter taLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarEditItem cbxLocation;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraEditors.TextEdit teName;
        private DevExpress.XtraEditors.TextEdit teID;
        private DevExpress.XtraEditors.LabelControl lbId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource bdsScore;
        private TN_CSDLPT_PRODDataSetTableAdapters.BANGDIEMTableAdapter taScore;
        private System.Windows.Forms.BindingSource bdsTopic;
        private TN_CSDLPT_PRODDataSetTableAdapters.BODETableAdapter taTopic;
        private System.Windows.Forms.BindingSource bdsTeacher_Register;
        private TN_CSDLPT_PRODDataSetTableAdapters.GIAOVIEN_DANGKYTableAdapter taTeacher_Register;
    }
}