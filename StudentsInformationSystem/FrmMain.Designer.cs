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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.frm_main_container = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            this.frm_main_acc_control = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.m_element_student = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_addstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_srchstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.s_element_rmstdnt = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            this.fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(this.components);
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.frm_main_acc_control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentDesignFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fluentFormDefaultManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // frm_main_container
            // 
            this.frm_main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frm_main_container.Location = new System.Drawing.Point(260, 24);
            this.frm_main_container.Name = "frm_main_container";
            this.frm_main_container.Size = new System.Drawing.Size(657, 462);
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
            this.m_element_student,
            this.accordionControlElement7});
            this.frm_main_acc_control.Location = new System.Drawing.Point(0, 24);
            this.frm_main_acc_control.Name = "frm_main_acc_control";
            this.frm_main_acc_control.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            this.frm_main_acc_control.Size = new System.Drawing.Size(260, 462);
            this.frm_main_acc_control.TabIndex = 1;
            this.frm_main_acc_control.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
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
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8});
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Schedule";
            // 
            // accordionControlElement8
            // 
            this.accordionControlElement8.Name = "accordionControlElement8";
            this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement8.Text = "Add Schedule";
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
            this.Name = "FrmMain";
            this.NavigationControl = this.frm_main_acc_control;
            this.Text = "FrmMain";
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
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_addstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_srchstdnt;
        private DevExpress.XtraBars.Navigation.AccordionControlElement s_element_rmstdnt;
    }
}