using DevExpress.DocumentServices.ServiceModel.DataContracts;
using DevExpress.XtraToolbox;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsInformationSystem
{
    internal class functions
    {
        //method to lead the teacher id to the teacher id textbox
        public static void LoadID(Control txtbox,string sqlQuery)
        {
            // Create a connection string for your database
            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";

            // Write your SQL command to retrieve teacher ID from the database
          

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL command and get the result
                    object result = command.ExecuteScalar();

                    // Check if the result is not null
                    if (!string.IsNullOrEmpty(result.ToString()))
                    {
                        Debug.WriteLine($"{result}ifffffffffffffff#################################################################################");
                        // Assign the result to the Text property of the textbox
                        txtbox.Text = result.ToString();
                    }
                    else
                    {
                        Debug.Write("#############################ELSE WAS EXECUTED##################################################");
                        txtbox.Text = "1";
                    }
                   
                }
            }
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }



        public static bool ChckIfDatabaseHaveData()
        {
            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";

            // Write your SQL command to retrieve teacher ID from the database
            string sqlQuery = "SELECT COUNT (*) FROM TblTeacherInfo";

            // Create a SqlConnection object
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Create a SqlCommand object
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    // Open the connection
                    connection.Open();

                    // Execute the SQL command and get the result
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

    }


}
