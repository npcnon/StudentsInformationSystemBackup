﻿using DevExpress.DXperience.Demos;
using DevExpress.Utils.Extensions;
using DevExpress.XtraBars.Navigation;
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

        public FrmMain()
        {
            InitializeComponent();
            //this.StartPosition = FormStartPosition.CenterScreen;
            //this.FormBorderStyle = FormBorderStyle.FixedSingle;
      

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

        private async void s_element_checksched_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcAddSchedule") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcAddSchedule", "StudentsInformationSystem.UI.Modules.UcAddSchedule"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddSchedule"));
            }
        }

        private async void s_element_room_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UCRooms") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UCRooms", "StudentsInformationSystem.UI.Modules.UCRooms"));

                await LoadModuleAsync(ModulesInfo.GetItem("UCRooms"));
            }
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

                await LoadModuleAsync(ModulesInfo.GetItem("UcAddSubj"));
            }
        }

        private async void s_element_departments_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcDepartment") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcDepartment", "StudentsInformationSystem.UI.Modules.UcDepartment"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcDepartment"));
            }
        }

        private async void s_element_course_Click(object sender, EventArgs e)
        {
            if (ModulesInfo.GetItem("UcCourses") == null)
            {
                Debug.Write("aksksdl;knsdl;kadklajsdjas;jda");
                ModulesInfo.Add(new ModuleInfo("UcCourses", "StudentsInformationSystem.UI.Modules.UcCourses"));

                await LoadModuleAsync(ModulesInfo.GetItem("UcCourses"));
            }
        }

        private void m_element_Staff_Click(object sender, EventArgs e)
        {

        }
    }
}
