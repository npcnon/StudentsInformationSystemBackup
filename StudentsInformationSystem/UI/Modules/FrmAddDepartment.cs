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
    public partial class FrmAddDepartment : DevExpress.XtraEditors.DirectXForm
    {
        // Define a custom event
        public static event EventHandler SaveButtonClicked;

        internal const string endpoint = "api/department/";
        public FrmAddDepartment()
        {
            InitializeComponent();
        }

        protected virtual void OnSaveButtonClicked(EventArgs e)
        {
            SaveButtonClicked?.Invoke(this, e);
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var department = new Department
                {
                    department = txt_department.Text
                };
                await functions.InsertData(department, endpoint);

                // Raise the custom event when the "Save" button is clicked
                OnSaveButtonClicked(EventArgs.Empty);
                txt_department.Text = "";
                (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
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

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_department.Text = "";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    internal class Department
    {
        private string _department;
        private int _id;

        public string department
        {
            get => _department;
            set => _department = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }

        public int id
        {
            get => _id;
            set => _id = value;
        }
    }
}