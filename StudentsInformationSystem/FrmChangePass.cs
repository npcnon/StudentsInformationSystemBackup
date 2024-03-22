using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmChangePass : DevExpress.XtraEditors.XtraForm
    {
        public FrmChangePass()
        {
            InitializeComponent();
            // Set the background image layout to stretch
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Load the login background image
            this.BackgroundImage = Properties.Resources.login_background;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
         
        }

        private void FrmChangePass_Load(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            //
        }
    }
}