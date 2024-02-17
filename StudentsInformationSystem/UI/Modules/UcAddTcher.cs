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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcAddTcher : DevExpress.DXperience.Demos.TutorialControlBase//DevExpress.XtraEditors.XtraUserControl
    {
        private List<Control> controlList;

        public UcAddTcher()
        {
            InitializeComponent();
            
           
        }


        private void UcAddTcher_Load_1(object sender, EventArgs e)
        {
            tcher_fname.Focus();
            controlList = new List<Control>
            {
                tcher_id,
                tcher_fname,
                tcher_mname,
                tcher_lname,
                tcher_bd,
                tcher_gender,
                tcher_civil_stats,
                tcher_address,
                tcher_contact_info,
                tcher_email
            };
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();

            for(int i = 0;i<10;i++)
            {
                controlList[i].KeyDown += control_keypress;
            }
        }

        private void control_keypress(object sender, KeyEventArgs e)
        {
            Control control = sender as Control; // Cast sender to Control

            if (control != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Check the name of the control that triggered the event
                    string controlName = control.Name;

                    // Do something based on the name of the control
                    for(int i = 0;i <9;i++)
                    {
                        if(controlName == controlList[i].Name)
                        {
                            controlList[i+1].Focus();
                        }

                    }
                }
            }
        }


        private void stdnt_idTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}