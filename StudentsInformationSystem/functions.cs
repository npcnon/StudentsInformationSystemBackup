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
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Data;
using DevExpress.XtraBars.FluentDesignSystem;
using System.Net;
using System.Reflection;

namespace StudentsInformationSystem
{
    internal class functions
    {

        internal static string baseUrl = "http://127.0.0.1:8000/";
        internal static HttpClient client = new HttpClient();
        internal static bool api_response_success = true;
        //method to lead the teacher id to the teacher id textbox
        //

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }



       


       //

        //

        public static byte[] ConvertImageToByteArray(Image image)
        {
            if (image == null)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // You can choose other image formats if needed
                return ms.ToArray();
            }
        }


        //



       //


        internal static async Task LoadData<T>(string endpoint, GridControl gcont, ComboBoxEdit cbox = null, Func<T, object> conversionFunc = null, string filter = null) where T : class
        {
            try
            {
                HttpResponseMessage response;

                if (filter != null)
                {
                    // Append the filter to the endpoint URL
                    endpoint += $"?filter={filter}";
                }

                response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    api_response_success = true;
                    string jsonResponse = await response.Content.ReadAsStringAsync();

                    // Export the JSON response as a file
                    Debug.WriteLine("response.json", jsonResponse);

                    var data = JsonConvert.DeserializeObject<T[]>(jsonResponse);

                    if (gcont != null)
                    {
                        // Convert data to DataTable
                        DataTable dataTable = ConvertToDataTable(data);

                        // Remove the "active" column from the DataTable if it exists
                        if (dataTable.Columns.Contains("active"))
                        {
                            dataTable.Columns.Remove("active");
                        }

                        // Set the DataTable as the DataSource for the GridControl
                        gcont.Refresh();
                        gcont.RefreshDataSource();
                        gcont.DataSource = dataTable;
                    }

                    if (cbox != null)
                    {
                        if (conversionFunc != null)
                        {
                            // Use the provided conversion function to populate the ComboBoxEdit
                            cbox.Properties.Items.Clear();
                            foreach (var item in data)
                            {
                                cbox.Properties.Items.Add(conversionFunc(item));
                            }
                        }
                        else
                        {
                            MessageBox.Show("Conversion function is not provided.");
                        }
                    }

                    // Get the property names of the objects
                    var propertyNames = typeof(T).GetProperties().Select(p => p.Name).ToArray();
                    foreach (var propertyName in propertyNames)
                    {
                        Console.WriteLine(propertyName); // or do whatever you want with the property names
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    api_response_success = false;
                }
            }
            catch (Exception ex)
            {
                api_response_success = false;
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        internal static DataTable ConvertToDataTable<T>(IEnumerable<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }

            return table;
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
                    api_response_success = true;
                    if (gcont != null)
                    {
                        await LoadData<T>(endpoint, gcont);
                    }
                }
                else if (response.StatusCode == HttpStatusCode.BadRequest)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Failed to insert data into the database: " + errorMessage);
                    api_response_success = false;
                }
                else
                {
                    MessageBox.Show("Failed to insert data into the database.");
                    api_response_success = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                api_response_success = false;
            }
        }


        internal static async Task ModifyActiveField(string endpoint, string fieldName, string fieldValue, string id = null, bool deactivate = false,string offercode = null)
        {
            try
            {
                string requestEndpoint;
                if (id != null)
                {
                    requestEndpoint = $"{endpoint}/{id}/{deactivate}";
                }
                else
                {
                    requestEndpoint = $"{endpoint}/{offercode}/{deactivate}";
                }
                

                HttpResponseMessage response;
                if (deactivate)
                {
                    response = await client.PutAsync(baseUrl + requestEndpoint, null);
                }
                else
                {
                    // Construct the JSON payload to send in the request body
                    var payload = new Dictionary<string, string>
                    {
                        { fieldName, fieldValue }
                    };

                    // Convert the payload to JSON
                    string jsonPayload = JsonConvert.SerializeObject(payload);
                    Debug.WriteLine("JSON Payload: " + jsonPayload);

                    // Create the HTTP request
                    var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                    response = await client.PutAsync(baseUrl + requestEndpoint, content);
                }

                string responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("API Response: " + responseContent);

                if (response.IsSuccessStatusCode)
                {
                    
                    MessageBox.Show("Active field modified successfully.");
                    api_response_success = true;
                }
                else
                {
                    MessageBox.Show("Failed to modify active field.");
                    api_response_success = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                api_response_success = false;
            }
        }




        internal static async Task<int?> GetEntityId(string propertyName =null, string propertyValue = null, string idPropertyName= null, string endpoint=null, bool fullname = false, bool getroom = false)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    string value;
                    JArray data = JArray.Parse(jsonResponse);
                    if(propertyName != null)
                    {
                        foreach (JObject item in data)
                        {
                            value = item.GetValue(propertyName)?.ToString();

                            if (value == propertyValue)
                            {
                                Debug.WriteLine(Convert.ToInt32(item.GetValue(idPropertyName)));
                                api_response_success = true;
                                return Convert.ToInt32(item.GetValue(idPropertyName));
                            }
                        }
                    }
                    else if(fullname)
                    {
                        foreach (JObject item in data)
                        {
                            value = $"{item.GetValue("f_name")} {item.GetValue("m_name")} {item.GetValue("l_name")}";

                            if (value == propertyValue)
                            {
                                Debug.WriteLine(Convert.ToInt32(item.GetValue(idPropertyName)));
                                api_response_success = true;
                                return Convert.ToInt32(item.GetValue(idPropertyName));
                            }
                        }
                            
                    }
                    else if(getroom)
                    {
                        foreach (JObject item in data)
                        {
                            value = $"{item.GetValue("room_no")} {item.GetValue("floor_lvl")} {item.GetValue("building")}";

                            if (value == propertyValue)
                            {
                                Debug.WriteLine(Convert.ToInt32(item.GetValue(idPropertyName)));
                                api_response_success = true;
                                return Convert.ToInt32(item.GetValue(idPropertyName));
                            }
                        }
                    }

                    // Entity not found
                    Debug.WriteLine($"{propertyName} '{propertyValue}' not found");
                    api_response_success = false;
                    return null;
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    api_response_success = false;
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                api_response_success = false;
                return null;
            }
        }

        internal static async Task<List<int?>> GetMultipleEntityIds(string propertyName, string propertyValue, string idPropertyName, string endpoint)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine("API Response: " + jsonResponse);
                    JArray data = JArray.Parse(jsonResponse);
                    List<int?> entityIds = new List<int?>();

                    foreach (JObject item in data)
                    {
                        string value = item.GetValue(propertyName)?.ToString();

                        if (value == propertyValue)
                        {
                            Debug.WriteLine(Convert.ToInt32(item.GetValue(idPropertyName)));
                            api_response_success = true;
                            entityIds.Add(Convert.ToInt32(item.GetValue(idPropertyName)));
                        }
                    }

                    if (entityIds.Count == 0)
                    {
                        Debug.WriteLine($"{propertyName} '{propertyValue}' not found");
                        api_response_success = false;
                    }

                    return entityIds;
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    api_response_success = false;
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                api_response_success = false;
                return null;
            }
        }


        internal static async Task<string> GetEntityOfferCode(string propertyName = null, string propertyValue = null, string offerCodePropertyName = null, string endpoint = null)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    string value;
                    JArray data = JArray.Parse(jsonResponse);
                    if (propertyName != null)
                    {
                        foreach (JObject item in data)
                        {
                            value = item.GetValue(propertyName)?.ToString();

                            if (value == propertyValue)
                            {
                                Debug.WriteLine(item.GetValue(offerCodePropertyName)?.ToString());
                                api_response_success = true;
                                return item.GetValue(offerCodePropertyName)?.ToString();
                            }
                        }
                    }

                    // Entity not found
                    Debug.WriteLine($"{propertyName} '{propertyValue}' not found");
                    api_response_success = false;
                    return null;
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    api_response_success = false;
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                api_response_success = false;
                return null;
            }
        }

        internal static async Task<int> GetStudentId(string endpoint)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    JArray data = JArray.Parse(jsonResponse);

                    if (data.Count > 0)
                    {
                        // If there are existing students, return the ID of the first student
                        JObject latestStudent = (JObject)data.Last;
                        int studentId = (int)latestStudent["id"];
                        return studentId+1;
                    }
                    else
                    {
                        // If there are no existing students, return 1
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("Error: " + response.StatusCode);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return -1;
            }
        }


        internal static async Task ShowWaitFormAsync(UcGrid inst = null, DirectXForm frm = null, GridControl grid = null)
        {
          
            var waitForm = new WaitForm1(); // Replace YourWaitForm with the actual name of your wait form
            waitForm.Show();

            try
            {
                if(inst != null)
                {
                    inst.Enabled = false;
                   
                }
                if(frm != null)
                {
                    frm.Enabled = false;
                }
                if (grid != null)
                {
                    grid.Visible = false;
                   
                }
                await Task.Delay(2000);
            }
            finally
            {
                if (inst != null)
                {
                    inst.Enabled = true;
                }
                if (frm != null)
                {
                    frm.Enabled = true;
                }
                if (grid != null)
                {
                    grid.Visible = true;
              
                }
                
                // Close the wait form once the time is up
                waitForm.Close();
            }
        }

        internal static void SaveDataToJson(List<string> data, string filename)
        {
            string directory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Resources");

            // Create the directory if it doesn't exist
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string path = Path.Combine(directory, filename);
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(path, json);
        }


        internal static T LoadDataFromJson<T>(string filename)
        {
            string directory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string path = Path.Combine(directory, "Resources", filename);

            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                return JsonConvert.DeserializeObject<T>(json);
            }
            else
            {
                return default(T);
            }
        }

    }


}
