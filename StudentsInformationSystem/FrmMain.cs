using DevExpress.DXperience.Demos;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
using StudentsInformationSystem.UI.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private Dictionary<string, TutorialControlBase> loadedControls = new Dictionary<string, TutorialControlBase>();
        public FrmMain()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
      

        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            if (module == null)
            {
                Debug.WriteLine("Module is null");
                return;
            }

            await Task.Run(() =>
            {
                TutorialControlBase control = module.TModule as TutorialControlBase;
                if (control != null)
                {
                    frm_main_container.Invoke(new MethodInvoker(() =>
                    {
                        if (!loadedControls.ContainsKey(module.Name))
                        {
                            control.Dock = DockStyle.Fill;
                            control.CreateWaitDialog();
                            frm_main_container.Controls.Add(control);
                            control.BringToFront();

                            // Add the control to the dictionary
                            loadedControls.Add(module.Name, control);
                        }
                        else
                        {
                            var existingControl = loadedControls[module.Name];
                            existingControl.BringToFront();
                            Debug.WriteLine("Control already loaded: " + module.Name);
                        }
                    }));
                }
                else
                {
                    Debug.WriteLine("Failed to load control: " + module.Name);
                }
            });
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {

            //splashScreenManager1.ShowWaitForm();
            //Thread.Sleep(3000);
            //splashScreenManager1.CloseWaitForm();

            //if (functions.ChckAdmin())
            //{
            //    //FrmChangePass frmChangePass = new FrmChangePass();
            //    //frmChangePass.ShowDialog();
            //}

            //frm_main_container.Controls.Add(new UcRmStdnt() { Dock = DockStyle.Fill });
            List<AccordionControlElement> ac_element = new List<AccordionControlElement>()
            {
                m_element_Staff,
                m_element_student,
                m_element_schedule,
                m_element_depart,
                m_element_users
            };
            foreach(AccordionControlElement ac in ac_element)
            {
                ac.Appearance.Default.BackColor = Color.FromArgb(41, 89, 151);
            }

            //WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            //frm_main_acc_control.ExpandAll();
            //frm_main_acc_control.Enabled = false;
            
        }


        private void DisposeControl(string controlName)
        {
           
            if (loadedControls.ContainsKey(controlName))
            {
                TutorialControlBase control = loadedControls[controlName];
                frm_main_container.Controls.Remove(control);
                control.Dispose();
                loadedControls.Remove(controlName);
            }
        }
        private void SubscribeToCancelButtonClickedEvent(UcAddTcher ucAddTcher)
        {
            // Subscribe to the CancelButtonClicked event of the UcAddTcher user control
            ucAddTcher.CancelButtonClicked += UcAddTcher_CancelButtonClicked;
        }
        private void UcAddTcher_CancelButtonClicked(object sender, EventArgs e)
        {
            // Method to handle the cancel button click event
            // This method will be called when the cancel button is clicked in UcAddTcher
            // You can perform any necessary actions here
            DisposeControl("UcAddTcher");
        }
        private async void s_element_addstdnt_Click_1(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddStdnt"));
        }

        private async void s_element_rmstdnt_Click_1(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcRmStdnt"));
        }


        private async void s_element_addtcher_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddTcher"));
        }

        private async void s_element_addsched_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddSchedule"));
        }

        private async void s_element_add_user_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddUser"));
        }

        private async void s_element_checksched_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem(""));
        }

        private async void s_element_room_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UCRooms"));
        }

      

        private async void s_element_subjects_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddSubj"));
        }

        private async void s_element_departments_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcDepartment"));
        }

        private async void s_element_course_Click(object sender, EventArgs e)
        {
            await LoadModuleAsync(ModulesInfo.GetItem("UcCourses"));
        }

       
    }
}
