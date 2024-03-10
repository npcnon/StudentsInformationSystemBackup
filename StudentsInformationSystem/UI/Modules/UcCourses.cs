using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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


        public UcCourses()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        private async void UcCourses_Load(object sender, EventArgs e)
        {
            await functions.LoadData<Course>(endpoint, gcont_course);
            await functions.LoadData<Department>(UcDepartment.endpoint, null,cbox_department, d => d.department);
        }

        private async void btn_addcourse_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    // Get the selected department ID from the ComboBox
            //    string selectedDepartmentId = ((Department)cbox_department.SelectedItem)?.department_id;

            //    if (string.IsNullOrEmpty(selectedDepartmentId))
            //    {
            //        MessageBox.Show("Please select a department.");
            //        return;
            //    }

            //    // Create a new course object
            //    var course = new Course
            //    {
            //        course = txt_addcourse.Text,
            //        department_id = selectedDepartmentId
            //    };

            //    // Insert the course into the database
            //    await functions.InsertData<Course>(course, endpoint, gcont_course);

            //    // Refresh the courses grid after insertion
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }
    }

    internal class Course
    {
        private string _course;
        private string _department_id;



        public string course
        {
            get => _course;
            set => _course = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }

        public string department_id
        {
            get => _department_id;
            set => _department_id = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }
    }

}

