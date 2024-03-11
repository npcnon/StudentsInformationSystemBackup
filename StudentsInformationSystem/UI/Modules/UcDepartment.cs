using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcDepartment : DevExpress.DXperience.Demos.TutorialControlBase
    {
        // Define a custom event
        public static event EventHandler SaveButtonClicked;

        internal const string endpoint = "api/department/";

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
                await functions.InsertData(department, endpoint);

                // Raise the custom event when the "Save" button is clicked
                OnSaveButtonClicked(EventArgs.Empty);
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

        // Method to raise the custom event
        protected virtual void OnSaveButtonClicked(EventArgs e)
        {
            SaveButtonClicked?.Invoke(this, e);
        }
    }

    internal class Department
    {
        private string _department;
        private int _id = 0;

        public string department
        {
            get => _department;
            set => _department = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }

        public int id
        {
            get => _id;
        }
    }
}
