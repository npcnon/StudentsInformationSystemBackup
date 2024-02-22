using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangePass()
        {
            InitializeComponent();
            // Set the background image layout to stretch
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Load the login background image
            this.BackgroundImage = Properties.Resources.login_background;
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {

            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";
            string sqlQuery = @"UPDATE USERS 
                    SET username = @UserName, pass = @Password 
                    WHERE username = 'admin' AND pass = 'admin' AND previlages = 'admin'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Add parameters to the SQL command to prevent SQL injection
                    command.Parameters.AddWithValue("@UserName", txt_username.Text);
                    command.Parameters.AddWithValue("@Password", txt_password.Text);
                   



                    // Add similar lines for other parameters

                    // Open the connection
                    connection.Open();

                    // Execute the SQL command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if the query executed successfully
                    if (rowsAffected > 0)
                    {   
                        MessageBox.Show("Password changed successfully.");
                        

                    }
                    else
                    {
                        MessageBox.Show("Failed to change password.");
                    }
                }
            }
        }
    }
}