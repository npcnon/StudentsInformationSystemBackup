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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, null, true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.frm_main_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.frm_main_acc_control = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.m_element_Staff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_addstaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_srchstaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rmstaff = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_student = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_addstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_srchstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rmstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_schedule = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_addsched = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_remsched = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_checksched = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_room = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_add_user = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rm_users = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.m_element_depart = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_subjects = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_departments = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.frm_main_acc_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // frm_main_container
            // 
            this.frm_main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_main_container.Location = new System.Drawing.Point(201, 24);
            this.frm_main_container.Name = "frm_main_container";
            this.frm_main_container.Size = new System.Drawing.Size(716, 462);
            this.frm_main_container.TabIndex = 0;
            // 
            // frm_main_acc_control
            // 
            this.frm_main_acc_control.Appearance.AccordionControl.BackColor = System.Drawing.Color.Azure;
            this.frm_main_acc_control.Appearance.AccordionControl.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.frm_main_acc_control.Appearance.AccordionControl.ForeColor = System.Drawing.Color.SteelBlue;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseBackColor = true;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseBorderColor = true;
            this.frm_main_acc_control.Appearance.AccordionControl.Options.UseForeColor = true;
            this.frm_main_acc_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.frm_main_acc_control.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.m_element_Staff,
            this.m_element_student,
            this.m_element_schedule,
            this.m_element_users,
            this.m_element_depart});
            this.frm_main_acc_control.Location = new System.Drawing.Point(0, 24);
            this.frm_main_acc_control.Name = "frm_main_acc_control";
            this.frm_main_acc_control.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.frm_main_acc_control.Size = new System.Drawing.Size(201, 462);
            this.frm_main_acc_control.TabIndex = 1;
            this.frm_main_acc_control.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // m_element_Staff
            // 
            this.m_element_Staff.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_addstaff,
            this.s_element_srchstaff,
            this.s_element_rmstaff});
            this.m_element_Staff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_Staff.ImageOptions.SvgImage")));
            this.m_element_Staff.Name = "m_element_Staff";
            this.m_element_Staff.Text = "Staff";
            // 
            // s_element_addstaff
            // 
            this.s_element_addstaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_addstaff.ImageOptions.SvgImage")));
            this.s_element_addstaff.Name = "s_element_addstaff";
            this.s_element_addstaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_addstaff.Text = "Add Staff";
            this.s_element_addstaff.Click += new System.EventHandler(this.s_element_addtcher_Click);
            // 
            // s_element_srchstaff
            // 
            this.s_element_srchstaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_srchstaff.ImageOptions.SvgImage")));
            this.s_element_srchstaff.Name = "s_element_srchstaff";
            this.s_element_srchstaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_srchstaff.Text = "Search Staff";
            // 
            // s_element_rmstaff
            // 
            this.s_element_rmstaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_rmstaff.ImageOptions.SvgImage")));
            this.s_element_rmstaff.Name = "s_element_rmstaff";
            this.s_element_rmstaff.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_rmstaff.Text = "Remove Staff";
            // 
            // m_element_student
            // 
            this.m_element_student.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_addstdnt,
            this.s_element_srchstdnt,
            this.s_element_rmstdnt});
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
            this.s_element_srchstdnt.Text = "Search  Student";
            // 
            // s_element_rmstdnt
            // 
            this.s_element_rmstdnt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_rmstdnt.ImageOptions.SvgImage")));
            this.s_element_rmstdnt.Name = "s_element_rmstdnt";
            this.s_element_rmstdnt.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_rmstdnt.Text = "Remove Student";
            this.s_element_rmstdnt.Click += new System.EventHandler(this.s_element_rmstdnt_Click_1);
            // 
            // m_element_schedule
            // 
            this.m_element_schedule.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_addsched,
            this.s_element_remsched,
            this.s_element_checksched,
            this.s_element_room});
            this.m_element_schedule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("m_element_schedule.ImageOptions.SvgImage")));
            this.m_element_schedule.Name = "m_element_schedule";
            this.m_element_schedule.Text = "Schedule";
            // 
            // s_element_addsched
            // 
            this.s_element_addsched.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_addsched.ImageOptions.SvgImage")));
            this.s_element_addsched.Name = "s_element_addsched";
            this.s_element_addsched.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_addsched.Text = "Add Schedule";
            this.s_element_addsched.Click += new System.EventHandler(this.s_element_addsched_Click);
            // 
            // s_element_remsched
            // 
            this.s_element_remsched.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_remsched.ImageOptions.SvgImage")));
            this.s_element_remsched.Name = "s_element_remsched";
            this.s_element_remsched.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_remsched.Text = "Remove Schedule";
            // 
            // s_element_checksched
            // 
            this.s_element_checksched.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_checksched.ImageOptions.SvgImage")));
            this.s_element_checksched.Name = "s_element_checksched";
            this.s_element_checksched.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_checksched.Text = "Check Schedule";
            this.s_element_checksched.Click += new System.EventHandler(this.s_element_checksched_Click);
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
            this.m_element_users.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_add_user,
            this.s_element_rm_users});
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
            this.m_element_depart.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.s_element_subjects,
            this.s_element_departments});
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
            // 
            // s_element_departments
            // 
            this.s_element_departments.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("s_element_departments.ImageOptions.SvgImage")));
            this.s_element_departments.Name = "s_element_departments";
            this.s_element_departments.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.s_element_departments.Text = "Departments";
            this.s_element_departments.Click += new System.EventHandler(this.s_element_departments_Click);
            // 
            // fluentDesignFormControl1
            // 
            this.fluentDesignFormControl1.FluentDesignForm = this;
            this.fluentDesignFormControl1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormControl1.Manager = this.fluentFormDefaultManager1;
            this.fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            this.fluentDesignFormControl1.Size = new System.Drawing.Size(917, 24);
            this.fluentDesignFormControl1.TabIndex = 2;
            this.fluentDesignFormControl1.TabStop = false;
            // 
            // fluentFormDefaultManager1
            // 
            this.fluentFormDefaultManager1.Form = this;
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 486);
            this.ControlContainer = this.frm_main_container;
            this.Controls.Add(this.frm_main_container);
            this.Controls.Add(this.frm_main_acc_control);
            this.Controls.Add(this.fluentDesignFormControl1);
            this.FluentDesignFormControl = this.fluentDesignFormControl1;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("FrmMain.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.NavigationControl = this.frm_main_acc_control;
            this.Text = "BENEDICTO SIS";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frm_main_acc_control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer frm_main_container;
        private DevExpress.XtraBars.Navigation.AccordionControl frm_main_acc_control;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_student;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_schedule;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_addsched;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_addstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_srchstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rmstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_remsched;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_Staff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_addstaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_srchstaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rmstaff;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_add_user;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rm_users;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_checksched;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_room;
        private DevExpress.XtraBars.Navigation.AccordionControlElement m_element_depart;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_subjects;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_departments;
    }
}