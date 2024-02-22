using System;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmLogIn : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogIn()
        {
            InitializeComponent();

            // Set the background image layout to stretch
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Load the login background image
            this.BackgroundImage = Properties.Resources.login_background;

            //txt_username.Enter += TextBox_GotFocus;
            //txt_username.Leave += TextBox_LostFocus;


        }



        private void FrmLogIn_Load(object sender, EventArgs e)
        {

            if (functions.ChckAdmin())
            {
              
                toastNotificationsManager1.ShowNotification("a2a109c9-ec5f-48e6-853e-ba4ff9b9e23a");
            }
            // You can uncomment this code if you need to delay the form loading
            // for(int i = 0; i < 100; i++)
            // {
            //     Thread.Sleep(100);
            // }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();
            
        }
    }
}
