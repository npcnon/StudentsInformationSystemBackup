namespace StudentsInformationSystem.UI.Modules
{
    partial class FrmAddRoom
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_clear = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete_floor = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save_floor = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete_building = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save_building = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.cbox_building = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_room = new DevExpress.XtraEditors.TextEdit();
            this.cbox_floor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_building.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_room.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_floor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.labelControl4);
            this.directXFormContainerControl1.Controls.Add(this.labelControl3);
            this.directXFormContainerControl1.Controls.Add(this.labelControl2);
            this.directXFormContainerControl1.Controls.Add(this.labelControl1);
            this.directXFormContainerControl1.Controls.Add(this.btn_cancel);
            this.directXFormContainerControl1.Controls.Add(this.btn_clear);
            this.directXFormContainerControl1.Controls.Add(this.btn_delete_floor);
            this.directXFormContainerControl1.Controls.Add(this.btn_save_floor);
            this.directXFormContainerControl1.Controls.Add(this.btn_delete_building);
            this.directXFormContainerControl1.Controls.Add(this.btn_save_building);
            this.directXFormContainerControl1.Controls.Add(this.btn_add);
            this.directXFormContainerControl1.Controls.Add(this.cbox_building);
            this.directXFormContainerControl1.Controls.Add(this.txt_room);
            this.directXFormContainerControl1.Controls.Add(this.cbox_floor);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(600, 374);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(87, 215);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(91, 17);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "Enter Room # :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(87, 141);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(108, 17);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Enter Floor Level :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(87, 67);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(132, 17);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Enter Building Name :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(36, 13);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(117, 32);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Add Room";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Appearance.Options.UseFont = true;
            this.btn_cancel.Location = new System.Drawing.Point(87, 304);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(107, 37);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Appearance.Options.UseFont = true;
            this.btn_clear.Location = new System.Drawing.Point(237, 304);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(107, 37);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_delete_floor
            // 
            this.btn_delete_floor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_floor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_floor.Appearance.Options.UseFont = true;
            this.btn_delete_floor.Location = new System.Drawing.Point(259, 202);
            this.btn_delete_floor.Name = "btn_delete_floor";
            this.btn_delete_floor.Size = new System.Drawing.Size(107, 30);
            this.btn_delete_floor.TabIndex = 12;
            this.btn_delete_floor.Text = "Delete Floor";
            this.btn_delete_floor.Click += new System.EventHandler(this.btn_delete_floor_Click);
            // 
            // btn_save_floor
            // 
            this.btn_save_floor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_floor.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_floor.Appearance.Options.UseFont = true;
            this.btn_save_floor.Location = new System.Drawing.Point(385, 202);
            this.btn_save_floor.Name = "btn_save_floor";
            this.btn_save_floor.Size = new System.Drawing.Size(107, 30);
            this.btn_save_floor.TabIndex = 12;
            this.btn_save_floor.Text = "Save Floor";
            this.btn_save_floor.Click += new System.EventHandler(this.btn_save_floor_Click);
            // 
            // btn_delete_building
            // 
            this.btn_delete_building.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete_building.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_building.Appearance.Options.UseFont = true;
            this.btn_delete_building.Location = new System.Drawing.Point(259, 128);
            this.btn_delete_building.Name = "btn_delete_building";
            this.btn_delete_building.Size = new System.Drawing.Size(107, 30);
            this.btn_delete_building.TabIndex = 12;
            this.btn_delete_building.Text = "Delete Building";
            this.btn_delete_building.Click += new System.EventHandler(this.btn_delete_building_Click);
            // 
            // btn_save_building
            // 
            this.btn_save_building.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save_building.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_building.Appearance.Options.UseFont = true;
            this.btn_save_building.Location = new System.Drawing.Point(385, 128);
            this.btn_save_building.Name = "btn_save_building";
            this.btn_save_building.Size = new System.Drawing.Size(107, 30);
            this.btn_save_building.TabIndex = 12;
            this.btn_save_building.Text = "Save Building";
            this.btn_save_building.Click += new System.EventHandler(this.btn_save_building_Click);
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.Location = new System.Drawing.Point(385, 304);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(107, 37);
            this.btn_add.TabIndex = 12;
            this.btn_add.Text = "Add";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cbox_building
            // 
            this.cbox_building.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_building.Location = new System.Drawing.Point(87, 90);
            this.cbox_building.Name = "cbox_building";
            this.cbox_building.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_building.Properties.Appearance.Options.UseFont = true;
            this.cbox_building.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_building.Size = new System.Drawing.Size(405, 32);
            this.cbox_building.TabIndex = 13;
            // 
            // txt_room
            // 
            this.txt_room.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_room.Location = new System.Drawing.Point(87, 238);
            this.txt_room.Name = "txt_room";
            this.txt_room.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_room.Properties.Appearance.Options.UseFont = true;
            this.txt_room.Size = new System.Drawing.Size(405, 32);
            this.txt_room.TabIndex = 14;
            // 
            // cbox_floor
            // 
            this.cbox_floor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbox_floor.Location = new System.Drawing.Point(87, 164);
            this.cbox_floor.Name = "cbox_floor";
            this.cbox_floor.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_floor.Properties.Appearance.Options.UseFont = true;
            this.cbox_floor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_floor.Size = new System.Drawing.Size(405, 32);
            this.cbox_floor.TabIndex = 14;
            // 
            // FrmAddRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(600, 374);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddRoom";
            this.Load += new System.EventHandler(this.FrmAddRoom_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            this.directXFormContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_building.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_room.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_floor.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_cancel;
        private DevExpress.XtraEditors.SimpleButton btn_clear;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_building;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btn_save_floor;
        private DevExpress.XtraEditors.SimpleButton btn_save_building;
        private DevExpress.XtraEditors.TextEdit txt_room;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_floor;
        private DevExpress.XtraEditors.SimpleButton btn_delete_floor;
        private DevExpress.XtraEditors.SimpleButton btn_delete_building;
    }
}