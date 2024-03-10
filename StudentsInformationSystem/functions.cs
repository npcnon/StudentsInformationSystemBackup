using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using StudentsInformationSystem.UI.Modules;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using System.Threading.Tasks;
using DevExpress.XtraGrid;
using System.Text;
using System.Linq;

namespace StudentsInformationSystem
{
    internal class functions
    {

        internal static string baseUrl = "http://127.0.0.1:8000/";
        internal static HttpClient client = new HttpClient();
       

        //method to lead the teacher id to the teacher id textbox
        public static void LoadID(Control txtbox, string sqlQuery)
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


        public static bool ChckAdmin()
        {
            List<string[]> adminCredentials = new List<string[]>();

            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";
            string sqlQuery = @"SELECT [username], [pass] FROM TblUsers WHERE previlages = 'admin'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Check if the query returned any rows
                        if (reader.HasRows)
                        {
                            // Iterate through the rows
                            while (reader.Read())
                            {
                                // Create an array to store the user and password
                                string[] credentials = new string[2];
                                // Store the values in the array
                                credentials[0] = reader.GetString(0); // assuming 'user' is at index 0
                                credentials[1] = reader.GetString(1); // assuming 'password' is at index 1
                                                                      // Add the array to the list
                                adminCredentials.Add(credentials);
                            }
                        }
                    }
                }
            }
            if (adminCredentials.Count > 0 && adminCredentials[0][0] == "admin" && adminCredentials[0][1] == "admin")
            {

                return true;
            }
            else
            {
                return false;
            }


        }

        public static void loaditem(ComboBoxEdit combobox, string columnName, string tableName,string firstadd)
        {
            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";
           
            string sqlQuery = $"SELECT DISTINCT {columnName} FROM {tableName}"; // Modify the query as per your table structure

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ComboBoxEdit
                    combobox.Properties.Items.Clear();

                    // Loop through the retrieved data and add it to the ComboBoxEdit
                    combobox.Properties.Items.Add(firstadd);
                    while (reader.Read())
                    {
                        combobox.Properties.Items.Add(reader[columnName].ToString());
                    }

                    // Optionally, select the first item in the ComboBoxEdit
                    if (combobox.Properties.Items.Count > 0)
                    {
                        combobox.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        
        }
        public static void loaditemlistbox(CheckedListBoxControl libox, string columnName, string tableName)
        {
            string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True";

            string sqlQuery = $"SELECT DISTINCT {columnName} FROM {tableName}"; // Modify the query as per your table structure

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlQuery, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items in the ComboBoxEdit
                    libox.Items.Clear();

                    // Loop through the retrieved data and add it to the ComboBoxEdit
                    
                    while (reader.Read())
                    {
                        libox.Items.Add(reader[columnName].ToString());
                    }

                    // Optionally, select the first item in the ComboBoxEdit
                    if (libox.Items.Count > 0)
                    {
                        libox.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        public static void datecheck(DateEdit date_edit)
        {
            if (DateTime.TryParseExact(date_edit.Text, "MM/dd/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime birthDate))
            {
                // Check if the parsed date is within a valid range
                if (birthDate >= DateTime.MinValue && birthDate <= DateTime.MaxValue)
                {
                    // The parsed date is valid
                    // You can proceed with inserting it into the database or performing any other necessary actions
                }
                else
                {
                    // The parsed date is invalid (e.g., outside the range of valid dates)
                    MessageBox.Show("Invalid date.");
                    // Set dedit_bday to DateTime.MinValue or take any other necessary action
                    date_edit.DateTime = DateTime.MinValue;
                    date_edit.Focus();
                }
            }
            else
            {
                // The input date is in an invalid format
                MessageBox.Show("Invalid date format. Please enter the date in MM/dd/yyyy format.");
            }

        }



        public static void back_tabpane(TabPane tab)
        {
            int currentIndex = tab.SelectedPageIndex;

            // Calculate the index of the next tab
            int nextIndex = (currentIndex + 1) % tab.Pages.Count;

            // Select the next tab
            tab.SelectedPageIndex = nextIndex;
        }


        internal static async Task LoadData<T>(string endpoint, GridControl gcont, ComboBoxEdit cbox = null, Func<T, object> conversionFunc = null) where T : class
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<T[]>(jsonResponse);

                    if (gcont != null)
                    {
                        gcont.DataSource = data;
                    }

                    if (cbox != null)
                    {
                        if (conversionFunc != null)
                        {
                            // Use the provided conversion function to populate the ComboBoxEdit
                            cbox.Properties.Items.AddRange(data.Select(conversionFunc).ToArray());
                        }
                        else
                        {
                            MessageBox.Show("Conversion function is not provided.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        internal static async Task InsertData<T>(T data, string endpoint, GridControl gcont = null) where T : class
        {
            try
            {
                string json = JsonConvert.SerializeObject(data);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                 HttpResponseMessage response = await client.PostAsync(baseUrl + endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data inserted successfully into the database.");
                    if (gcont != null)
                    {
                        await LoadData<T>(endpoint,gcont);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to insert data into the database.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



    }


}
