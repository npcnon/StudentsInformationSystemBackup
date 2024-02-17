using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.FluentDesignSystem;
using DevExpress.XtraSplashScreen;
using StudentsInformationSystem.UI.Modules;
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

namespace StudentsInformationSystem
{
    public partial class FrmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        async Task LoadModuleAsync(ModuleInfo module)
        {
            await Task.Factory.StartNew(() =>
            {
                if (!frm_main_container.Controls.ContainsKey(module.Name))
                {
                    TutorialControlBase control = module.TModule as TutorialControlBase;
                    if (control != null)
                    {
                        control.Dock = DockStyle.Fill;
                        control.CreateWaitDialog();
                        frm_main_container.Invoke(new MethodInvoker(delegate ()
                        {
                            frm_main_container.Controls.Add(control);
                            control.BringToFront();
                        }));
                    }
                }
                else
                {
                   
                    var control = frm_main_container.Controls.Find(module.Name, true);
                    if (control.Length == 1)
                        frm_main_container.Invoke(new MethodInvoker(delegate () { control[0].BringToFront(); }));
                    Debug.Write("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
                }
            });
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

            splashScreenManager1.ShowWaitForm();
            Thread.Sleep(3000);
            splashScreenManager1.CloseWaitForm();

            m_element_teacher.Expanded = false;
            m_element_student.Expanded = false;
            m_element_schedule.Expanded = false;
            //frm_main_container.Controls.Add(new UcRmStdnt() { Dock = DockStyle.Fill });
        }



        private async void s_element_addstdnt_Click_1(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddStdnt") == null)
            {

                ModulesInfo.Add(new ModuleInfo("UcAddStdnt", "StudentsInformationSystem.UI.Modules.UcAddStdnt"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddStdnt"));
            }
        }

        private async void s_element_rmstdnt_Click_1(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcRmStdnt") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcRmStdnt", "StudentsInformationSystem.UI.Modules.UcRmStdnt"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcRmStdnt"));
            }
        }


        private async void s_element_addtcher_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddTcher") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddTcher", "StudentsInformationSystem.UI.Modules.UcAddTcher"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddTcher"));
            }
        }
    }
}
