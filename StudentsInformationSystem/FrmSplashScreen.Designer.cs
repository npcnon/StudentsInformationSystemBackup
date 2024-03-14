namespace StudentsInformationSystem
{
    partial class FrmSplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplashScreen));
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(24, 371);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(877, 22);
            this.progressBarControl.TabIndex = 5;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(24, 498);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(217, 30);
            this.labelCopyright.TabIndex = 6;
            this.labelCopyright.Text = "Copyright © 2024-2030";
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(24, 328);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(78, 25);
            this.labelStatus.TabIndex = 7;
            this.labelStatus.Text = "Starting...";
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
            this.peImage.Location = new System.Drawing.Point(1, 1);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.peImage.Size = new System.Drawing.Size(923, 321);
            this.peImage.TabIndex = 9;
            // 
            // peLogo
            // 
            this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
            this.peLogo.Location = new System.Drawing.Point(652, 414);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peLogo.Size = new System.Drawing.Size(249, 141);
            this.peLogo.TabIndex = 8;
            // 
            // FrmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 559);
            this.Controls.Add(this.peImage);
            this.Controls.Add(this.peLogo);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.progressBarControl);
            this.Name = "FrmSplashScreen";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Text = "FrmSplashScreen";
            this.Load += new System.EventHandler(this.FrmSplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.PictureEdit peLogo;
    }
}
