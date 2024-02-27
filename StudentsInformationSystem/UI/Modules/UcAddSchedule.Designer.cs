namespace StudentsInformationSystem.UI.Modules
{
    partial class UcAddSchedule
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
            this.gcont_schedule = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_class_day = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_hr_end = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_hr_start = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.cbox_room_details = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_teacher = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_subject = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_submit = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcont_schedule)).BeginInit();
            this.gcont_schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_class_day.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_hr_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_hr_start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_room_details.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_teacher.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_subject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // gcont_schedule
            // 
            this.gcont_schedule.Controls.Add(this.layoutControl1);
            this.gcont_schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcont_schedule.Location = new System.Drawing.Point(0, 0);
            this.gcont_schedule.Name = "gcont_schedule";
            this.gcont_schedule.Size = new System.Drawing.Size(613, 387);
            this.gcont_schedule.TabIndex = 1;
            this.gcont_schedule.Text = "Add Schedule";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btn_submit);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.cbox_class_day);
            this.layoutControl1.Controls.Add(this.cbox_hr_end);
            this.layoutControl1.Controls.Add(this.cbox_hr_start);
            this.layoutControl1.Controls.Add(this.cbox_room_details);
            this.layoutControl1.Controls.Add(this.cbox_teacher);
            this.layoutControl1.Controls.Add(this.cbox_subject);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 22);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(609, 363);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Class hour :";
            // 
            // cbox_class_day
            // 
            this.cbox_class_day.Location = new System.Drawing.Point(102, 45);
            this.cbox_class_day.Name = "cbox_class_day";
            this.cbox_class_day.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_class_day.Properties.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday"});
            this.cbox_class_day.Size = new System.Drawing.Size(482, 20);
            this.cbox_class_day.StyleController = this.layoutControl1;
            this.cbox_class_day.TabIndex = 4;
            // 
            // cbox_hr_end
            // 
            this.cbox_hr_end.Location = new System.Drawing.Point(430, 69);
            this.cbox_hr_end.Name = "cbox_hr_end";
            this.cbox_hr_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_hr_end.Properties.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30"});
            this.cbox_hr_end.Size = new System.Drawing.Size(154, 20);
            this.cbox_hr_end.StyleController = this.layoutControl1;
            this.cbox_hr_end.TabIndex = 7;
            // 
            // cbox_hr_start
            // 
            this.cbox_hr_start.EditValue = "";
            this.cbox_hr_start.Location = new System.Drawing.Point(176, 69);
            this.cbox_hr_start.Name = "cbox_hr_start";
            this.cbox_hr_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_hr_start.Properties.Items.AddRange(new object[] {
            "07:00",
            "07:30",
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00",
            "18:30"});
            this.cbox_hr_start.Size = new System.Drawing.Size(163, 20);
            this.cbox_hr_start.StyleController = this.layoutControl1;
            this.cbox_hr_start.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(609, 363);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(589, 343);
            this.layoutControlGroup1.Text = "SCHEDULE ";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbox_class_day;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(563, 24);
            this.layoutControlItem1.Text = "Class day : ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbox_hr_start;
            this.layoutControlItem2.Location = new System.Drawing.Point(74, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(244, 24);
            this.layoutControlItem2.Text = "Start -";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbox_room_details;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(563, 24);
            this.layoutControlItem3.Text = "Class room ID:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cbox_teacher;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(563, 24);
            this.layoutControlItem4.Text = "Teacher :";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cbox_subject;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(563, 24);
            this.layoutControlItem5.Text = "Subject :";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.labelControl1;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(64, 24);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(64, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 146);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(563, 151);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbox_hr_end;
            this.layoutControlItem7.Location = new System.Drawing.Point(328, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(235, 24);
            this.layoutControlItem7.Text = "End -";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(73, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(318, 24);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // cbox_room_details
            // 
            this.cbox_room_details.EditValue = "";
            this.cbox_room_details.Location = new System.Drawing.Point(102, 93);
            this.cbox_room_details.Name = "cbox_room_details";
            this.cbox_room_details.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_room_details.Size = new System.Drawing.Size(482, 20);
            this.cbox_room_details.StyleController = this.layoutControl1;
            this.cbox_room_details.TabIndex = 5;
            // 
            // cbox_teacher
            // 
            this.cbox_teacher.EditValue = "";
            this.cbox_teacher.Location = new System.Drawing.Point(102, 117);
            this.cbox_teacher.Name = "cbox_teacher";
            this.cbox_teacher.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_teacher.Size = new System.Drawing.Size(482, 20);
            this.cbox_teacher.StyleController = this.layoutControl1;
            this.cbox_teacher.TabIndex = 5;
            // 
            // cbox_subject
            // 
            this.cbox_subject.EditValue = "";
            this.cbox_subject.Location = new System.Drawing.Point(102, 141);
            this.cbox_subject.Name = "cbox_subject";
            this.cbox_subject.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_subject.Size = new System.Drawing.Size(482, 20);
            this.cbox_subject.StyleController = this.layoutControl1;
            this.cbox_subject.TabIndex = 5;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(25, 165);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(559, 22);
            this.btn_submit.StyleController = this.layoutControl1;
            this.btn_submit.TabIndex = 8;
            this.btn_submit.Text = "SUBMIT";
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btn_submit;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(563, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // UcAddSchedule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcont_schedule);
            this.Name = "UcAddSchedule";
            this.Size = new System.Drawing.Size(613, 387);
            this.Load += new System.EventHandler(this.UcAddSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcont_schedule)).EndInit();
            this.gcont_schedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbox_class_day.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_hr_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_hr_start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_room_details.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_teacher.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_subject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcont_schedule;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_class_day;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_hr_end;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_hr_start;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_room_details;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_teacher;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_subject;
        private DevExpress.XtraEditors.SimpleButton btn_submit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}
