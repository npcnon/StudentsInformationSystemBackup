using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmLogIn : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogIn()
        {
            InitializeComponent();
        }

        private void FrmLogIn_Load(object sender, EventArgs e)
        {
        for(int i = 0; i <100; i++)
        {

                Thread.Sleep(100);
        }



        }

    }
}
