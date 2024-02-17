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

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcAddTcher : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        private List<Control> controlList;

        public UcAddTcher()
        {
            InitializeComponent();
            
           
        }


        private void UcAddTcher_Load_1(object sender, EventArgs e)
        {
            tcher_fname.Focus();
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
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();

            for(int i = 0;i<10;i++)
            {
                controlList[i].KeyDown += control_keypress;
            }
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
                    for(int i = 0;i <9;i++)
                    {
                        if(controlName == controlList[i].Name)
                        {
                            controlList[i+1].Focus();
                        }

                    }
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
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

            if (DateTime.TryParse(tcher_bd.Text, out tcherBday))
            {
                // Add similar lines for other textboxes

                // Create a connection string for your database
                string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";

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
            }


        }
    }
}