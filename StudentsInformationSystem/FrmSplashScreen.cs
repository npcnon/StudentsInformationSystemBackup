using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmSplashScreen : SplashScreen
    {
        public FrmSplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
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
    }
}