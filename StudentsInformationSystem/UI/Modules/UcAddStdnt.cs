using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
            functions.loaditemlistbox(chlibox_subj, "offercode", "TblSubjInfo");
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




        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int currentIndex = tabpane_addstdnt.SelectedPageIndex;

            // Calculate the index of the next tab
            int nextIndex = (currentIndex + 1) % tabpane_addstdnt.Pages.Count;

            // Select the next tab
            tabpane_addstdnt.SelectedPageIndex = nextIndex;
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            submit();
        }

        private void submit()
        {
            
            Debug.WriteLine("Submit was running######");
            datavalid = false;
            // Retrieve the values from the textboxes
            string Fname = txt_fname.Text;
            string Mname = txt_mname.Text;
            string Lname = txt_lname.Text;
            string gender = cbox_gender.Text;
            string CivilStats = cbox_civil_status.Text;
            string Citizenship = cbox_citizenship.Text;
            string Religion = cbox_religion.Text;
            string Address = txt_address.Text;
            string Contact = txt_contact_info.Text;
            string Email = txt_email.Text;
            string Depart = cbox_department.Text;
            string Course = cbox_course.Text;
            string Yearlvl = cbox_year_lvl.Text;
            string semester = cbox_semester.Text;
            Debug.WriteLine("Fname check");
            if (Fname.Length > 50 || string.IsNullOrWhiteSpace(Fname))
            {
                MessageBox.Show("First Name -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_fname.Text = "";
                txt_fname.Focus();
              
            }
            else if (Mname.Length > 50 || string.IsNullOrWhiteSpace(Mname))
            {
                MessageBox.Show("Middle Name -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_mname.Text = "";
                txt_mname.Focus();
              
            }
            else if (Lname.Length > 50 || string.IsNullOrWhiteSpace(Lname))
            {
                MessageBox.Show("Last Name -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_lname.Text = "";
                txt_lname.Focus();
            
            }

            else if (gender.Length > 150 || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Gender -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_gender.SelectedIndex = 0;
                cbox_gender.Focus();
              
            }
            else if (CivilStats.Length > 150 || string.IsNullOrWhiteSpace(CivilStats))
            {
                MessageBox.Show("Civil Status -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_civil_status.SelectedIndex = 0;
                cbox_civil_status.Focus();
           
            }
            else if (!Regex.IsMatch(Contact, @"^\d{11}$"))
            {
                MessageBox.Show("Contact -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_contact_info.Text = "";
                txt_contact_info.Focus();
                
            }
            else if (Email.Length > 100 || !Regex.IsMatch(Email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Email -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_email.Text = "";
                txt_email.Focus();
                
            }
            else if (Citizenship.Length > 150 || string.IsNullOrWhiteSpace(Citizenship))
            {
                MessageBox.Show("Citizenship -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_citizenship.SelectedIndex = 0;
                cbox_citizenship.Focus();
               
            }
            else if (Religion.Length > 150 || string.IsNullOrWhiteSpace(Religion))
            {
                MessageBox.Show("Religion -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_religion.SelectedIndex = 0;
                cbox_religion.Focus();
               
            }
            else if (Address.Length > 150 || string.IsNullOrWhiteSpace(Address))
            {
                MessageBox.Show("Address -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                txt_address.Text = "";
                txt_address.Focus();
               
            }
            else if (Course.Length > 150 || string.IsNullOrWhiteSpace(Course))
            {
                MessageBox.Show("Course -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_course.SelectedIndex = 0;
                cbox_course.Focus();
                
            }
            else if (Depart.Length > 150 || string.IsNullOrWhiteSpace(Depart))
            {
                MessageBox.Show("Depart -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_department.SelectedIndex = 0;
                cbox_department.Focus();
                 }
            else if (Yearlvl.Length > 150 || string.IsNullOrWhiteSpace(Yearlvl))
            {
                MessageBox.Show("YearLvl -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_year_lvl.SelectedIndex = 0;
                cbox_year_lvl.Focus();
                
            }
            else if (semester.Length > 150 || string.IsNullOrWhiteSpace(semester))
            {
                MessageBox.Show("semester -- INVALID");
                functions.back_tabpane(tabpane_addstdnt);
                cbox_citizenship.SelectedIndex = 0;
                cbox_citizenship.Focus();
               
            }

            else
            {

              
                Debug.WriteLine("Else was running ##########");
                byte[] imageData = functions.ImageToByteArray(pedit_stdnt_pic.Image);


                string sqlInsert = @"
                        INSERT INTO TblStdntInfo (f_name, m_name, l_ame, birth_date, gender,civil_stat, citizenship, religion, ImageData) 
                        VALUES (@Fname, @Mname, @Lname, @Bday, @Gender, @Civilstat, @Citizen, @Religion, @Image);

                        DECLARE @Id INT;
                        SET @Id = SCOPE_IDENTITY();

                        INSERT INTO TblAddStdntInfo (stdnt_id, stdnt_address, contact_info, email) 
                        VALUES (@Id, @Address, @Contact, @Email);

                        INSERT INTO TblStdntSchoolDetails (stdnt_id, course, department, yr_lvl, semester)
                        VALUES(@Id, @Course, @Department, @Yearlvl, @Semester);
                    ";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    Debug.WriteLine("Connection Success!!!");
                    try
                    {
                        using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                        {
                            // Add parameters for the first INSERT statement
                            command.Parameters.AddWithValue("@Fname", Fname);
                            command.Parameters.AddWithValue("@Mname", Mname);
                            command.Parameters.AddWithValue("@Lname", Lname);
                            command.Parameters.AddWithValue("@Bday", dedit_bday.Text);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@Civilstat", CivilStats);
                            command.Parameters.AddWithValue("@Citizen", Citizenship);
                            command.Parameters.AddWithValue("@Religion", Religion);
                            command.Parameters.AddWithValue("@Image", imageData);

                            // Add parameters for the second INSERT statement
                            command.Parameters.AddWithValue("@Address", Address);
                            command.Parameters.AddWithValue("@Contact", Contact);
                            command.Parameters.AddWithValue("@Email", Email);

                            // Add parameters for the third INSERT statement
                            command.Parameters.AddWithValue("@Course", Course);
                            command.Parameters.AddWithValue("@Department", Depart);
                            command.Parameters.AddWithValue("@Yearlvl", Yearlvl);
                            command.Parameters.AddWithValue("@Semester", semester);

                            connection.Open();

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted successfully into the database.");
                                datavalid = true;
                                listcheckboxsubmit();
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data into the database.");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        Debug.WriteLine("SQL Error Number: " + ex.Number);
                        Debug.WriteLine("SQL Error Message: " + ex.Message);
                        Debug.WriteLine("SQL Server: " + ex.Server);
                       
                        Debug.WriteLine("Procedure: " + ex.Procedure);
                        Debug.WriteLine("Line Number: " + ex.LineNumber);
                    }
                }



            }

           

        }

        private void listcheckboxsubmit()
        {
            CheckedListBoxControl checkedListBox = chlibox_subj;

            // List to store checked values
            List<object> checkedValues = new List<object>();

            // Iterate through each item in the CheckedListBoxControl
            for (int i = 0; i < checkedListBox.ItemCount; i++)
            {
                // Check if the current item is checked
                if (checkedListBox.GetItemCheckState(i) == CheckState.Checked)
                {
                    // Add the value of the checked item to the list
                    checkedValues.Add(checkedListBox.GetItemValue(i));
                }
            }

            string sqlInsert = @"
            DECLARE @Id INT;
            SELECT @Id = stdnt_id FROM TblStdntInfo;
            INSERT INTO TblStdntSubj (stdnt_id, offercode) 
            VALUES (@Id, @Offercode);   
        ";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                foreach (string item in checkedValues)
                {
                    using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                    {
                        try
                        {
                            // Assuming you have an stdnt_id available here
                            command.Parameters.AddWithValue("@Offercode", item);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("DataList inserted successfully into the database.");
                                datavalid = true;
                            }
                            else
                            {
                                MessageBox.Show("Failed to insert datalist into the database.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error inserting datalist: " + ex.Message);
                        }
                    }
                }
            }
        }

    }
}
