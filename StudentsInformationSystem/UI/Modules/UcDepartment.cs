using DevExpress.XtraBars.Ribbon.ViewInfo;
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
    public partial class UcDepartment : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors. DevExpress.XtraEditors.XtraUserControl
    {

        private string endpoint = "api/department/";
        public UcDepartment()
        {
            InitializeComponent();
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new Department
                {
                    department = txt_department.Text,
                };
                await functions.InsertData(department,)
            }
            catch
            {

            }
        }
    }

    internal class Department 
    {
        private string _department;
        public string department
        {
            get => _department;
            set => _department = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }
    }
}

