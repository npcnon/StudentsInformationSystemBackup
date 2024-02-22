using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UCRooms : DevExpress.DXperience.Demos.TutorialControlBase// DevExpress.XtraEditors.XtraUserControl
    {

        private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";

        public UCRooms()
        {
            InitializeComponent();


        }

        private void btn_add_room_Click(object sender, EventArgs e)
        {
           
            string sqlInsert = @"
            INSERT INTO TblRoomInfo (building, floor_lvl, room_no) 
            VALUES (@Building, @FloorLevel, @RoomNumber);
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {

                    command.Parameters.AddWithValue("@Building",cbox_building.Text);
                    command.Parameters.AddWithValue("@FloorLevel", cbox_floorlvl.Text);
                    command.Parameters.AddWithValue("@RoomNumber", Convert.ToInt32(cbox_roomno.Text));
                  



                    connection.Open();


                    int rowsAffected = command.ExecuteNonQuery();


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

        private void UCRooms_Load(object sender, EventArgs e)
        {
            sisEntities2 db = new sisEntities2();
            tblRoomInfoBindingSource.DataSource = db.TblRoomInfoes.ToList();
        }

      
    }
}
