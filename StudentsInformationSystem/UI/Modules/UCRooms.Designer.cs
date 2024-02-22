namespace StudentsInformationSystem.UI.Modules
{
    partial class UCRooms
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
            this.components = new System.ComponentModel.Container();
            this.tblRoomInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sisDataSet1 = new StudentsInformationSystem.sisDataSet1();
            this.tblRoomInfoTableAdapter = new StudentsInformationSystem.sisDataSet1TableAdapters.TblRoomInfoTableAdapter();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cbox_building = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_add_room = new DevExpress.XtraEditors.SimpleButton();
            this.cbox_floorlvl = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbox_roomno = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colroom_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbuilding = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfloor_lvl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colroom_no = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_building.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_floorlvl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_roomno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            this.tabNavigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblRoomInfoBindingSource
            // 
            this.tblRoomInfoBindingSource.DataMember = "TblRoomInfo";
            this.tblRoomInfoBindingSource.DataSource = this.sisDataSet1;
            // 
            // sisDataSet1
            // 
            this.sisDataSet1.DataSetName = "sisDataSet1";
            this.sisDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblRoomInfoTableAdapter
            // 
            this.tblRoomInfoTableAdapter.ClearBeforeFill = true;
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
            this.tabPane1.RegularSize = new System.Drawing.Size(581, 359);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(581, 359);
            this.tabPane1.TabIndex = 1;
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "ADD ROOM";
            this.tabNavigationPage1.Controls.Add(this.layoutControl1);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(581, 338);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbox_building);
            this.layoutControl1.Controls.Add(this.btn_add_room);
            this.layoutControl1.Controls.Add(this.cbox_floorlvl);
            this.layoutControl1.Controls.Add(this.cbox_roomno);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(581, 338);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cbox_building
            // 
            this.cbox_building.Location = new System.Drawing.Point(132, 125);
            this.cbox_building.Name = "cbox_building";
            this.cbox_building.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_building.Properties.Items.AddRange(new object[] {
            "Builing 1",
            "Builing 2",
            "Builing 3",
            "Builing 4"});
            this.cbox_building.Size = new System.Drawing.Size(354, 20);
            this.cbox_building.StyleController = this.layoutControl1;
            this.cbox_building.TabIndex = 4;
            // 
            // btn_add_room
            // 
            this.btn_add_room.Location = new System.Drawing.Point(327, 197);
            this.btn_add_room.Name = "btn_add_room";
            this.btn_add_room.Size = new System.Drawing.Size(159, 22);
            this.btn_add_room.StyleController = this.layoutControl1;
            this.btn_add_room.TabIndex = 6;
            this.btn_add_room.Text = "Add Room";
            // 
            // cbox_floorlvl
            // 
            this.cbox_floorlvl.Location = new System.Drawing.Point(132, 149);
            this.cbox_floorlvl.Name = "cbox_floorlvl";
            this.cbox_floorlvl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_floorlvl.Properties.Items.AddRange(new object[] {
            "floor 1",
            "floor 2",
            "floor 3",
            "floor 4",
            "floor 5",
            "floot 6"});
            this.cbox_floorlvl.Size = new System.Drawing.Size(354, 20);
            this.cbox_floorlvl.StyleController = this.layoutControl1;
            this.cbox_floorlvl.TabIndex = 5;
            // 
            // cbox_roomno
            // 
            this.cbox_roomno.Location = new System.Drawing.Point(132, 173);
            this.cbox_roomno.Name = "cbox_roomno";
            this.cbox_roomno.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_roomno.Properties.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbox_roomno.Size = new System.Drawing.Size(354, 20);
            this.cbox_roomno.StyleController = this.layoutControl1;
            this.cbox_roomno.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.emptySpaceItem3,
            this.layoutControlItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(581, 338);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cbox_building;
            this.layoutControlItem1.Location = new System.Drawing.Point(55, 113);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem1.Text = "Building :";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbox_floorlvl;
            this.layoutControlItem2.Location = new System.Drawing.Point(55, 137);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem2.Text = "Floor Level :";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(61, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.cbox_roomno;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem3.Location = new System.Drawing.Point(55, 161);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(423, 24);
            this.layoutControlItem3.Text = "room :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(61, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(55, 318);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(478, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(83, 318);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(55, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(423, 113);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_add_room;
            this.layoutControlItem4.Location = new System.Drawing.Point(315, 185);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(163, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(55, 185);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(260, 26);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(55, 211);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(423, 107);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "REMOVE ROOM";
            this.tabNavigationPage2.Controls.Add(this.gridControl1);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(581, 338);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tblRoomInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(581, 338);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colroom_id,
            this.colbuilding,
            this.colfloor_lvl,
            this.colroom_no});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colroom_id
            // 
            this.colroom_id.FieldName = "room_id";
            this.colroom_id.Name = "colroom_id";
            this.colroom_id.Visible = true;
            this.colroom_id.VisibleIndex = 0;
            // 
            // colbuilding
            // 
            this.colbuilding.FieldName = "building";
            this.colbuilding.Name = "colbuilding";
            this.colbuilding.Visible = true;
            this.colbuilding.VisibleIndex = 1;
            // 
            // colfloor_lvl
            // 
            this.colfloor_lvl.FieldName = "floor_lvl";
            this.colfloor_lvl.Name = "colfloor_lvl";
            this.colfloor_lvl.Visible = true;
            this.colfloor_lvl.VisibleIndex = 2;
            // 
            // colroom_no
            // 
            this.colroom_no.FieldName = "room_no";
            this.colroom_no.Name = "colroom_no";
            this.colroom_no.Visible = true;
            this.colroom_no.VisibleIndex = 3;
            // 
            // UCRooms
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane1);
            this.Name = "UCRooms";
            this.Size = new System.Drawing.Size(581, 359);
            this.Load += new System.EventHandler(this.UCRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblRoomInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sisDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbox_building.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_floorlvl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_roomno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            this.tabNavigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblRoomInfoBindingSource;
        private sisDataSet1 sisDataSet1;
        private sisDataSet1TableAdapters.TblRoomInfoTableAdapter tblRoomInfoTableAdapter;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_building;
        private DevExpress.XtraEditors.SimpleButton btn_add_room;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_floorlvl;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_roomno;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colroom_id;
        private DevExpress.XtraGrid.Columns.GridColumn colbuilding;
        private DevExpress.XtraGrid.Columns.GridColumn colfloor_lvl;
        private DevExpress.XtraGrid.Columns.GridColumn colroom_no;
    }
}
