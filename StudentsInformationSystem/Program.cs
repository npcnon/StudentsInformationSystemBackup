using StudentsInformationSystem.UI.Modules;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the FrmMain form on a separate thread
            Task.Run(() =>
            {
                // Start the FrmLoading form
                Application.Run(new FrmLoading());

            });

            FrmMain frmMain = new FrmMain();

            Application.Run(frmMain);
            //Application.Run(new FrmAddSchedule());
        }
    }
}
