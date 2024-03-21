using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmStdntContactInfo : DevExpress.XtraEditors.DirectXForm
    {
        public static string endpoint = "api/addstdntinfo/";
        internal AddStdntInfo student_additional = new AddStdntInfo();
        public FrmStdntContactInfo()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txt_contact.Text, @"^\d{11}$"))
                {

                    MessageBox.Show("Invalid Contact Info.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Invalid Email.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                student_additional.stdnt_address = txt_address.Text;
                student_additional.email = txt_email.Text;
                student_additional.contact_info = txt_contact.Text;

                await functions.InsertData(student_additional, endpoint);



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

        private async void FrmStdntContactInfo_Load(object sender, EventArgs e)
        {
            cbox_student.Properties.Items.Clear();
            await functions.LoadData<Student>(FrmAddStudent.endpoint, null, cbox_student, d => $"{d.f_name} {d.m_name} {d.l_name}");


        }

        private async void cbox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int? student_id = await functions.GetEntityId(null, cbox_student.Text, "id", FrmAddStudent.endpoint, true);
                if (student_id.HasValue)
                {
                    student_additional.stdnt_id = student_id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
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
}