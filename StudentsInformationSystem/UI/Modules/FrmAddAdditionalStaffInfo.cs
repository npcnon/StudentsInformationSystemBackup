using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmAddAdditionalStaffInfo : DevExpress.XtraEditors.DirectXForm
    {
        internal const string endpoint = "api/addstaffinfo/";
        internal Addstaffinfo addstaffinfo= new Addstaffinfo();
        public FrmAddAdditionalStaffInfo()
        {
            InitializeComponent();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_address.Clear();
            txt_contact.Clear();
            txt_email.Clear();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btn_add_Click(object sender, EventArgs e)
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
                addstaffinfo.staff_address = txt_address.Text;
                addstaffinfo.contact_info = txt_contact.Text;
                addstaffinfo.email = txt_email.Text;


                await functions.InsertData(addstaffinfo, endpoint);

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

        private async void FrmAddAdditionalStaffInfo_Load(object sender, EventArgs e)
        {
            cbox_staff.Properties.Items.Clear();
            await functions.LoadData<Staff>(FrmAddStaff.endpoint, null, cbox_staff, d => $"{d.f_name} {d.m_name} {d.l_name}");
        }

        private async void cbox_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? staff_id = await functions.GetEntityId(null, cbox_staff.Text, "id", FrmAddStaff.endpoint, true);
            if (staff_id != null)
            {
                addstaffinfo.staff_id = staff_id;
            }
        }
    }

    internal class Addstaffinfo
    {
        private string _staff_address;
        private string _contact_info;
        private string _email;
        private int? _staff_id;
        private bool _active;
        private int _id;
        public string staff_address
        {
            get => _staff_address;
            set => _staff_address = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Address cannot be null");
        }
    
        public string contact_info
        {
            get => _contact_info;
            set => _contact_info = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Contact Info cannot be null");
        }

        public string email
        {
            get => _email;
            set => _email = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Email cannot be null");
        }
        public int? staff_id
        {
            get => _staff_id;
            set => _staff_id = value;
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