namespace StudentsInformationSystem.UI.Modules
{
    partial class UcCourses
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
            this.btn_addcourse = new DevExpress.XtraEditors.SimpleButton();
            this.groupc_addcourse = new DevExpress.XtraEditors.GroupControl();
            this.cbox_department = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_addcourse = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbl_course_dep = new DevExpress.XtraEditors.LabelControl();
            this.lbl_course = new DevExpress.XtraEditors.LabelControl();
            this.lbl_course_id = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_select = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).BeginInit();
            this.groupc_addcourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_department.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_addcourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addcourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addcourse.Appearance.Options.UseFont = true;
            this.btn_addcourse.Location = new System.Drawing.Point(432, 210);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(117, 41);
            this.btn_addcourse.TabIndex = 0;
            this.btn_addcourse.Text = "Add";
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // groupc_addcourse
            // 
            this.groupc_addcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupc_addcourse.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupc_addcourse.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupc_addcourse.Appearance.Options.UseBorderColor = true;
            this.groupc_addcourse.Appearance.Options.UseFont = true;
            this.groupc_addcourse.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupc_addcourse.AppearanceCaption.Options.UseFont = true;
            this.groupc_addcourse.Controls.Add(this.btn_addcourse);
            this.groupc_addcourse.Controls.Add(this.cbox_department);
            this.groupc_addcourse.Controls.Add(this.txt_addcourse);
            this.groupc_addcourse.Location = new System.Drawing.Point(0, 0);
            this.groupc_addcourse.Name = "groupc_addcourse";
            this.groupc_addcourse.Size = new System.Drawing.Size(675, 292);
            this.groupc_addcourse.TabIndex = 1;
            this.groupc_addcourse.Text = "Add Course";
            // 
            // cbox_department
            // 
            this.cbox_department.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_department.Location = new System.Drawing.Point(137, 100);
            this.cbox_department.Name = "cbox_department";
            this.cbox_department.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_department.Properties.Appearance.Options.UseFont = true;
            this.cbox_department.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_department.Size = new System.Drawing.Size(412, 32);
            this.cbox_department.TabIndex = 0;
            this.cbox_department.SelectedIndexChanged += new System.EventHandler(this.cbox_department_SelectedIndexChanged_2);
            // 
            // txt_addcourse
            // 
            this.txt_addcourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addcourse.Location = new System.Drawing.Point(137, 158);
            this.txt_addcourse.Name = "txt_addcourse";
            this.txt_addcourse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcourse.Properties.Appearance.Options.UseFont = true;
            this.txt_addcourse.Size = new System.Drawing.Size(412, 32);
            this.txt_addcourse.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lbl_course_dep);
            this.groupControl1.Controls.Add(this.lbl_course);
            this.groupControl1.Controls.Add(this.lbl_course_id);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btn_delete);
            this.groupControl1.Controls.Add(this.btn_select);
            this.groupControl1.Location = new System.Drawing.Point(0, 287);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(675, 272);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Remove Course";
            // 
            // lbl_course_dep
            // 
            this.lbl_course_dep.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_dep.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_course_dep.Appearance.Options.UseFont = true;
            this.lbl_course_dep.Appearance.Options.UseForeColor = true;
            this.lbl_course_dep.Location = new System.Drawing.Point(284, 169);
            this.lbl_course_dep.Name = "lbl_course_dep";
            this.lbl_course_dep.Size = new System.Drawing.Size(0, 21);
            this.lbl_course_dep.TabIndex = 1;
            // 
            // lbl_course
            // 
            this.lbl_course.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_course.Appearance.Options.UseFont = true;
            this.lbl_course.Appearance.Options.UseForeColor = true;
            this.lbl_course.Location = new System.Drawing.Point(284, 119);
            this.lbl_course.Name = "lbl_course";
            this.lbl_course.Size = new System.Drawing.Size(0, 21);
            this.lbl_course.TabIndex = 1;
            // 
            // lbl_course_id
            // 
            this.lbl_course_id.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_course_id.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbl_course_id.Appearance.Options.UseFont = true;
            this.lbl_course_id.Appearance.Options.UseForeColor = true;
            this.lbl_course_id.Location = new System.Drawing.Point(284, 63);
            this.lbl_course_id.Name = "lbl_course_id";
            this.lbl_course_id.Size = new System.Drawing.Size(0, 21);
            this.lbl_course_id.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(56, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 25);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Course ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(56, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Course ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(56, 169);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(168, 25);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Course Department";
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Appearance.Options.UseFont = true;
            this.btn_delete.Location = new System.Drawing.Point(427, 217);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(117, 30);
            this.btn_delete.TabIndex = 0;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_select
            // 
            this.btn_select.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_select.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_select.Appearance.Options.UseFont = true;
            this.btn_select.Location = new System.Drawing.Point(284, 217);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(117, 30);
            this.btn_select.TabIndex = 0;
            this.btn_select.Text = "Select Course";
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // UcCourses
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupc_addcourse);
            this.Name = "UcCourses";
            this.Size = new System.Drawing.Size(675, 559);
            this.Load += new System.EventHandler(this.UcCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).EndInit();
            this.groupc_addcourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbox_department.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_addcourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_addcourse;
        private DevExpress.XtraEditors.GroupControl groupc_addcourse;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_department;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_addcourse;
        private DevExpress.XtraEditors.SimpleButton btn_select;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.LabelControl lbl_course_dep;
        private DevExpress.XtraEditors.LabelControl lbl_course;
        private DevExpress.XtraEditors.LabelControl lbl_course_id;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
