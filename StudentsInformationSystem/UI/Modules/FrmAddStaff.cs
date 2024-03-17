using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmAddStaff : DevExpress.XtraEditors.DirectXForm
    {
        internal const string endpoint = "api/staff/";
        internal Staff staff = new Staff();
        public FrmAddStaff()
        {
            InitializeComponent();
        }

        private async void cbox_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? department_Id = await functions.GetEntityId("department", cbox_department.Text, "id", FrmAddDepartment.endpoint);
            if (department_Id != null)
            {
                staff.department_id = department_Id;
            }
        }

        private async void FrmAddStaff_Load(object sender, EventArgs e)
        {
            cbox_department.Properties.Items.Clear();
            await functions.LoadData<Department>(FrmAddDepartment.endpoint, null, cbox_department, d => d.department);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_mname.Clear();
            txt_lname.Clear();
            cbox_department.SelectedIndex = -1;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                staff.f_name = txt_fname.Text;
                staff.m_name = txt_mname.Text;
                staff.l_name = txt_lname.Text;

                await functions.InsertData(staff, endpoint);

                // Raise the custom event when the "Save" button is clicked
                txt_fname.Clear();
                txt_mname.Clear();
                txt_lname.Clear();
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
    }
    internal class Staff
    {
        private int _id;
        private string _f_name;
        private string _m_name;
        private string _l_name;
        private int? _department_id;
        private bool _active;

        public int id
        {
            get => _id;
            set => _id = value;
        }

        public string f_name
        {
            get => _f_name;
            set => _f_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: First Name cannot be null");
        }
        public string m_name
        {
            get => _m_name;
            set => _m_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Middle Name cannot be null");
        }
        public string l_name
        {
            get => _l_name;
            set => _l_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Last Name cannot be null");
        }
        public int? department_id
        {
            get => _department_id;
            set => _department_id = value;
        }
        public bool active
        {
            get => _active;
            set => _active = value;
        }
    }
}