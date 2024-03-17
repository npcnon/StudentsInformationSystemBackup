    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
using System.Net;
using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace StudentsInformationSystem.UI.Modules
    {
        public partial class FrmAddSubj : DevExpress.XtraEditors.DirectXForm
        {
            internal const string endpoint = "api/subject/";
            internal Subject subject = new Subject();
            List<TextEdit> txtcontrolList = new List<TextEdit>();
            public FrmAddSubj()
            {
                InitializeComponent();
                txtcontrolList.AddRange(new[] { txt_description, txt_offercode, txt_subjcode, txt_unit });

            }

            private void btn_cancel_Click(object sender, EventArgs e)
            {
                Close();
            }

            private void btn_clear_Click(object sender, EventArgs e)
            {
            
                foreach (TextEdit txt in txtcontrolList)
                {
                    txt.Clear();
                }
                cbox_course.SelectedIndex = -1;
            }

            private async void FrmAddSubj_Load(object sender, EventArgs e)
            {
                cbox_course.Properties.Items.Clear();
                await functions.LoadData<Course>(FrmAddCourse.endpoint, null, cbox_course, d => d.course);
            }

            private async void cbox_course_SelectedIndexChanged(object sender, EventArgs e)
            {
                int? course_id = await functions.GetEntityId("course", cbox_course.Text, "id", FrmAddCourse.endpoint);
                if(course_id != null)
                {
                    subject.course_id = course_id;
                }
            }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            try
            {

                subject.Description = txt_description.Text;
                subject.unit = Convert.ToInt32(txt_unit.Text);
                subject.offercode = txt_offercode.Text;
                subject.subject_code = txt_subjcode.Text;

                await functions.InsertData(subject, endpoint);
                foreach (TextEdit txt in txtcontrolList)
                {
                    txt.Clear();
                }

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


    public class Subject
        {
            private string _offercode;
            private string _description;
            private string _subject_code;
            private int? _unit;
            private int? _course_id;
            private bool _active;


            public string offercode
            {
                get => _offercode;
                set => _offercode = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Offercode cannot be null");
            }

            public string Description
            {
                get => _description;
                set => _description = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Description cannot be null");
            }
            public string subject_code
            {
                get => _subject_code;
                set => _subject_code = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Error: Subject Code cannot be null");
            }

            public int? unit
            {
                get => _unit;
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentException("Error: unit cannot be null");
                    }
                    _unit = value;
                }
            }
            public int? course_id
            {
                get => _course_id;
                set => _course_id = value;
            }

            public bool active
            {
                get => _active;
                set => _active = value;
            }
        }
    }