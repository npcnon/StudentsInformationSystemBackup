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
    public partial class UcAddMoreStudent : DevExpress.DXperience.Demos.TutorialControlBase
    {
        int? student_id;
        public static string modifyendpoint= "api/deactivate_or_modify_student";
        public UcAddMoreStudent()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private async void UcAddMoreStudent_Load(object sender, EventArgs e)
        {
            cbox_student.Properties.Items.Clear();
            await functions.LoadData<Staff>(UcAddStudent.endpoint, null, cbox_student, d => $"{d.f_name} {d.m_name} {d.l_name}");
        }

        private async void cbox_student_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                student_id = await functions.GetEntityId(null, cbox_student.Text, "id", UcAddStudent.endpoint, true);

            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btn_save_and_add_Click(object sender, EventArgs e)
        {

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
