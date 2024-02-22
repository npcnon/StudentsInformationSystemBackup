using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcAddStdnt : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        private List<Control> controlList;
        private bool datavalid;
        private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";
        public UcAddStdnt()
        {
            InitializeComponent();
        }

        private void UcAddStdnt_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();

            controlList = new List<Control>
            {
                txt_fname,
                txt_mname,
                txt_lname,
                dedit_bday,
                cbox_gender,
                cbox_civil_status,
                cbox_citizenship,
                cbox_religion,
                txt_address,
                txt_contact_info,
                txt_email,
                cbox_course,
                cbox_department,
                cbox_year_lvl,
                cbox_semester,
            };

            //added keypress event handler
            for (int i = 0; i < 15; i++)
            {
                controlList[i].KeyDown += control_keypress;
            }
            txt_fname.Focus();
            string sqlQuery = "SELECT MAX(stdnt_id)+1 FROM TblStdntInfo";
            functions.LoadID(txt_id, sqlQuery);

        }

        private void control_keypress(object sender, KeyEventArgs e)
        {
            Control control = sender as Control; // Cast sender to Control

            if (control != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Check the name of the control that triggered the event
                    string controlName = control.Name;

                    // Do something based on the name of the control
                    for (int i = 0; i < 14; i++)
                    {
                        if (controlName == controlList[i].Name)
                        {
                            controlList[i + 1].Focus();
                            Debug.Write(controlList[i].Name, "\n was entered");
                            if (controlList[i + 1] is ComboBoxEdit)
                            {
                                ComboBoxEdit comboBoxEdit = controlList[i + 1] as ComboBoxEdit;
                                comboBoxEdit.ShowPopup();
                            }
                            else if (controlList[i + 1] is DateEdit)
                            {
                                DateEdit dateedit = controlList[i + 1] as DateEdit;
                                dateedit.ShowPopup();
                            }

                        }

                    }
                }
            }
        }







        private void btn_stdnt_cancel_Click(object sender, EventArgs e)
        {
            // Dispose the user control
            this.Dispose();
        }

        private void btn_add_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Bitmap selectedImage = new Bitmap(openFileDialog.FileName))
                {
                    // Resize the image to fit the desired dimensions (99x106)
                    Bitmap resizedImage = functions.ResizeImage(selectedImage, 99, 106);

                    // Set the resized image as the picture in the PictureEdit control
                    pedit_stdnt_pic.Image = resizedImage;
                }
            }
        }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int currentIndex = tabpane_addstdnt.SelectedPageIndex;

            // Calculate the index of the next tab
            int nextIndex = (currentIndex + 1) % tabpane_addstdnt.Pages.Count;

            // Select the next tab
            tabpane_addstdnt.SelectedPageIndex = nextIndex;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
