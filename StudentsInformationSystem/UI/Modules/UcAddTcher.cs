    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using System.Data.SqlClient;
    using DevExpress.XtraEditors.Drawing;
    using DevExpress.Utils.Controls;
    using System.Text.RegularExpressions;
    using DevExpress.XtraSplashScreen;

    namespace StudentsInformationSystem.UI.Modules
    {
        public partial class UcAddTcher : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
        {
            private List<Control> controlList;
            private bool datavalid;
            private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";
            public UcAddTcher()
            {
                InitializeComponent();


            }


            private void UcAddTcher_Load_1(object sender, EventArgs e)
            {
                //added all the textbox, datetime and combo box to a list of controls
                controlList = new List<Control>
                {
                    tcher_id,
                    tcher_fname,
                    tcher_mname,
                    tcher_lname,
                    tcher_bd,
                    tcher_gender,
                    tcher_civil_stats,
                    tcher_address,
                    tcher_contact_info,
                    tcher_email
                };

                //loading animation appears 
                splashScreenManager1.ShowWaitForm();
                Thread.Sleep(3000);
                splashScreenManager1.CloseWaitForm();


                //added keypress event handler
                for (int i = 0; i < 10; i++)
                {
                    controlList[i].KeyDown += control_keypress;
                }
                tcher_fname.Focus();

                //added value to the teacher id textbox, value is from database teacher_id
                functions.LoadTeacherId(tcher_id);
            }


            //keypress event handler
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
                        for (int i = 0; i < 9; i++)
                        {
                            if (controlName == controlList[i].Name)
                            {
                                controlList[i + 1].Focus();
                            }

                        }
                    }
                }
            }

            private void submit()
            {
                datavalid = false;
                // Retrieve the values from the textboxes
                string tcherFname = tcher_fname.Text;
                string tcherMname = tcher_mname.Text;
                string tcherLname = tcher_lname.Text;
                DateTime tcherBday;
                string tcherGender = tcher_gender.Text;
                string tcherCivil = tcher_civil_stats.Text;
                string tcherAddress = tcher_address.Text;
                string tcherContact = tcher_contact_info.Text;
                string tcherEmail = tcher_email.Text;

                if (tcherFname.Length > 50 || string.IsNullOrWhiteSpace(tcherFname))
                {
                    MessageBox.Show("First Name -- INVALID");
                    tcher_fname.Text = "";
                    tcher_fname.Focus();

                }
                else if (tcherMname.Length > 50 || string.IsNullOrWhiteSpace(tcherMname))
                {
                    MessageBox.Show("Middle Name -- INVALID");
                    tcher_mname.Text = "";
                    tcher_mname.Focus();

                }
                else if (tcherLname.Length > 50 || string.IsNullOrWhiteSpace(tcherLname))
                {
                    MessageBox.Show("Last Name -- INVALID");
                    tcher_lname.Text = "";
                    tcher_lname.Focus();

                }
                else if (tcherGender.Length > 30 || string.IsNullOrWhiteSpace(tcherGender))
                {
                    MessageBox.Show("Gender -- INVALID");
                    tcher_gender.Focus();

                }
                else if (tcherCivil.Length > 50 || string.IsNullOrWhiteSpace(tcherCivil))
                {
                    MessageBox.Show("Civil Status -- INVALID");
                    tcher_civil_stats.Focus();

                }
                else if (tcherAddress.Length > 150 || string.IsNullOrWhiteSpace(tcherAddress))
                {
                    MessageBox.Show("Address -- INVALID");
                    tcher_address.Text = "";
                    tcher_address.Focus();

                }
                else if (!Regex.IsMatch(tcherContact, @"^\d{11}$"))
                {
                    MessageBox.Show("Contact -- INVALID");
                    tcher_contact_info.Text = "";
                    tcher_contact_info.Focus();

                }
                else if (tcherEmail.Length > 100 || !Regex.IsMatch(tcherEmail, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                {
                    MessageBox.Show("Email -- INVALID");
                    tcher_email.Text = "";
                    tcher_email.Focus();

                }
                else
                {
                    //checks if the date format is valid
                    if (DateTime.TryParse(tcher_bd.Text, out tcherBday))
                    {
                        // Add similar lines for other textboxes

                        // Create a connection string for your database
                    

                        // Write your SQL command to insert data into your database
                        string sqlInsert = @"
            INSERT INTO TblTeacherInfo (f_name, m_name, l_ame, birth_date, gender, civil_stat) 
            VALUES (@tcherFname, @tcherMname, @tcherLname, @tcherBday, @tcherGender, @tcherCivil);
        
            DECLARE @TeacherID INT;
            SET @TeacherID = SCOPE_IDENTITY();

            INSERT INTO TblAddTeacherInfo (teacher_id, teacher_address, contact_info, email) 
            VALUES (@TeacherID, @tcherAddress, @tcherContact, @tcherEmail);";

                        // Adjust the column names and table name accordingly

                        // Create a SqlConnection object
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            // Create a SqlCommand object
                            using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                            {
                                // Add parameters to the SQL command to prevent SQL injection
                                command.Parameters.AddWithValue("@tcherFname", tcherFname);
                                command.Parameters.AddWithValue("@tcherMname", tcherMname);
                                command.Parameters.AddWithValue("@tcherLname", tcherLname);
                                command.Parameters.AddWithValue("@tcherBday", tcherBday);
                                command.Parameters.AddWithValue("@tcherGender", tcherGender);
                                command.Parameters.AddWithValue("@tcherCivil", tcherCivil);
                                command.Parameters.AddWithValue("@tcherAddress", tcherAddress);
                                command.Parameters.AddWithValue("@tcherContact", tcherContact);
                                command.Parameters.AddWithValue("@tcherEmail", tcherEmail);



                                // Add similar lines for other parameters

                                // Open the connection
                                connection.Open();

                                // Execute the SQL command
                                int rowsAffected = command.ExecuteNonQuery();

                                // Check if the query executed successfully
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Data inserted successfully into the database.");
                                    datavalid = true;
                            
                                }
                                else
                                {
                                    MessageBox.Show("Failed to insert data into the database.");
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format");
                        tcher_bd.Focus();
                        tcher_bd.EditValue = null;
                    }
                }



            }
        

            private void refresh()
            {
                tcher_id.Text = (Convert.ToInt32(tcher_id.Text) + 1).ToString();
                for (int i = 1; i < 10; i++)
                {
                    if (controlList[i] is TextEdit)
                    {
                        controlList[i].Text = "";
                    }
                    else if (controlList[i] is ComboBoxEdit)
                    {
                        ((ComboBoxEdit)controlList[i]).SelectedIndex = 0;
                    }
                    else if (controlList[i] is DateEdit)
                    {
                        ((DateEdit)controlList[i]).EditValue = null;
                    }
                }
                tcher_fname.Focus();
            }

        private bool CheckDataExistsInDatabase()
        {
            bool dataExists = false;

            // Write your SQL query to check if the data exists in the database
            string sqlQuery = "SELECT COUNT(*) FROM TblTeacherInfo WHERE f_name = @tcherFname AND m_name = @tcherMname AND l_ame = @tcherLname AND birth_date = @tcherBday AND gender = @tcherGender AND civil_stat = @tcherCivil";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameters to the SQL command to prevent SQL injection
                    command.Parameters.AddWithValue("@tcherFname", tcher_fname.Text);
                    command.Parameters.AddWithValue("@tcherMname", tcher_mname.Text);
                    command.Parameters.AddWithValue("@tcherLname", tcher_lname.Text);
                    command.Parameters.AddWithValue("@tcherBday", tcher_bd.EditValue);
                    command.Parameters.AddWithValue("@tcherGender", tcher_gender.Text);
                    command.Parameters.AddWithValue("@tcherCivil", tcher_civil_stats.Text);

                    // Open the connection
                    connection.Open();

                    // Execute the SQL command and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0, indicating that the data exists
                    if (count > 0)
                    {
                        dataExists = true;
                    }
                }
            }

            return dataExists;
        }
        private bool CheckDataExistsInDatabaseAdd()
        {
            bool dataExists = false;

            // Write your SQL query to check if the data exists in the database
            string sqlQuery = "SELECT COUNT(*) FROM TblAddTeacherInfo WHERE  teacher_address = @tcherAddress AND contact_info = @tcherContact AND email = @tcherEmail";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameters to the SQL command to prevent SQL injection
                    command.Parameters.AddWithValue("@tcherAddress", tcher_address.Text);
                    command.Parameters.AddWithValue("@tcherContact", tcher_contact_info.Text);
                    command.Parameters.AddWithValue("@tcherEmail", tcher_email.Text);

                    // Open the connection
                    connection.Open();

                    // Execute the SQL command and get the result
                    int count = (int)command.ExecuteScalar();

                    // Check if the count is greater than 0, indicating that the data exists
                    if (count > 0)
                    {
                        dataExists = true;
                    }
                }
            }

            return dataExists;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (CheckDataExistsInDatabase())
            {
                MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                submit();
                if (datavalid)
                {

                    DialogResult result = MessageBox.Show("Do you want to add Additional Info?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        btn_add_more.Enabled = true;
                        tcher_address.Text = "";
                        tcher_contact_info.Text = "";
                        tcher_email.Text = "";
                        gcont_basic.Enabled = false;
                        btn_addsubmit.Enabled = false;
                        btn_teacher_submit.Enabled = false;
                    }

                }
            }
           
             
        }

            private void simpleButton2_Click(object sender, EventArgs e)
            {
                submit();
           
                if(datavalid)
                {
                    refresh();
                } 
            }

            private void simpleButton3_Click(object sender, EventArgs e)
            {
                if(gcont_basic.Enabled == false)
                {
                gcont_basic.Enabled = true;
                btn_addsubmit.Enabled = true;
                btn_teacher_submit.Enabled = true;
                btn_add_more.Enabled = false;
                    refresh();
                }

                else
                {
                    this.Dispose();
                }
            
            }

            private void btn_teacher_add_email_Click(object sender, EventArgs e)
            {
            


                    if (tcher_address.Text.Length > 150 || string.IsNullOrWhiteSpace(tcher_address.Text))
                    {
                        MessageBox.Show("Address -- INVALID");
                        tcher_address.Text = "";
                        tcher_address.Focus();

                    }
                    else if (!Regex.IsMatch(tcher_contact_info.Text, @"^\d{11}$"))
                    {
                        MessageBox.Show("Contact -- INVALID");
                        tcher_contact_info.Text = "";
                        tcher_contact_info.Focus();

                    }
                    else if (tcher_email.Text.Length > 100 || !Regex.IsMatch(tcher_email.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                    {
                        MessageBox.Show("Email -- INVALID");
                        tcher_email.Text = "";
                        tcher_email.Focus();
                    }
                    else
                    {

                         if(CheckDataExistsInDatabaseAdd())
                         {
                    MessageBox.Show("Data already exists in the database.", "Duplicate Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                    // Write your SQL command to insert data into your database
                    string sqlInsert = @"
                    INSERT INTO TblAddTeacherInfo (teacher_id, teacher_address, contact_info, email) 
                    VALUES (@TeacherID, @tcherAddress, @tcherContact, @tcherEmail);";

                    // Adjust the column names and table name accordingly

                    // Create a SqlConnection object
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Create a SqlCommand object
                        using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                        {
                            // Add parameters to the SQL command to prevent SQL injection
                            command.Parameters.AddWithValue("@TeacherID", tcher_id.Text);
                            command.Parameters.AddWithValue("@tcherAddress", tcher_address.Text);
                            command.Parameters.AddWithValue("@tcherContact", tcher_contact_info.Text);
                            command.Parameters.AddWithValue("@tcherEmail", tcher_email.Text);



                            // Add similar lines for other parameters

                            // Open the connection
                            connection.Open();

                            // Execute the SQL command
                            int rowsAffected = command.ExecuteNonQuery();

                            // Check if the query executed successfully
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Data inserted successfully into the database.");

                            }
                            else
                            {
                                MessageBox.Show("Failed to insert data into the database.");
                            }
                        }
                    }
                }
                        
                    }


             
            }
        }
    }