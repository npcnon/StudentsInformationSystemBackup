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
        int? student_id;
        public static string modifyendpoint = "api/addstdntinfo/";
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
                student_id = await functions.GetEntityId(null, cbox_student.Text, "id", FrmAddStudent.endpoint, true);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btn_save_Click_1(object sender, EventArgs e)
        {

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
                        string filterCriteria = $"course_id={id}";

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    public class AddStdntInfo
    {
        private int? _stdnt_id;
        private string _stdnt_address;
        private string _contact_info;
        private string _email;
        private int _id;
        private bool _active;


        public int? stdnt_id
        {
            get => _stdnt_id;
            set => _stdnt_id = value;
        }

        public string stdnt_address
        {
            get => _stdnt_address;
            set => _stdnt_address = value;
        }

        public string contact_info
        {
            get => _contact_info;
            set => _contact_info = value;
        }

        public string email
        {
            get => _email;
            set => _email = value;
        }
        public int id
        {
            get => _id;
            set => _id = value;
        }

        public bool active
        {
            get => _active;
            set => _active = value;
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