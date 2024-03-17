using DevExpress.XtraEditors;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public FrmAddRoom()
        {
            InitializeComponent();
        }


        private void FrmAddRoom_Load(object sender, EventArgs e)
        {
            if (building != null && building.Count > 0)
            {
                cbox_building.Properties.Items.AddRange(building);
            }
            else if (floor_lvl != null && floor_lvl.Count > 0)
            {
                
            }
        }

        private void btn_save_building_Click(object sender, EventArgs e)
        {
            string build = cbox_building.Text;
            building.Add(build);
            FrmAddRoom_Load(sender, e);
            cbox_building.SelectedItem = build;
        }

        private void btn_save_floor_Click(object sender, EventArgs e)
        {
            string flr = cbox_building.Text;
            floor_lvl.Add(flr);
            FrmAddRoom_Load(sender, e);
            cbox_building.SelectedItem = flr;
        }

        private void btn_delete_building_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in the combobox
            if (cbox_building.SelectedIndex >= 0)
            {
                // Remove the selected item from the combobox
                cbox_building.Properties.Items.RemoveAt(cbox_building.SelectedIndex);

                // Remove the corresponding item from the 'building' list
                building.RemoveAt(cbox_building.SelectedIndex);
            }
            else
            {
                // Show a message to indicate that no item is selected
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_delete_floor_Click(object sender, EventArgs e)
        {
            if (cbox_floor.SelectedIndex >= 0)
            {
                // Remove the selected item from the combobox
                cbox_floor.Properties.Items.RemoveAt(cbox_floor.SelectedIndex);

                // Remove the corresponding item from the 'building' list
                floor_lvl.RemoveAt(cbox_floor.SelectedIndex);
            }
            else
            {
                // Show a message to indicate that no item is selected
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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