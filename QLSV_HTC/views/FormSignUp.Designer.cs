namespace TN_CSDLPT.views
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ceTeacher = new DevExpress.XtraEditors.CheckEdit();
            this.ceStudent = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxLocation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSignUp = new DevExpress.XtraEditors.SimpleButton();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceTeacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStudent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.ceTeacher);
            this.groupControl1.Controls.Add(this.ceStudent);
            this.groupControl1.Location = new System.Drawing.Point(118, 193);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(219, 31);
            this.groupControl1.TabIndex = 23;
            this.groupControl1.Text = "groupControl1";
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
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 199);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(23, 15);
            this.labelControl5.TabIndex = 22;
            this.labelControl5.Text = "Role";
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
            this.labelControl1.Size = new System.Drawing.Size(365, 80);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Sign Up";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(25, 117);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(46, 15);
            this.labelControl4.TabIndex = 21;
            this.labelControl4.Text = "Location";
            // 
            // cbxLocation
            // 
            this.cbxLocation.Location = new System.Drawing.Point(25, 140);
            this.cbxLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbxLocation.Name = "cbxLocation";
            this.cbxLocation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLocation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLocation.Size = new System.Drawing.Size(312, 22);
            this.cbxLocation.TabIndex = 20;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Location = new System.Drawing.Point(203, 396);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSignUp.Appearance.Options.UseFont = true;
            this.btnSignUp.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightBottom;
            this.btnSignUp.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSignUp.ImageOptions.SvgImage")));
            this.btnSignUp.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnSignUp.Location = new System.Drawing.Point(58, 396);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(100, 40);
            this.btnSignUp.TabIndex = 18;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(25, 334);
            this.tePassword.Margin = new System.Windows.Forms.Padding(4);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(312, 22);
            this.tePassword.TabIndex = 17;
            // 
            // teUsername
            // 
            this.teUsername.Location = new System.Drawing.Point(25, 265);
            this.teUsername.Margin = new System.Windows.Forms.Padding(4);
            this.teUsername.Name = "teUsername";
            this.teUsername.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teUsername.Size = new System.Drawing.Size(312, 22);
            this.teUsername.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 313);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 15);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(25, 244);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(53, 15);
            this.lbUsername.TabIndex = 14;
            this.lbUsername.Text = "Username";
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 492);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbxLocation);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tePassword);
            this.Controls.Add(this.teUsername);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbUsername);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceTeacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceStudent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teUsername.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit ceTeacher;
        private DevExpress.XtraEditors.CheckEdit ceStudent;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLocation;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSignUp;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teUsername;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbUsername;
    }
}