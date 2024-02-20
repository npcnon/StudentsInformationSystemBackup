using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private List<Control> controlList;
        private bool datavalid;
        private string connectionString = "Data Source=DESKTOP-9GA3LFJ\\SQLEXPRESS;Initial Catalog=sis;Integrated Security=True;\r\n";
        public UcAddStdnt()
        {
            InitializeComponent();
        }

        private void UcAddStdnt_Load(object sender, EventArgs e)
        {
            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();

            controlList = new List<Control>
            {
                txt_fname,
                txt_mname,
                txt_lname,
                dedit_bday,
                cbox_gender,
                cbox_civil_status,
                txt_address,
                txt_contact_info,
                txt_email,
                cbox_course,
                cbox_department,
                cbox_year_lvl,
            };

            //added keypress event handler
            for (int i = 0; i < 11; i++)
            {
                controlList[i].KeyDown += control_keypress;
            }
            txt_fname.Focus();
            string sqlQuery = "SELECT MAX(stdnt_id)+1 FROM TblStdntInfo";
            functions.LoadID(txt_id, sqlQuery);
           
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
                    for (int i = 0; i < 11; i++)
                    {
                        if (controlName == controlList[i].Name)
                        {
                            controlList[i + 1].Focus();
                            Debug.Write(controlList[i].Name , "\n was entered");
                        }

                    }
                }
            }
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

        private void btn_stdnt_cancel_Click(object sender, EventArgs e)
        {
            // Dispose the user control
            this.Dispose();
        }
    }
}
