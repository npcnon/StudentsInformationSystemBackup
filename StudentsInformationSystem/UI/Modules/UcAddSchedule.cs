using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcAddSchedule : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {

        private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";

        public UcAddSchedule()
        {
            InitializeComponent();
        }

        private void UcAddSchedule_Load(object sender, System.EventArgs e)
        {
            functions.loaditem(cbox_room_details, "room_id", "TblRoomInfo","--Select Room ID--");
            functions.loaditem(cbox_teacher, "teacher_Id", "TblTeacherInfo", "--Select Teacher ID--");
            functions.loaditem(cbox_subject, "offercode", "TblSubjInfo", "--Select Offercode--");
        }

        private void btn_submit_Click(object sender, System.EventArgs e)
        {
            string sqlInsert = @"
            INSERT INTO TblSchedule (class_day, class_hour, teacher_id, offercode, room_id) 
            VALUES (@classDay, @classHour, @teacherId, @Offercode, @roomId);
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {

                    command.Parameters.AddWithValue("@classDay", cbox_class_day.Text);
                    command.Parameters.AddWithValue("@classHour", cbox_hr_start.Text + " - " +cbox_hr_end.Text);
                    command.Parameters.AddWithValue("@teacherId", cbox_teacher.Text);
                    command.Parameters.AddWithValue("@Offercode", cbox_subject.Text);
                    command.Parameters.AddWithValue("@roomId", cbox_room_details.Text);



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
    }
}
