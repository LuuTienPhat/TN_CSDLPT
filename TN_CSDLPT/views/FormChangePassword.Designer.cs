namespace TN_CSDLPT.views
{
    partial class FormChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePassword));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccept = new DevExpress.XtraEditors.SimpleButton();
            this.teNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.teCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbUsername = new DevExpress.XtraEditors.LabelControl();
            this.teConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurrentPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.Location = new System.Drawing.Point(103, 43);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(157, 25);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Change Password";
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Location = new System.Drawing.Point(203, 374);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancel";
            // 
            // btnAccept
            // 
            this.btnAccept.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAccept.Appearance.Options.UseFont = true;
            this.btnAccept.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightBottom;
            this.btnAccept.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAccept.ImageOptions.SvgImage")));
            this.btnAccept.ImageOptions.SvgImageSize = new System.Drawing.Size(15, 15);
            this.btnAccept.Location = new System.Drawing.Point(58, 374);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 40);
            this.btnAccept.TabIndex = 18;
            this.btnAccept.Text = "Accept";
            // 
            // teNewPassword
            // 
            this.teNewPassword.Location = new System.Drawing.Point(25, 209);
            this.teNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.teNewPassword.Name = "teNewPassword";
            this.teNewPassword.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teNewPassword.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teNewPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teNewPassword.Properties.UseSystemPasswordChar = true;
            this.teNewPassword.Size = new System.Drawing.Size(312, 22);
            this.teNewPassword.TabIndex = 17;
            // 
            // teCurrentPassword
            // 
            this.teCurrentPassword.Location = new System.Drawing.Point(25, 140);
            this.teCurrentPassword.Margin = new System.Windows.Forms.Padding(4);
            this.teCurrentPassword.Name = "teCurrentPassword";
            this.teCurrentPassword.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teCurrentPassword.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teCurrentPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teCurrentPassword.Properties.UseSystemPasswordChar = true;
            this.teCurrentPassword.Size = new System.Drawing.Size(312, 22);
            this.teCurrentPassword.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 188);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 15);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "New Password";
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(25, 119);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(93, 15);
            this.lbUsername.TabIndex = 14;
            this.lbUsername.Text = "Current Password";
            // 
            // teConfirmPassword
            // 
            this.teConfirmPassword.Location = new System.Drawing.Point(25, 293);
            this.teConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.teConfirmPassword.Name = "teConfirmPassword";
            this.teConfirmPassword.Properties.AdvancedModeOptions.AllowCaretAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teConfirmPassword.Properties.AdvancedModeOptions.AllowSelectionAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.teConfirmPassword.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.teConfirmPassword.Properties.UseSystemPasswordChar = true;
            this.teConfirmPassword.Size = new System.Drawing.Size(312, 22);
            this.teConfirmPassword.TabIndex = 21;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 272);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 15);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Confirm Password";
            // 
            // FormChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 455);
            this.Controls.Add(this.teConfirmPassword);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.teNewPassword);
            this.Controls.Add(this.teCurrentPassword);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lbUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormChangePassword";
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.teNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCurrentPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teConfirmPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnAccept;
        private DevExpress.XtraEditors.TextEdit teNewPassword;
        private DevExpress.XtraEditors.TextEdit teCurrentPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lbUsername;
        private DevExpress.XtraEditors.TextEdit teConfirmPassword;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}