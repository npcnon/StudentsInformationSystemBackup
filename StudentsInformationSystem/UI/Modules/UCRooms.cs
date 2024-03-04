using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UCRooms : DevExpress.DXperience.Demos.TutorialControlBase
    {
        private string baseUrl = "https://afknon.pythonanywhere.com/";
        private HttpClient client;

        public UCRooms()
        {
            InitializeComponent();
            client = new HttpClient();
        }

        private async Task LoadRoomData()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(baseUrl + "api/rooms/");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var rooms = JsonConvert.DeserializeObject<Room[]>(jsonResponse);
                    tblRoomInfoBindingSource.DataSource = rooms;
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

        private async void UCRooms_Load(object sender, EventArgs e)
        {
            await LoadRoomData();
        }

        private async void btn_add_room_Click_1(object sender, EventArgs e)
        {
            try
            {
                var room = new Room
                {
                    building = cbox_building.Text,
                    floor_lvl = cbox_floorlvl.Text,
                    room_no = Convert.ToInt32(cbox_roomno.Text)
                };

                string json = JsonConvert.SerializeObject(room);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(baseUrl + "api/rooms/", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Data inserted successfully into the database.");
                    await LoadRoomData();
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

    public class Room
    {
        public string building { get; set; }
        public string floor_lvl { get; set; }
        public int room_no { get; set; }
    }
}
