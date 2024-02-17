using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcAddStdnt : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        public UcAddStdnt()
        {
            InitializeComponent();
        }

        private void UcAddStdnt_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();
        }

        private void tabpane_addstdnt_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

    }
}
