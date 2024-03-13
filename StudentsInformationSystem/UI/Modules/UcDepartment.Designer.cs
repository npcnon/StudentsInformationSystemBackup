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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_id = new DevExpress.XtraEditors.LabelControl();
            this.lbl_department = new DevExpress.XtraEditors.LabelControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_select = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_department_output = new DevExpress.XtraEditors.LabelControl();
            this.lbl_id_output = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).BeginInit();
            this.groupc_addcourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseBorderColor = true;
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lbl_department_output);
            this.groupControl1.Controls.Add(this.lbl_id_output);
            this.groupControl1.Controls.Add(this.btn_delete);
            this.groupControl1.Controls.Add(this.btn_select);
            this.groupControl1.Controls.Add(this.lbl_id);
            this.groupControl1.Controls.Add(this.lbl_department);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 286);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(675, 273);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Remove Department";
            // 
            // lbl_id
            // 
            this.lbl_id.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Appearance.Options.UseFont = true;
            this.lbl_id.Location = new System.Drawing.Point(50, 75);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(129, 25);
            this.lbl_id.TabIndex = 2;
            this.lbl_id.Text = "Department ID";
            // 
            // lbl_department
            // 
            this.lbl_department.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department.Appearance.Options.UseFont = true;
            this.lbl_department.Location = new System.Drawing.Point(50, 142);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(104, 25);
            this.lbl_department.TabIndex = 3;
            this.lbl_department.Text = "Department";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Location = new System.Drawing.Point(391, 198);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 30);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Appearance.Options.UseFont = true;
            this.btn_select.Location = new System.Drawing.Point(248, 198);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(117, 30);
            this.btn_select.TabIndex = 5;
            this.btn_select.Text = "Select Course";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_department_output
            // 
            this.lbl_department_output.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_department_output.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_department_output.Appearance.Options.UseFont = true;
            this.lbl_department_output.Appearance.Options.UseForeColor = true;
            this.lbl_department_output.Location = new System.Drawing.Point(248, 135);
            this.lbl_department_output.Name = "lbl_department_output";
            this.lbl_department_output.Size = new System.Drawing.Size(0, 21);
            this.lbl_department_output.TabIndex = 7;
            // 
            // lbl_id_output
            // 
            this.lbl_id_output.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_output.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_id_output.Appearance.Options.UseFont = true;
            this.lbl_id_output.Appearance.Options.UseForeColor = true;
            this.lbl_id_output.Location = new System.Drawing.Point(248, 79);
            this.lbl_id_output.Name = "lbl_id_output";
            this.lbl_id_output.Size = new System.Drawing.Size(0, 21);
            this.lbl_id_output.TabIndex = 8;
            // 
            // UcDepartment
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupc_addcourse);
            this.Name = "UcDepartment";
            this.Size = new System.Drawing.Size(675, 559);
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).EndInit();
            this.groupc_addcourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupc_addcourse;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.TextEdit txt_department;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lbl_id;
        private DevExpress.XtraEditors.LabelControl lbl_department;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_select;
        private DevExpress.XtraEditors.LabelControl lbl_department_output;
        private DevExpress.XtraEditors.LabelControl lbl_id_output;
    }
}
