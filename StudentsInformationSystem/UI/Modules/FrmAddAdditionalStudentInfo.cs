using DevExpress.XtraEditors;
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

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmAddAdditionalStudentInfo : DevExpress.XtraEditors.DirectXForm
    {
        public static string endpoint = "api/stdntschooldetails/";
        StudentSchoolDetails student_school = new StudentSchoolDetails();
        List<string> course_list = new List<string>();
        public FrmAddAdditionalStudentInfo()
        {
            InitializeComponent();
        }



        private async void cbox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int? student_id = await functions.GetEntityId(null, cbox_student.Text, "id", FrmAddStudent.endpoint, true);
                if(student_id.HasValue)
                {
                    student_school.stdnt_id = student_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }


        private async void FrmAddAdditionalStudentInfo_Load(object sender, EventArgs e)
        {

            cbox_student.Properties.Items.Clear();
            await functions.LoadData<Student>(FrmAddStudent.endpoint, null, cbox_student, d => $"{d.f_name} {d.m_name} {d.l_name}");
            cbox_course.Enabled = false;

            cbox_department.Properties.Items.Clear();
            await functions.LoadData<Department>(FrmAddDepartment.endpoint, null, cbox_department, d => d.department);


        }

        private async void cbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int? department_id = await functions.GetEntityId("department", cbox_department.Text, "id", FrmAddDepartment.endpoint);
                if (department_id != null)
                {
                    student_school.department = department_id;
                }

                cbox_course.Properties.Items.Clear();
                cbox_course.SelectedIndex = -1;
                course_list.Clear();
                //get the id of the course filter the course id with the staff department it
                List<int?> course_id = await functions.GetMultipleEntityIds("department_Id", department_id.ToString(), "id", FrmAddCourse.endpoint);
                if (department_id.HasValue && course_id.Count > 0)
                {
                    Debug.WriteLine($"if is triggered - department_id : {department_id} course_id : {course_id}");
                    foreach (int? id in course_id)
                    {
                        // Construct the filter criteria based on the selected staff's department ID
                        string filterCriteria = $"id={id}";

                        // Load subjects based on the selected staff's department

                        await functions.LoadData<Course>(FrmAddCourse.endpoint, null, cbox_course, d => d.course, filterCriteria);
                        course_list.AddRange(cbox_course.Properties.Items.Cast<string>());
                    }
                    cbox_course.Properties.Items.Clear();
                    cbox_course.Properties.Items.AddRange(course_list);
                    cbox_course.Enabled = true;
                }
                else
                {
                    Debug.WriteLine($"else is triggered - department_id : {department_id} course_id : {course_id}");
                    MessageBox.Show("Unable Load Subjects");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private async void cbox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? course_id = await functions.GetEntityId("course", cbox_course.Text, "id", FrmAddCourse.endpoint);
            if (course_id != null)
            {
                student_school.course = course_id;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                student_school.yr_lvl = cbox_year_lvl.Text;
                student_school.semester = cbox_semester.Text;

                await functions.InsertData(student_school, endpoint);
         


                if (functions.api_response_success)
                {
                    (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    Enabled = false;
                    await Task.Delay(2000);
                    Enabled = true;
                }

            }
            catch (ArgumentException ex_argument)
            {
                MessageBox.Show(ex_argument.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cbox_department.Text = "--Select Department--";
            cbox_course.Text = "--Select Course--";
            cbox_year_lvl.Text = "--Select Year level--";
            cbox_semester.Text = "--Select Semester--";
        }
    }
   

    public class StudentSchoolDetails
    {
        private int? _stdnt_id;
        private int? _course;
        private int? _department;
        private string _yr_lvl;
        private string _semester;
        private bool _active;
        private int _id;

        public int? stdnt_id
        {
            get { return _stdnt_id; }
            set { _stdnt_id = value; }
        }

        public int? course
        {
            get { return _course; }
            set { _course = value; }
        }

        public int? department
        {
            get { return _department; }
            set { _department = value; }
        }

        public string yr_lvl
        {
            get { return _yr_lvl; }
            set { _yr_lvl = value; }
        }

        public string semester
        {
            get { return _semester; }
            set { _semester = value; }
        }

        public bool active
        {
            get { return _active; }
            set { _active = value; }
        }

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}