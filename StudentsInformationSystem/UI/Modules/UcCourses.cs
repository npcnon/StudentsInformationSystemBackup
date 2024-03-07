using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcCourses : DevExpress.DXperience.Demos.TutorialControlBase
    {

        private string baseUrl = "https://afknon.pythonanywhere.com/";
        private HttpClient client;


        public UcCourses()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        private void UcCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
