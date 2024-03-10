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
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupc_addcourse = new DevExpress.XtraEditors.GroupControl();
            this.btn_addcourse = new DevExpress.XtraEditors.SimpleButton();
            this.txt_addcourse = new DevExpress.XtraEditors.TextEdit();
            this.cbox_department = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gcont_course = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).BeginInit();
            this.groupc_addcourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_addcourse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_department.Properties)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcont_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(660, 437);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(660, 437);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "ADD";
            this.tabNavigationPage1.Controls.Add(this.groupc_addcourse);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(660, 400);
            // 
            // groupc_addcourse
            // 
            this.groupc_addcourse.Controls.Add(this.btn_addcourse);
            this.groupc_addcourse.Controls.Add(this.txt_addcourse);
            this.groupc_addcourse.Controls.Add(this.cbox_department);
            this.groupc_addcourse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupc_addcourse.Location = new System.Drawing.Point(0, 0);
            this.groupc_addcourse.Name = "groupc_addcourse";
            this.groupc_addcourse.Size = new System.Drawing.Size(660, 400);
            this.groupc_addcourse.TabIndex = 0;
            this.groupc_addcourse.Text = "ADD COURSE";
            // 
            // btn_addcourse
            // 
            this.btn_addcourse.Location = new System.Drawing.Point(272, 181);
            this.btn_addcourse.Name = "btn_addcourse";
            this.btn_addcourse.Size = new System.Drawing.Size(86, 37);
            this.btn_addcourse.TabIndex = 1;
            this.btn_addcourse.Text = "ADD";
            this.btn_addcourse.Click += new System.EventHandler(this.btn_addcourse_Click);
            // 
            // txt_addcourse
            // 
            this.txt_addcourse.Location = new System.Drawing.Point(160, 127);
            this.txt_addcourse.Name = "txt_addcourse";
            this.txt_addcourse.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addcourse.Properties.Appearance.Options.UseFont = true;
            this.txt_addcourse.Size = new System.Drawing.Size(297, 32);
            this.txt_addcourse.TabIndex = 0;
            // 
            // cbox_department
            // 
            this.cbox_department.Location = new System.Drawing.Point(160, 84);
            this.cbox_department.Name = "cbox_department";
            this.cbox_department.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_department.Properties.Appearance.Options.UseFont = true;
            this.cbox_department.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_department.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbox_department.Size = new System.Drawing.Size(297, 32);
            this.cbox_department.TabIndex = 0;
            this.cbox_department.SelectedIndexChanged += new System.EventHandler(this.cbox_department_SelectedIndexChanged);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "REMOVE";
            this.tabNavigationPage2.Controls.Add(this.gcont_course);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(660, 414);
            // 
            // gcont_course
            // 
            this.gcont_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcont_course.Location = new System.Drawing.Point(0, 0);
            this.gcont_course.MainView = this.gridView1;
            this.gcont_course.Name = "gcont_course";
            this.gcont_course.Size = new System.Drawing.Size(660, 309);
            this.gcont_course.TabIndex = 0;
            this.gcont_course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gcont_course;
            this.gridView1.Name = "gridView1";
            // 
            // UcCourses
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "UcCourses";
            this.Size = new System.Drawing.Size(660, 437);
            this.Load += new System.EventHandler(this.UcCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupc_addcourse)).EndInit();
            this.groupc_addcourse.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_addcourse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_department.Properties)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcont_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraEditors.GroupControl groupc_addcourse;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraEditors.SimpleButton btn_addcourse;
        private DevExpress.XtraEditors.TextEdit txt_addcourse;
        private DevExpress.XtraGrid.GridControl gcont_course;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_department;
    }
}
