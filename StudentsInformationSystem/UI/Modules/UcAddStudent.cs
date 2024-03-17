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
    public partial class UcAddStudent : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public UcAddStudent()
        {
            InitializeComponent();


        }


        private void btn_add_Click_1(object sender, EventArgs e)
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

        private void btn_save_Click(object sender, EventArgs e)
        {

        }


        
    }


    internal class Student
    {
        private string _f_name;
        private string _m_name;
        private string _l_name;
        private DateTime _bird_date;
        private string _gender;
        private string _civil_stat;
        private string _citizenship;
        private string 



    }
}
