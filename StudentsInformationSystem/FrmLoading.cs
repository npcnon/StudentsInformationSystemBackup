using DevExpress.XtraEditors;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem
{
    public partial class FrmLoading : DevExpress.XtraEditors.DirectXForm
    {
        public static event EventHandler load_done;

        public FrmLoading()
        {
            InitializeComponent();
            StartTimer();
        }

        protected virtual void OnLoadDone(EventArgs e)
        {
            load_done?.Invoke(this, e);
        }

        private void StartTimer()
        {
            Task.Delay(5000).ContinueWith(task =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        Close();
                        OnLoadDone(EventArgs.Empty);
                    }));
                }
                else
                {
                    Close();
                    OnLoadDone(EventArgs.Empty);
                }
            });
        }

        private void FrmLoading_Load(object sender, EventArgs e)
        {
            
        }
    }
}
