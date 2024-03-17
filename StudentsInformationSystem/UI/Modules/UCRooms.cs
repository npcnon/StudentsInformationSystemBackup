﻿using DevExpress.XtraEditors;
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
        internal const string endpoint = "api/rooms/";
     

        public UCRooms()
        {
            InitializeComponent();
           
        }

    

        private async void UCRooms_Load(object sender, EventArgs e)
        {
            await functions.LoadData<Room>(endpoint, gcont_room);
        }

        private async void btn_add_room_Click_1(object sender, EventArgs e)
        {
            try
            {
                var room = new Room
                {
                    floor_lvl = cbox_floorlvl.Text,
                    building = cbox_building.Text,
                    room_no = Convert.ToInt32(cbox_roomno.Text)
                };
                await functions.InsertData(room,endpoint, gcont_room);
            }
            catch (FormatException)
            {
                MessageBox.Show("Error: Room number cannot be null");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }
    }

    

}
