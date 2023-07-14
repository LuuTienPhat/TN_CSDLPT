namespace TN_CSDLPT
{
    partial class FormSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignIn));
            this.teUsername = new DevExpress.XtraEditors.TextEdit();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cbxDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ceTeacher = new DevExpress.XtraEditors.CheckEdit();
            this.ceStudent = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teUsername
            // 
            this.teUsername.Location = new System.Drawing.Point(25, 246);
            this.teUsername.Margin = new System.Windows.Forms.Padding(4);
            this.teUsername.Name = "teUsername";
            this.teUsername.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Size = new System.Drawing.Size(312, 22);
            this.teUsername.TabIndex = 3;
            this.teUsername.ToolTip = "Please enter Username.";
            this.teUsername.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(25, 315);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(312, 22);
            this.tePassword.TabIndex = 4;
            this.tePassword.ToolTip = "Please enter Password.";
            this.tePassword.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.Appearance.Options.UseFont = true;
            this.btnSignIn.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightBottom;
            this.btnSignIn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSignIn.ImageOptions.SvgImage")));
            this.btnSignIn.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnSignIn.Location = new System.Drawing.Point(58, 377);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(100, 40);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Location = new System.Drawing.Point(203, 377);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.Location = new System.Drawing.Point(25, 121);
            this.cbxDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDepartment.Size = new System.Drawing.Size(312, 22);
            this.cbxDepartment.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 98);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 15);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Deparment";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 294);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 15);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(25, 225);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 15);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(364, 80);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Sign In";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 180);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 15);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Role";
            // 
            // ceTeacher
            // 
            this.ceTeacher.AutoSizeInLayoutControl = true;
            this.ceTeacher.Dock = System.Windows.Forms.DockStyle.Left;
            this.ceTeacher.EditValue = true;
            this.ceTeacher.Location = new System.Drawing.Point(12, 2);
            this.ceTeacher.Name = "ceTeacher";
            this.ceTeacher.Properties.Caption = "Teacher";
            this.ceTeacher.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceTeacher.Size = new System.Drawing.Size(75, 27);
            this.ceTeacher.TabIndex = 10;
            this.ceTeacher.CheckedChanged += new System.EventHandler(this.ceTeacher_CheckedChanged);
            // 
            // ceStudent
            // 
            this.ceStudent.AutoSizeInLayoutControl = true;
            this.ceStudent.Dock = System.Windows.Forms.DockStyle.Right;
            this.ceStudent.Location = new System.Drawing.Point(144, 2);
            this.ceStudent.Name = "ceStudent";
            this.ceStudent.Properties.Caption = "Student";
            this.ceStudent.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.ceStudent.Size = new System.Drawing.Size(63, 27);
            this.ceStudent.TabIndex = 11;
            this.ceStudent.CheckedChanged += new System.EventHandler(this.ceStudent_CheckedChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.ceTeacher);
            this.groupControl1.Controls.Add(this.ceStudent);
            this.groupControl1.Location = new System.Drawing.Point(118, 174);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(219, 31);
            this.groupControl1.TabIndex = 12;
            this.groupControl1.Text = "groupControl1";
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 455);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUsername);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbUsername);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("FormSignIn.IconOptions.SvgImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign In";
            this.Load += new System.EventHandler(this.FormSignIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit teUsername;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.SimpleButton btnSignIn;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.ComboBoxEdit cbxDepartment;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbUsername;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit ceTeacher;
        private DevExpress.XtraEditors.CheckEdit ceStudent;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}

