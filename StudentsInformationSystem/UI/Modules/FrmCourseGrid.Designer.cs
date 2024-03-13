namespace StudentsInformationSystem.UI.Modules
{
    partial class FrmCourseGrid
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
            this.grid_course = new DevExpress.XtraGrid.GridControl();
            this.gview_course = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.directXFormContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_course)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gview_course)).BeginInit();
            this.SuspendLayout();
            // 
            // directXFormContainerControl1
            // 
            this.directXFormContainerControl1.Controls.Add(this.grid_course);
            this.directXFormContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.directXFormContainerControl1.Name = "directXFormContainerControl1";
            this.directXFormContainerControl1.Size = new System.Drawing.Size(632, 374);
            this.directXFormContainerControl1.TabIndex = 0;
            // 
            // grid_course
            // 
            this.grid_course.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_course.Location = new System.Drawing.Point(0, 0);
            this.grid_course.MainView = this.gview_course;
            this.grid_course.Name = "grid_course";
            this.grid_course.Size = new System.Drawing.Size(632, 374);
            this.grid_course.TabIndex = 0;
            this.grid_course.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gview_course});
            // 
            // gview_course
            // 
            this.gview_course.GridControl = this.grid_course;
            this.gview_course.Name = "gview_course";
            this.gview_course.DoubleClick += new System.EventHandler(this.gview_course_DoubleClick);
            // 
            // FrmCourseGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ChildControls.Add(this.directXFormContainerControl1);
            this.ClientSize = new System.Drawing.Size(632, 374);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCourseGrid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCourseGrid";
            this.Load += new System.EventHandler(this.FrmCourseGrid_Load);
            this.directXFormContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_course)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gview_course)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DirectXFormContainerControl directXFormContainerControl1;
        private DevExpress.XtraGrid.GridControl grid_course;
        private DevExpress.XtraGrid.Views.Grid.GridView gview_course;
    }
}