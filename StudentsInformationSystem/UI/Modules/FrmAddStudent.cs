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
    public partial class FrmAddStudent : DevExpress.XtraEditors.DirectXForm
    {
        internal const string endpoint = "api/student/";
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap selectedImage = new Bitmap(openFileDialog.FileName))
                {
                    // Calculate the desired dimensions based on the size of the PictureEdit control
                    int width = pedit_stdnt_pic.Width;
                    int height = pedit_stdnt_pic.Height;

                    // Resize the image to fit the desired dimensions
                    Bitmap resizedImage = functions.ResizeImage(selectedImage, width, height);

                    // Set the resized image as the picture in the PictureEdit control
                    pedit_stdnt_pic.Image = resizedImage;
                }
            }
        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                var student = new Student
                {
                    f_name = txt_fname.Text,
                    m_name = txt_mname.Text,
                    l_name = txt_lname.Text,
                    birth_date = dedit_bday.DateTime,
                    gender = cbox_gender.Text,
                    civil_stat = cbox_civil_status.Text,
                    citizenship = "data not inserted",
                    religion = "data not inserted",
                    ImageData = functions.ConvertImageToByteArray(pedit_stdnt_pic.Image)
                };
                await functions.InsertData(student, endpoint);

                // Raise the custom event when the "Save" button is clicked


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

        private async void FrmAddStudent_Load(object sender, EventArgs e)
        {
            int? student_id = await functions.GetStudentId(endpoint);
            if (student_id != null)
            {
                txt_id.Text = student_id.ToString();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            pedit_stdnt_pic.Image = null;
            txt_fname.Text = "";
            txt_mname.Text = "";
            txt_lname.Text = "";
            dedit_bday.Text = "";
            cbox_civil_status.Text = "--SELECT STATUS--";
            cbox_gender.Text = "--SELECT GENDER--";
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    internal class Student
    {
        private string _f_name;
        private string _m_name;
        private string _l_name;
        private DateTime _birth_date;
        private string _gender;
        private string _civil_stat;
        private string _citizenship;
        private string _religion;
        private byte[] _ImageData;
        private bool _active;

        public string f_name
        {
            get => _f_name;
            set => _f_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Invalid First Name");
        }

        public string m_name
        {
            get => _m_name;
            set => _m_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Invalid Middle Name");
        }

        public string l_name
        {
            get => _l_name;
            set => _l_name = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Invalid Last Name");
        }

        public DateTime birth_date
        {
            get => _birth_date;
            set
            {
                if (value <= DateTime.Now)
                {
                    _birth_date = value;
                }
                else
                {
                    throw new ArgumentException("Error: Invalid Birth Date");
                }
            }
        }

        public string gender
        {
            get => _gender;
            set => _gender = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Invalid Gender");
        }

        public string civil_stat
        {
            get => _civil_stat;
            set => _civil_stat = value; // You can add validation if required
        }

        public string citizenship
        {
            get => _citizenship;
            set => _citizenship = value; // You can add validation if required
        }

        public string religion
        {
            get => _religion;
            set => _religion = value; // You can add validation if required
        }

        public byte[] ImageData
        {
            get => _ImageData;
            set => _ImageData = value; // You may need to validate or process image data here
        }

        public bool active
        {
            get => _active;
            set => _active = value; // You can add validation if required
        }
    }
}