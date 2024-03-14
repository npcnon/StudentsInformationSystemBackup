using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmSplashScreen : SplashScreen
    {
        private Timer timer;

        public FrmSplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 7; // Set the interval to 3000 milliseconds (3 seconds)
            timer.Tick += Timer_Tick; // Attach the event handler for the Tick event
            timer.Start(); // Start the timer
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Close the splash screen form
            this.Close();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        // You can remove the FrmSplashScreen_Load event handler if it's not being used for any other purpose.
        private void FrmSplashScreen_Load(object sender, EventArgs e)
        {
            // No action needed here if using the timer to close the form
        }
    }
}
