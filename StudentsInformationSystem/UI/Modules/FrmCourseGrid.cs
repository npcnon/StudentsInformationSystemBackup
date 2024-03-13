using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmCourseGrid : DevExpress.XtraEditors.DirectXForm
    {
        public static string id;
        public static string department_id;
        public static string course;
        // Define a custom event
        public static event EventHandler selectedr;
        public FrmCourseGrid()
        {
            InitializeComponent();
       

        }
     
        protected virtual void selectedrow(EventArgs e)
        {
            selectedr?.Invoke(this, e);
        }

        private async void FrmCourseGrid_Load(object sender, EventArgs e)
        {
        
            gview_course.OptionsBehavior.ReadOnly = true;
            StartPosition = FormStartPosition.CenterScreen;
            await functions.LoadData<Course>(UcCourses.endpoint, grid_course);
        }

        private void gview_course_DoubleClick(object sender, EventArgs e)
        {
            GridView view = (GridView)sender;
            GridHitInfo hitInfo = view.CalcHitInfo(view.GridControl.PointToClient(Control.MousePosition));

            if (hitInfo.InRow)
            {
                id = view.GetRowCellValue(hitInfo.RowHandle, "id").ToString();
                department_id = view.GetRowCellValue(hitInfo.RowHandle, "department_Id").ToString();
                course = view.GetRowCellValue(hitInfo.RowHandle, "course").ToString();
                selectedrow(EventArgs.Empty);
                Close();
            }
        }
    }
}