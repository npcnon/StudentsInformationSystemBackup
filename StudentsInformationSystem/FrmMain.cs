using DevExpress.DXperience.Demos;
using DevExpress.Utils.Extensions;
using System;
using System.Diagnostics;
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
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
      

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

            if (functions.ChckAdmin())
            {
                //FrmChangePass frmChangePass = new FrmChangePass();
                //frmChangePass.ShowDialog();
            }
            m_element_Staff.Expanded = false;
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

        private async void s_element_addsched_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddSchedule") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddSchedule", "StudentsInformationSystem.UI.Modules.UcAddSchedule"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddSchedule"));
            }
        }

        private async void s_element_add_user_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddUser") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddUser", "StudentsInformationSystem.UI.Modules.UcAddUser"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddUser"));
            }
        }
    }
}
