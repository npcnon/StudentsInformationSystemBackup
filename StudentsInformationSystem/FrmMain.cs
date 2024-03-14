using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Navigation;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentsInformationSystem.UI.Modules;
using System.Linq;
using DevExpress.XtraWaitForm;
using DevExpress.XtraSplashScreen;
using System.Runtime.CompilerServices;
using DevExpress.Data.Browsing;
using DevExpress.XtraGrid;

namespace StudentsInformationSystem
{
    public partial class FrmMain : DevExpress.XtraEditors.DirectXForm
    {

        

        public delegate void MyFunctionDelegate();
        public static MyFunctionDelegate myFunction;
        bool acc_is_enable = true;
        

        
        public FrmMain()
        {
            InitializeComponent();
            UcGrid.exit_is_clicked += enable_disable_accordion;
            FrmLoading.load_done += loading_is_done;
           List<AccordionControlElement> ac_element = new List<AccordionControlElement>()
            {
                m_element_Staff,
                m_element_student,
                m_element_schedule,
                m_element_depart,
                m_element_users
            };

            foreach (AccordionControlElement ac in ac_element)
            {
                ac.Appearance.Default.BackColor = Color.FromArgb(41, 89, 151);
            }

        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            UcGrid.exit_is_clicked -= enable_disable_accordion;
        }
        private  void loading_is_done(object sender, EventArgs e)
        {

            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    Enabled = true;
                    TopMost = false;
                }));
            }
            else
            {
                Enabled = true;
                TopMost = false;
            }
            
        }
        public void enable_disable_accordion(object sender, EventArgs e)
        {
            if(acc_is_enable)
            {

                frm_main_acc_control.Enabled = false;
                frm_main_acc_control.OptionsMinimizing.State = AccordionControlState.Minimized;
                acc_is_enable = false;
            }
            else
            {

                frm_main_acc_control.Enabled = true;
                frm_main_acc_control.OptionsMinimizing.State = AccordionControlState.Normal;
                acc_is_enable = true;
            }
        }

        public void InvokeMyFunction()
        {
            myFunction?.Invoke();
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

        private async void FrmMain_LoadAsync(object sender, EventArgs e)
        {

            this.Enabled = false;
            UcGrid.firstload = true;
            ModulesInfo.Add(new ModuleInfo("UcGrid", "StudentsInformationSystem.UI.Modules.UcGrid"));
            await LoadModuleAsync(ModulesInfo.GetItem("UcGrid"));
            ModulesInfo.Add(new ModuleInfo("UcStartmenu", "StudentsInformationSystem.UI.Modules.UcStartmenu"));
            await LoadModuleAsync(ModulesInfo.GetItem("UcStartmenu"));

            
        }
        


        private async void s_element_addstdnt_Click_1(object sender, EventArgs e)
        {
            
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddStdnt"));
        }

        private async void s_element_rmstdnt_Click_1(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcRmStdnt") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcRmStdnt", "StudentsInformationSystem.UI.Modules.UcRmStdnt"));

                
            }
            await LoadModuleAsync(ModulesInfo.GetItem("UcRmStdnt"));
        }


        private async void s_element_addtcher_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddTcher") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddTcher", "StudentsInformationSystem.UI.Modules.UcAddTcher"));


            }
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddTcher"));
        }

        private async void s_element_addsched_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddSchedule") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddSchedule", "StudentsInformationSystem.UI.Modules.UcAddSchedule"));


            }
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddSchedule"));
        }

        private async void s_element_add_user_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddUser") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddUser", "StudentsInformationSystem.UI.Modules.UcAddUser"));


            }
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddUser"));
        }

        private async void s_element_checksched_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddSchedule") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddSchedule", "StudentsInformationSystem.UI.Modules.UcAddSchedule"));

            }

            await LoadModuleAsync(ModulesInfo.GetItem("UcAddSchedule"));
        }

        private async void s_element_room_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UCRooms") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UCRooms", "StudentsInformationSystem.UI.Modules.UCRooms"));
               

            }
            await LoadModuleAsync(ModulesInfo.GetItem("UCRooms"));
        }

        private void m_element_depart_Click(object sender, EventArgs e)
        {

        }

        private async void s_element_subjects_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddSubj") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddSubj", "StudentsInformationSystem.UI.Modules.UcAddSubj"));


            }
            await LoadModuleAsync(ModulesInfo.GetItem("UcAddSubj"));
        }

        private async void s_element_departments_Click(object sender, EventArgs e)
        {
            enable_disable_accordion(sender,e);
            UcGrid.endpoint = FrmAddDepartment.endpoint;
            UcGrid.modifyendpoint = "api/deactivate_department";
            UcGrid ucGridInstance = new UcGrid();
            UcGrid.title = "Department";
            // Retrieve UcGrid instance
            ucGridInstance = (UcGrid)frm_main_container.Controls.Find("UcGrid", true).FirstOrDefault();
            FrmAddDepartment adddep = new FrmAddDepartment();
            UcGrid.frm = adddep;
            UcGrid.myinstance = ucGridInstance;
            // After loading the module, call initload
            myFunction = () => UcGrid.initload<Department>();
            // Invoke the delegate
            myFunction.Invoke();
            await LoadModuleAsync(ModulesInfo.GetItem("UcGrid"));
         
        }








        private async void s_element_course_Click(object sender, EventArgs e)
        {
            enable_disable_accordion(sender, e);
            UcGrid.endpoint = FrmAddDepartment.endpoint;
            UcGrid.modifyendpoint = "api/deactivate_course";
            UcGrid ucGridInstance = new UcGrid();
            UcGrid.title = "Department";
            // Retrieve UcGrid instance
            ucGridInstance = (UcGrid)frm_main_container.Controls.Find("UcGrid", true).FirstOrDefault();
            FrmAddDepartment adddep = new FrmAddDepartment();
            UcGrid.frm = adddep;
            UcGrid.myinstance = ucGridInstance;
            // After loading the module, call initload
            myFunction = () => UcGrid.initload<Department>();
            // Invoke the delegate
            myFunction.Invoke();
            await LoadModuleAsync(ModulesInfo.GetItem("UcGrid"));
        }
        
        private void log_out_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fluentDesignFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Running");
            frm_main_acc_control.ExpandAll();

            Debug.WriteLine(frm_main_acc_control.ExpandAll());
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Running");
            frm_main_acc_control.CollapseAll();
        }

        private void m_element_depart_Click_1(object sender, EventArgs e)
        {

        }
    }
}