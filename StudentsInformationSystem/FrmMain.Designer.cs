namespace StudentsInformationSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.frm_main_acc_control = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.m_element_Staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_additional_staff_info = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_student = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_addstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_srchstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rmstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_schedule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_sched = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_room = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_add_user = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rm_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_depart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_subjects = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_departments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_course = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.log_out = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.frm_main_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.frm_main_acc_control)).BeginInit();
            this.directXFormContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm_main_acc_control
            // 
            this.frm_main_acc_control.Appearance.AccordionControl.BackColor = System.Drawing.Color.SteelBlue;
            this.frm_main_acc_control.Appearance.AccordionControl.BorderColor = System.Drawing.Color.LightCyan;
            this.frm_main_acc_control.Appearance.AccordionControl.ForeColor = System.Drawing.Color.RosyBrown;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseBackColor = true;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseForeColor = true;
            this.frm_main_acc_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.frm_main_acc_control.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.m_element_Staff,
            this.m_element_student,
            this.m_element_schedule,
            this.m_element_users,
            this.m_element_depart,
            this.log_out});
            this.frm_main_acc_control.Location = new System.Drawing.Point(0, 0);
            this.frm_main_acc_control.Name = "frm_main_acc_control";
            this.frm_main_acc_control.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.frm_main_acc_control.Size = new System.Drawing.Size(250, 559);
            this.frm_main_acc_control.TabIndex = 1;
            this.frm_main_acc_control.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // m_element_Staff
            // 
            this.m_element_Staff.Appearance.Default.BackColor = System.Drawing.Color.DarkCyan;
            this.m_element_Staff.Appearance.Default.Options.UseBackColor = true;
            this.m_element_Staff.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_staff,
            this.s_element_additional_staff_info});
            this.m_element_Staff.Expanded = true;
            this.m_element_Staff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_Staff.ImageOptions.SvgImage")));
            this.m_element_Staff.Name = "m_element_Staff";
            this.m_element_Staff.Text = "Staff";
            // 
            // s_element_staff
            // 
            this.s_element_staff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_staff.ImageOptions.SvgImage")));
            this.s_element_staff.Name = "s_element_staff";
            this.s_element_staff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_staff.Text = "Staff";
            this.s_element_staff.Click += new System.EventHandler(this.s_element_addtcher_Click);
            // 
            // s_element_additional_staff_info
            // 
            this.s_element_additional_staff_info.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_additional_staff_info.ImageOptions.SvgImage")));
            this.s_element_additional_staff_info.Name = "s_element_additional_staff_info";
            this.s_element_additional_staff_info.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_additional_staff_info.Text = "Additional Staff Info";
            this.s_element_additional_staff_info.Click += new System.EventHandler(this.s_element_additional_staff_info_Click);
            // 
            // m_element_student
            // 
            this.m_element_student.Appearance.Default.BackColor = System.Drawing.Color.SteelBlue;
            this.m_element_student.Appearance.Default.Options.UseBackColor = true;
            this.m_element_student.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_addstdnt,
            this.s_element_srchstdnt,
            this.s_element_rmstdnt});
            this.m_element_student.Expanded = true;
            this.m_element_student.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_student.ImageOptions.SvgImage")));
            this.m_element_student.Name = "m_element_student";
            this.m_element_student.Text = "Students";
            // 
            // s_element_addstdnt
            // 
            this.s_element_addstdnt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_addstdnt.ImageOptions.SvgImage")));
            this.s_element_addstdnt.Name = "s_element_addstdnt";
            this.s_element_addstdnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_addstdnt.Text = "Add Student";
            this.s_element_addstdnt.Click += new System.EventHandler(this.s_element_addstdnt_Click_1);
            // 
            // s_element_srchstdnt
            // 
            this.s_element_srchstdnt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_srchstdnt.ImageOptions.SvgImage")));
            this.s_element_srchstdnt.Name = "s_element_srchstdnt";
            this.s_element_srchstdnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_srchstdnt.Text = "Add Student Detailed Info";
            this.s_element_srchstdnt.Click += new System.EventHandler(this.s_element_srchstdnt_Click);
            // 
            // s_element_rmstdnt
            // 
            this.s_element_rmstdnt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_rmstdnt.ImageOptions.SvgImage")));
            this.s_element_rmstdnt.Name = "s_element_rmstdnt";
            this.s_element_rmstdnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_rmstdnt.Text = "Student List";
            this.s_element_rmstdnt.Click += new System.EventHandler(this.s_element_rmstdnt_Click_1);
            // 
            // m_element_schedule
            // 
            this.m_element_schedule.Appearance.Default.BackColor = System.Drawing.Color.SteelBlue;
            this.m_element_schedule.Appearance.Default.Options.UseBackColor = true;
            this.m_element_schedule.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_sched,
            this.s_element_room});
            this.m_element_schedule.Expanded = true;
            this.m_element_schedule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_schedule.ImageOptions.SvgImage")));
            this.m_element_schedule.Name = "m_element_schedule";
            this.m_element_schedule.Text = "Schedule";
            // 
            // s_element_sched
            // 
            this.s_element_sched.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_sched.ImageOptions.SvgImage")));
            this.s_element_sched.Name = "s_element_sched";
            this.s_element_sched.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_sched.Text = "Schedule";
            this.s_element_sched.Click += new System.EventHandler(this.s_element_checksched_Click);
            // 
            // s_element_room
            // 
            this.s_element_room.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_room.ImageOptions.SvgImage")));
            this.s_element_room.Name = "s_element_room";
            this.s_element_room.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_room.Text = "Rooms";
            this.s_element_room.Click += new System.EventHandler(this.s_element_room_Click);
            // 
            // m_element_users
            // 
            this.m_element_users.Appearance.Default.BackColor = System.Drawing.Color.SteelBlue;
            this.m_element_users.Appearance.Default.Options.UseBackColor = true;
            this.m_element_users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_add_user,
            this.s_element_rm_users});
            this.m_element_users.Expanded = true;
            this.m_element_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_users.ImageOptions.SvgImage")));
            this.m_element_users.Name = "m_element_users";
            this.m_element_users.Text = "Users";
            // 
            // s_element_add_user
            // 
            this.s_element_add_user.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_add_user.ImageOptions.SvgImage")));
            this.s_element_add_user.Name = "s_element_add_user";
            this.s_element_add_user.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_add_user.Text = "Add Users";
            this.s_element_add_user.Click += new System.EventHandler(this.s_element_add_user_Click);
            // 
            // s_element_rm_users
            // 
            this.s_element_rm_users.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_rm_users.ImageOptions.SvgImage")));
            this.s_element_rm_users.Name = "s_element_rm_users";
            this.s_element_rm_users.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_rm_users.Text = "Remove Users";
            // 
            // m_element_depart
            // 
            this.m_element_depart.Appearance.Default.BackColor = System.Drawing.Color.SteelBlue;
            this.m_element_depart.Appearance.Default.Options.UseBackColor = true;
            this.m_element_depart.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_subjects,
            this.s_element_departments,
            this.s_element_course});
            this.m_element_depart.Expanded = true;
            this.m_element_depart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_depart.ImageOptions.SvgImage")));
            this.m_element_depart.Name = "m_element_depart";
            this.m_element_depart.Text = "Department";
            // 
            // s_element_subjects
            // 
            this.s_element_subjects.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_subjects.ImageOptions.SvgImage")));
            this.s_element_subjects.Name = "s_element_subjects";
            this.s_element_subjects.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_subjects.Text = "Subjects";
            this.s_element_subjects.Click += new System.EventHandler(this.s_element_subjects_Click);
            // 
            // s_element_departments
            // 
            this.s_element_departments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_departments.ImageOptions.SvgImage")));
            this.s_element_departments.Name = "s_element_departments";
            this.s_element_departments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_departments.Text = "Departments";
            this.s_element_departments.Click += new System.EventHandler(this.s_element_departments_Click);
            // 
            // s_element_course
            // 
            this.s_element_course.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_course.ImageOptions.SvgImage")));
            this.s_element_course.Name = "s_element_course";
            this.s_element_course.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_course.Text = "Course";
            this.s_element_course.Click += new System.EventHandler(this.s_element_course_Click);
            // 
            // log_out
            // 
            this.log_out.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("log_out.ImageOptions.SvgImage")));
            this.log_out.Name = "log_out";
            this.log_out.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.log_out.Text = "LOG OUT";
            this.log_out.Click += new System.EventHandler(this.log_out_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement2});
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement2
            // 
            this.accordionControlElement2.Name = "accordionControlElement2";
            this.accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement2.Text = "Element2";
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.frm_main_container);
            this.directXFormContainerControl1.Controls.Add(this.frm_main_acc_control);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(925, 559);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // frm_main_container
            // 
            this.frm_main_container.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.frm_main_container.Appearance.Options.UseBackColor = true;
            this.frm_main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_main_container.Location = new System.Drawing.Point(250, 0);
            this.frm_main_container.LookAndFeel.SkinName = "Office 2010 Blue";
            this.frm_main_container.LookAndFeel.UseDefaultLookAndFeel = false;
            this.frm_main_container.Name = "frm_main_container";
            this.frm_main_container.Size = new System.Drawing.Size(675, 559);
            this.frm_main_container.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.BorderColor = System.Drawing.Color.Magenta;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(925, 559);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMain.IconOptions.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BENEDICTO SIS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmMain_LoadAsync);
            ((System.ComponentModel.ISupportInitialize)(this.frm_main_acc_control)).EndInit();
            this.directXFormContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl frm_main_acc_control;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_student;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_schedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_addstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_srchstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rmstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_Staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_add_user;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rm_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_sched;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_room;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_depart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_subjects;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_departments;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_course;
        private DevExpress.XtraBars.Navigation.AccordionControlElement log_out;
        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer frm_main_container;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_additional_staff_info;
    }
}