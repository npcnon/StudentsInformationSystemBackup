using DevExpress.XtraEditors;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmAddRoom : DevExpress.XtraEditors.DirectXForm
    {
        List<string> building = new List<string>();
        List<string> floor_lvl = new List<string>();
        internal const string endpoint = "api/room/";
        public FrmAddRoom()
        {
            InitializeComponent();
        }


        private void FrmAddRoom_Load(object sender, EventArgs e)
        {
            building.Clear();
            floor_lvl.Clear();
            building = functions.LoadDataFromJson<List<string>>("building.json") ?? new List<string>();
            floor_lvl = functions.LoadDataFromJson<List<string>>("floor_lvl.json") ?? new List<string>();

            if (building.Count > 0)
            {
                cbox_building.Properties.Items.Clear();
                cbox_building.Properties.Items.AddRange(building);
            }

            if (floor_lvl.Count > 0)
            {
                cbox_floor.Properties.Items.Clear();
                cbox_floor.Properties.Items.AddRange(floor_lvl);
            }
        }


        private void btn_save_building_Click(object sender, EventArgs e)
        {
            string build = cbox_building.Text;
            if (!building.Contains(build))
            {
                building.Add(build);
                functions.SaveDataToJson(building, "building.json"); // Save 'building' list to JSON file
                FrmAddRoom_Load(sender, e);
                cbox_building.SelectedItem = build;
                cbox_building.ShowPopup();
            }
            else
            {
                MessageBox.Show("Building already exists in the list.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_floor_Click(object sender, EventArgs e)
        {
            string flr = cbox_floor.Text;
            if (!floor_lvl.Contains(flr))
            {
                floor_lvl.Add(flr);
                functions.SaveDataToJson(floor_lvl, "floor_lvl.json"); // Save 'floor_lvl' list to JSON file
                FrmAddRoom_Load(sender, e);
                cbox_floor.SelectedItem = flr;
                cbox_floor.ShowPopup();
            }
            else
            {
                MessageBox.Show("Floor already exists in the list.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_delete_building_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the combobox
            if (cbox_building.SelectedItem != null)
            {
                // Remove the selected item from the combobox
                var selectedItem = cbox_building.SelectedItem.ToString();

                // Check if the selected item exists in the 'building' list
                if (building.Contains(selectedItem))
                {
                    cbox_building.Properties.Items.Remove(selectedItem);
                    building.Remove(selectedItem);
                    MessageBox.Show("Building was Deleted Successfully!");

                    // Save the updated 'building' list to the JSON file
                    functions.SaveDataToJson(building, "building.json");
                }
                else
                {
                    // Show a message indicating that the building is not in the list
                    MessageBox.Show("Building is not in the list.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show a message to indicate that no item is selected
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cbox_building.ShowPopup();
        }

        private void btn_delete_floor_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the combobox
            if (cbox_floor.SelectedItem != null)
            {
                // Remove the selected item from the combobox
                var selectedItem = cbox_floor.SelectedItem.ToString();

                // Check if the selected item exists in the 'floor_lvl' list
                if (floor_lvl.Contains(selectedItem))
                {
                    cbox_floor.Properties.Items.Remove(selectedItem);
                    floor_lvl.Remove(selectedItem);
                    MessageBox.Show("Floor was Deleted Successfully!");

                    // Save the updated 'floor_lvl' list to the JSON file
                    functions.SaveDataToJson(floor_lvl, "floor_lvl.json");
                }
                else
                {
                    // Show a message indicating that the floor is not in the list
                    MessageBox.Show("Floor is not in the list.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // Show a message to indicate that no item is selected
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cbox_floor.ShowPopup();
        }



        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                var room = new Room
                {
                    building = cbox_building.Text,
                    floor_lvl = cbox_floor.Text,
                    room_no = Convert.ToInt32(txt_room.Text),
                };
                await functions.InsertData(room, endpoint);

                // Raise the custom event when the "Save" button is clicked

                txt_room.Clear();
                if (functions.api_response_success)
                {
                    (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    Enabled = false;
                    await Task.Delay(2000);
                    Enabled = true;
                }

            }
            catch (ArgumentException ex_argument)
            {
                MessageBox.Show(ex_argument.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_room.Clear(); 
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    internal class Room
    {
        private string _floor_lvl;
        private string _building;
        private int? _room_no;
        public int id { get; set; }
        public int? room_no
        {
            get => _room_no;
            set => _room_no = value;
        }

        public string floor_lvl
        {
            get => _floor_lvl;
            set => _floor_lvl = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }

        public string building
        {
            get => _building;
            set => _building = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Building cannot be null");

        }




    }
}