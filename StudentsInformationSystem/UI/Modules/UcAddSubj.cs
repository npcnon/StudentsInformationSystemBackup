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
    public partial class UcAddSubj : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";

        public UcAddSubj()
        {
            InitializeComponent();
        }

        private void UcAddSubj_Load(object sender, EventArgs e)
        {
            txt_offercode.Focus();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string sqlInsert = @"
            INSERT INTO TblSubjInfo (offercode, Description, subject_code, unit) 
            VALUES (@Offercode, @Description, @Subject_code,@Unit);";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                using (SqlCommand command = new SqlCommand(sqlInsert, connection))
                {

                    command.Parameters.AddWithValue("@Offercode", txt_offercode.Text);
                    command.Parameters.AddWithValue("@Description", txt_description.Text);
                    command.Parameters.AddWithValue("@Subject_code", txt_subcode.Text);
                    command.Parameters.AddWithValue("@Unit", txt_unit.Text);

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
