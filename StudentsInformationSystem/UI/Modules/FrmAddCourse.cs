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
    public partial class FrmAddCourse : DevExpress.XtraEditors.DirectXForm
    {

        internal const string endpoint = "api/course/";
        internal Course course = new Course();
        public FrmAddCourse()
        {
            InitializeComponent();

        }

        private async void FrmAddCourse_Load(object sender, EventArgs e)
        {

                cbox_department.Properties.Items.Clear();
                await functions.LoadData<Department>(FrmAddDepartment.endpoint, null, cbox_department, d => d.department);
           
            
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                course.course = txt_course.Text;
                
                await functions.InsertData(course, endpoint);

                // Raise the custom event when the "Save" button is clicked
                txt_course.Text = "";
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

        private async void cbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? department_Id = await functions.GetEntityId("department", cbox_department.Text, "id", FrmAddDepartment.endpoint);
            if(department_Id != null)
            {
                course.department_Id = department_Id;
            }    
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_course.Text = "";
            cbox_department.SelectedIndex = -1;
        }
    }

    internal class Course
    {
        private int _id;
        private string _course;
        private int? _department_id;
        private bool _active = true;
        public string course
        {
            get => _course;
            set => _course = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Course cannot be null");
        }
        public int? department_Id
        {
            get => _department_id;
            set => _department_id = value;
        }

        public bool active
        {
            get => _active;
            set => _active = value;
        }

        public int id
        {
            get => _id;
            set => _id = value;
        }
    }
}