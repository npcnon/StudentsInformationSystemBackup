

// UcCourses class
using DevExpress.XtraEditors;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcCourses : DevExpress.DXperience.Demos.TutorialControlBase
    {
        internal const string endpoint = "api/course/";
        private HttpClient client;
        internal Course course = new Course();

        public UcCourses()
        {
            InitializeComponent();
            client = new HttpClient();

            // Subscribe to the SaveButtonClicked event of UcDepartment directly
            //UcDepartment.SaveButtonClicked += DepartmentForm_SaveButtonClicked;
        }

        private async void UcCourses_Load(object sender, EventArgs e)
        {
            
            await functions.LoadData<Department>(UcDepartment.endpoint, null, cbox_department, d => d.department, "TblDepartment.id");
        }

        

        internal async void cbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected an Item");
            course.department_Id = await functions.GetDepartmentId(cbox_department.Text, UcDepartment.endpoint);
        }

        private async void btn_addcourse_Click(object sender, EventArgs e)
        {
            try
            {
                course.course = txt_addcourse.Text;
                await functions.InsertData(course, endpoint);
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

        private void cbox_department_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }



        // Method to handle the SaveButtonClicked event from UcDepartment
        //private async void DepartmentForm_SaveButtonClicked(object sender, EventArgs e)
        //{
        //    // Add your code here to handle the event
        //    Debug.WriteLine("Save button clicked in UcDepartment form");
        //    // You can perform any necessary actions here when the event is triggered

        //    //await functions.LoadData<Department>(UcDepartment.endpoint, null, cbox_department, d => d.department, "TblDepartment.id");
        //}
    }

    internal class Course
    {
        private string _course;
        private int? _department_id;

        public string course
        {
            get => _course;
            set => _course = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Course cannot be null");
        }

        public int? department_Id
        {
            get => _department_id;
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Error: Department ID cannot be null");
                }
                _department_id = value;
            }
        }
    }
}
