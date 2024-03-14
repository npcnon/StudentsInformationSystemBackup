namespace StudentsInformationSystem.UI.Modules
{
    partial class UcDepartment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupc_addcourse = new DevExpress.XtraEditors.GroupControl();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_department = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).BeginInit();
            this.groupc_addcourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupc_addcourse
            // 
            this.groupc_addcourse.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupc_addcourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupc_addcourse.Appearance.Options.UseBorderColor = true;
            this.groupc_addcourse.Appearance.Options.UseFont = true;
            this.groupc_addcourse.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupc_addcourse.AppearanceCaption.Options.UseFont = true;
            this.groupc_addcourse.Controls.Add(this.btn_save);
            this.groupc_addcourse.Controls.Add(this.txt_department);
            this.groupc_addcourse.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupc_addcourse.Location = new System.Drawing.Point(0, 0);
            this.groupc_addcourse.Name = "groupc_addcourse";
            this.groupc_addcourse.Size = new System.Drawing.Size(675, 292);
            this.groupc_addcourse.TabIndex = 2;
            this.groupc_addcourse.Text = "Add Department";
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Location = new System.Drawing.Point(395, 159);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(117, 30);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Add";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_department
            // 
            this.txt_department.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_department.Location = new System.Drawing.Point(100, 91);
            this.txt_department.Name = "txt_department";
            this.txt_department.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_department.Properties.Appearance.Options.UseFont = true;
            this.txt_department.Size = new System.Drawing.Size(412, 32);
            this.txt_department.TabIndex = 0;
            // 
            // UcDepartment
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupc_addcourse);
            this.Name = "UcDepartment";
            this.Size = new System.Drawing.Size(675, 559);
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).EndInit();
            this.groupc_addcourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupc_addcourse;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.TextEdit txt_department;
    }
}
