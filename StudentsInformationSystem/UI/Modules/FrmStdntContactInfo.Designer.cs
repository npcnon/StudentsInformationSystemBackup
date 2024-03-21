namespace StudentsInformationSystem.UI.Modules
{
    partial class FrmStdntContactInfo
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
            this.directXFormContainerControl1 = new DevExpress.XtraEditors.DirectXFormContainerControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_student = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_address = new DevExpress.XtraEditors.TextEdit();
            this.txt_contact = new DevExpress.XtraEditors.TextEdit();
            this.txt_email = new DevExpress.XtraEditors.TextEdit();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_student.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.simpleButton2);
            this.directXFormContainerControl1.Controls.Add(this.btn_save);
            this.directXFormContainerControl1.Controls.Add(this.btn_cancel);
            this.directXFormContainerControl1.Controls.Add(this.labelControl5);
            this.directXFormContainerControl1.Controls.Add(this.labelControl4);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.cbox_student);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.txt_address);
            this.directXFormContainerControl1.Controls.Add(this.txt_contact);
            this.directXFormContainerControl1.Controls.Add(this.txt_email);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(404, 468);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(155, 397);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(79, 41);
            this.simpleButton2.TabIndex = 111;
            this.simpleButton2.Text = "Clear";
            // 
            // btn_save
            // 
            this.btn_save.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Location = new System.Drawing.Point(240, 397);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(79, 41);
            this.btn_save.TabIndex = 110;
            this.btn_save.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Location = new System.Drawing.Point(70, 397);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 41);
            this.btn_cancel.TabIndex = 109;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(80, 310);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 21);
            this.labelControl5.TabIndex = 103;
            this.labelControl5.Text = "Email :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(80, 239);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 21);
            this.labelControl4.TabIndex = 103;
            this.labelControl4.Text = "Contact # :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(320, 40);
            this.labelControl1.TabIndex = 102;
            this.labelControl1.Text = "Student Contact Details";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(80, 164);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 21);
            this.labelControl3.TabIndex = 104;
            this.labelControl3.Text = "Address :";
            // 
            // cbox_student
            // 
            this.cbox_student.EditValue = "--Select Student--";
            this.cbox_student.Location = new System.Drawing.Point(80, 121);
            this.cbox_student.Name = "cbox_student";
            this.cbox_student.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_student.Properties.Appearance.Options.UseFont = true;
            this.cbox_student.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_student.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbox_student.Size = new System.Drawing.Size(228, 36);
            this.cbox_student.TabIndex = 101;
            this.cbox_student.SelectedIndexChanged += new System.EventHandler(this.cbox_student_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(80, 94);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 21);
            this.labelControl2.TabIndex = 105;
            this.labelControl2.Text = "Student :";
            // 
            // txt_address
            // 
            this.txt_address.EditValue = "";
            this.txt_address.Location = new System.Drawing.Point(80, 191);
            this.txt_address.Name = "txt_address";
            this.txt_address.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.Properties.Appearance.Options.UseFont = true;
            this.txt_address.Size = new System.Drawing.Size(228, 36);
            this.txt_address.TabIndex = 99;
            // 
            // txt_contact
            // 
            this.txt_contact.EditValue = "";
            this.txt_contact.Location = new System.Drawing.Point(80, 266);
            this.txt_contact.Name = "txt_contact";
            this.txt_contact.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contact.Properties.Appearance.Options.UseFont = true;
            this.txt_contact.Size = new System.Drawing.Size(228, 36);
            this.txt_contact.TabIndex = 100;
            // 
            // txt_email
            // 
            this.txt_email.EditValue = "";
            this.txt_email.Location = new System.Drawing.Point(80, 337);
            this.txt_email.Name = "txt_email";
            this.txt_email.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Properties.Appearance.Options.UseFont = true;
            this.txt_email.Size = new System.Drawing.Size(228, 36);
            this.txt_email.TabIndex = 100;
            // 
            // FrmStdntContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(404, 468);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStdntContactInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStdntContactInfo";
            this.Load += new System.EventHandler(this.FrmStdntContactInfo_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_student.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_contact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_email.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_student;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_address;
        private DevExpress.XtraEditors.TextEdit txt_contact;
        private DevExpress.XtraEditors.TextEdit txt_email;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
    }
}