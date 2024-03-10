using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

            
        }

        private async void UcCourses_Load(object sender, EventArgs e)
        {
            await functions.LoadData<Course>(endpoint, gcont_course);
            await functions.LoadData<Department>(UcDepartment.endpoint, null,cbox_department, d => d.department,"TblDepartment.id");
        }

        private async void btn_addcourse_Click(object sender, EventArgs e)
        {
            try
            {
                course.course = txt_addcourse.Text;
                await functions.InsertData(course, endpoint, gcont_course);

            }
            catch (ArgumentException ex_argument)
            {
               
                MessageBox.Show(ex_argument.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Catched");
                MessageBox.Show(ex.Message);
            }
        }

        internal async void cbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Selected an Item");
            
            course.department_Id = await functions.GetDepartmentId(cbox_department.Text, UcDepartment.endpoint);
        }
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

