using DevExpress.UIAutomation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmAddSchedule : DevExpress.XtraEditors.DirectXForm
    {
        internal const string endpoint = "api/schedule/";
        List<string> subjects = new List<string>();
        internal Schedule schedule = new Schedule();
        List<ComboBoxEdit> cboxcontrollist = new List<ComboBoxEdit>();
        public FrmAddSchedule()
        {
            InitializeComponent();
            cboxcontrollist.AddRange(new[] {cbox_day, cbox_start,cbox_end,cbox_staff,cbox_subject,cbox_room});
        }

        private async void FrmAddSchedule_Load(object sender, EventArgs e)
        {
            cbox_staff.Properties.Items.Clear();
            await functions.LoadData<Staff>(FrmAddStaff.endpoint, null, cbox_staff, d => $"{d.f_name} {d.m_name} {d.l_name}");
            cbox_subject.Enabled = false;
            
            cbox_room.Properties.Items.Clear();
            await functions.LoadData<Room>(FrmAddRoom.endpoint, null, cbox_room, d => $"{d.room_no} {d.floor_lvl} {d.building}");
            

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void cbox_staff_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int? staff_id = await functions.GetEntityId(null, cbox_staff.Text, "id", FrmAddStaff.endpoint, true);
                if (staff_id != null)
                {
                    Debug.WriteLine($"Staff id: {staff_id}");
                    schedule.staff = staff_id;
                }
                else
                {
                    MessageBox.Show($"Unable to find staff id for reference, id: {staff_id}");
                }


                cbox_subject.Properties.Items.Clear();
                cbox_subject.SelectedIndex = -1;
                subjects.Clear();
                // Get the selected staff's department ID
                int? staff_department_id = await functions.GetEntityId(null, cbox_staff.Text, "department_id", FrmAddStaff.endpoint, true);

                //get the id of the course filter the course id with the staff department it
                List<int?> course_id = await functions.GetMultipleEntityIds("department_Id", staff_department_id.ToString(), "id", FrmAddCourse.endpoint);

               
                if (staff_department_id.HasValue && course_id.Count > 0)
                {
                    Debug.WriteLine($"if is triggered - staff_department_id : {staff_department_id} course_id : {course_id}");
                    foreach (int? id in course_id)
                    {
                        // Construct the filter criteria based on the selected staff's department ID
                        string filterCriteria = $"course_id={id}";

                        // Load subjects based on the selected staff's department

                        await functions.LoadData<Subject>(FrmAddSubj.endpoint, null, cbox_subject, d => d.offercode, filterCriteria);
                        subjects.AddRange(cbox_subject.Properties.Items.Cast<string>());
                    }
                    cbox_subject.Properties.Items.Clear();
                    cbox_subject.Properties.Items.AddRange(subjects);
                    cbox_subject.Enabled = true;
                }
                else
                {
                    Debug.WriteLine($"else is triggered - staff_department_id : {staff_department_id} course_id : {course_id}");
                    MessageBox.Show("Unable Load Subjects");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void cbox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string subject_offercode = await functions.GetEntityOfferCode("offercode", cbox_subject.Text, "offercode", FrmAddSubj.endpoint);
                if(subject_offercode !=null)
                {
                    Debug.WriteLine($"OFfercode Detected: {subject_offercode}");
                    schedule.offercode = subject_offercode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void cbox_room_SelectedIndexChanged(object sender, EventArgs e)
        {
            int? room_id = await functions.GetEntityId(null, cbox_room.Text, "id", FrmAddRoom.endpoint, false, true);
            if(room_id.HasValue)
            {
                Debug.WriteLine($"room has value: {room_id} ");
                schedule.room = room_id;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Remove the event handler temporarily
            cbox_staff.SelectedIndexChanged -= cbox_staff_SelectedIndexChanged;
            cbox_subject.SelectedIndexChanged -= cbox_subject_SelectedIndexChanged;
            cbox_room.SelectedIndexChanged -= cbox_room_SelectedIndexChanged;

            // Clear all ComboBoxes
            foreach (ComboBoxEdit cbox in cboxcontrollist)
            {
                cbox.SelectedIndex = -1;
            }

            // Reattach the event handler
            cbox_staff.SelectedIndexChanged += cbox_staff_SelectedIndexChanged;
            cbox_subject.SelectedIndexChanged += cbox_subject_SelectedIndexChanged;
            cbox_room.SelectedIndexChanged += cbox_room_SelectedIndexChanged;
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                schedule.class_day = cbox_day.Text;
                schedule.class_hour = $"{cbox_start.Text} - {cbox_end.Text}";
                await functions.InsertData(schedule, endpoint);
                btn_clear_Click(sender, e);


                if (functions.api_response_success)
                {
                    (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    Enabled = false;
                    await Task.Delay(2000);
                    Enabled = true;
                }

            }
            catch (ArgumentException ex_argument)
            {
                MessageBox.Show(ex_argument.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }


    internal class Schedule
    {
        private string _class_day;
        private string _class_hour;
        private int? _staff;
        private string _offercode;
        private int? _room;
        private bool _active;
        private int _id;

        public string class_day
        {
            get => _class_day;
            set => _class_day = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Class Day cannot be null");
        }

        public string class_hour
        {
            get => _class_hour;
            set => _class_hour = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Invalid Class Hour");
        }

        public int? staff
        {
            get => _staff;
            set => _staff = value;
        }

        public string offercode
        {
            get => _offercode;
            set => _offercode = value;
        }
        
        public int? room
        {
            get => _room;
            set => _room = value;
        }

        public bool active
        {
            get => _active;
            set => _active = value;
        }
        public int id
        {
            get => _id;
            set => _id = value;
        }
    }
}