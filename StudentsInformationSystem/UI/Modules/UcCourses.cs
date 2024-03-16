

// UcCourses class
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcCourses : DevExpress.DXperience.Demos.TutorialControlBase
    {
        internal const string endpoint = "api/course/";
        internal const string endpoint_deactivate = "api/deactivate_course";


        internal Course course = new Course();
        private static ComboBoxEdit cbox;
        public UcCourses()
        {
            InitializeComponent();
           
            UcDepartment.SaveButtonClicked += UcDepartment_SaveButtonClicked;
            FrmCourseGrid.selectedr += FrmCourseGrid_selectedrow;

        }
        private void FrmCourseGrid_selectedrow(object sender, EventArgs e)
        {
            lbl_course.Text = FrmCourseGrid.course;
            lbl_course_dep.Text = FrmCourseGrid.department_id;
            lbl_course_id.Text = FrmCourseGrid.id;

      
        }

        private async void UcDepartment_SaveButtonClicked(object sender, EventArgs e)
        {
            await LoadData();
            Debug.WriteLine("The save button in UcDepartment was clicked");
        }
        private async void UcCourses_Load(object sender, EventArgs e)
        {
            cbox = cbox_department;
            await LoadData();
        }

        public async Task LoadData()
        {
            Debug.WriteLine("LoadData is running");
            await functions.LoadData<Department>(UcDepartment.endpoint, null, cbox, d => d.department);
        }


        private async void btn_addcourse_Click(object sender, EventArgs e)
        {
            try
            {
                
                course.course = txt_addcourse.Text;
                await functions.InsertData(course, endpoint);
                txt_addcourse.Text = "";
            }
            catch (ArgumentException ex_argument)
            {
                MessageBox.Show(ex_argument.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Caught");
                MessageBox.Show(ex.Message);
            }
        }

     
       



        private async void cbox_department_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected an Item");
            //course.department_Id = await functions.GetDepartmentId(cbox_department.Text, UcDepartment.endpoint);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            FrmCourseGrid courseGrid = new FrmCourseGrid();
            
            courseGrid.Show();
          
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            //await functions.ModifyActiveField(endpoint_deactivate,Convert.ToInt32(lbl_course_id.Text));
        }
    }

    
}
