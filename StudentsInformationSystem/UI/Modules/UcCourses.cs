using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcCourses : DevExpress.DXperience.Demos.TutorialControlBase
    {

        string endpoint = "api/rooms/";
        private HttpClient client;


        public UcCourses()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        private async void UcCourses_Load(object sender, EventArgs e)
        {
            await functions.LoadData<Course>(gcont_course, endpoint);
        }
    }

    internal class Course
    {
        private string _course;
        private string _department_id;



        public string course
        {
            get => _course;
            set => _course = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }

        public string department_id
        {
            get => _department_id;
            set => _department_id = !string.IsNullOrWhiteSpace(value) ? value : throw new ArgumentException("Floor cannot be null");
        }
    }

}

