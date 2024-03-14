namespace StudentsInformationSystem
{
    partial class FrmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoading));
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.peLogo = new DevExpress.XtraEditors.PictureEdit();
            this.labelStatus = new DevExpress.XtraEditors.LabelControl();
            this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
            this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.peImage);
            this.directXFormContainerControl1.Controls.Add(this.peLogo);
            this.directXFormContainerControl1.Controls.Add(this.labelStatus);
            this.directXFormContainerControl1.Controls.Add(this.labelCopyright);
            this.directXFormContainerControl1.Controls.Add(this.progressBarControl);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(925, 559);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // peImage
            // 
            this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
            this.peImage.Location = new System.Drawing.Point(0, 0);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
            this.peImage.Size = new System.Drawing.Size(925, 321);
            this.peImage.TabIndex = 14;
            // 
            // peLogo
            // 
            this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
            this.peLogo.Location = new System.Drawing.Point(652, 416);
            this.peLogo.Name = "peLogo";
            this.peLogo.Properties.AllowFocused = false;
            this.peLogo.Properties.Appearance.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.peLogo.Properties.Appearance.Options.UseBackColor = true;
            this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peLogo.Properties.ShowMenu = false;
            this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peLogo.Size = new System.Drawing.Size(249, 141);
            this.peLogo.TabIndex = 13;
            // 
            // labelStatus
            // 
            this.labelStatus.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.Appearance.Options.UseFont = true;
            this.labelStatus.Location = new System.Drawing.Point(24, 330);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(78, 25);
            this.labelStatus.TabIndex = 12;
            this.labelStatus.Text = "Starting...";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Appearance.Options.UseFont = true;
            this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelCopyright.Location = new System.Drawing.Point(24, 500);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(217, 30);
            this.labelCopyright.TabIndex = 11;
            this.labelCopyright.Text = "Copyright © 2024-2030";
            // 
            // progressBarControl
            // 
            this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarControl.EditValue = 0;
            this.progressBarControl.Location = new System.Drawing.Point(24, 373);
            this.progressBarControl.Name = "progressBarControl";
            this.progressBarControl.Size = new System.Drawing.Size(877, 22);
            this.progressBarControl.TabIndex = 10;
            // 
            // FrmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(925, 559);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoading";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLoading_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private DevExpress.XtraEditors.PictureEdit peLogo;
        private DevExpress.XtraEditors.LabelControl labelStatus;
        private DevExpress.XtraEditors.LabelControl labelCopyright;
        private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
    }
}