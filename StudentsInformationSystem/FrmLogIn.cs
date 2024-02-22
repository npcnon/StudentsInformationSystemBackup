using System;
using System.Threading;
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

            this.StartPosition = FormStartPosition.CenterScreen;
         
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }



        private void FrmLogIn_Load(object sender, EventArgs e)
        {
          
             for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(30);
            }
            
             txt_username.KeyDown += control_keypress;
            txt_password.KeyDown += control_keypress;
            btn_signin.KeyDown += control_keypress;
        }

        private void control_keypress(object sender, KeyEventArgs e)
        {
            Control control = sender as Control; // Cast sender to Control

            if (control != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Check the name of the control that triggered the event
                  if(control.Name == "txt_username") 
                  { txt_password.Focus(); }
                  else if(control.Name == "txt_password")
                  { btn_signin.Focus(); }
                  else if(control.Name == "btn_signin")
                  {
                        this.Hide();
                        FrmMain frmMain = new FrmMain();
                        frmMain.ShowDialog();
                  }
                  else
                  {
                        MessageBox.Show("Keypress Input Error");
                    }
                }
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();

        }

        private void txt_username_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
