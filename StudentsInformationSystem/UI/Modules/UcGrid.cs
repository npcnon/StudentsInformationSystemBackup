using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class UcGrid : DevExpress.DXperience.Demos.TutorialControlBase
    {
        public static event EventHandler exit_is_clicked;
        public static UcGrid gridcont;
        public static string endpoint;
        public static string modifyendpoint;
        private static object class_reference;
        public UcGrid()
        {
            
       

        InitializeComponent();
            DoubleBuffered = true;
            

        }
        protected virtual void exitisclicked(EventArgs e)
        {
            exit_is_clicked?.Invoke(this, e);
        }
       

        private async void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "New":
                    FrmAddDepartment adddep = new FrmAddDepartment();
                    adddep.ShowDialog();

                    break;
                case "Edit":
                    gridView.OptionsBehavior.Editable = true;
                    gridView.Columns["id"].OptionsColumn.ReadOnly = true;
                    gridView.Columns["id"].OptionsColumn.AllowEdit = false;
                    break;

                case "Delete":
                    // Get the selected row data
                    DataRowView selectedRowToDelete = (DataRowView)gridView.GetFocusedRow();
                    if (selectedRowToDelete != null)
                    {
                        // Assuming the ID of the row to delete is in the "id" column
                        int idToDelete = Convert.ToInt32(selectedRowToDelete["id"]);
                        // Call the function to delete the row
                        await functions.ModifyActiveField(modifyendpoint, selectedRowToDelete.Row, true);
                        (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                        // After deleting, refresh the grid to reflect the changes
                        //load();
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    break;
                case "Refresh":
                    // Refresh the grid to reload the data from the database
                    gridView.OptionsBehavior.Editable = false;
                    (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    break;

                case "Exit":
                    exitisclicked(EventArgs.Empty);
                    break;
                default:
                    MessageBox.Show("An Error occurred.");
                    break;
            }
        }
     
        public static async void initload<T>(UcGrid grid) where T : class
        {
            
            class_reference = Activator.CreateInstance<T>();
            await functions.ShowWaitFormAsync();
            await functions.LoadData<T>(endpoint, grid.gridcont_department);
            
        }
        
        private void UcGrid_Load(object sender, EventArgs e)
        {
            exitisclicked(EventArgs.Empty);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            gridView.OptionsBehavior.Editable = false;
        }
        
        private async void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Get the modified row
            DataRow modifiedRow = gridView.GetDataRow(e.RowHandle);
            if (modifiedRow != null)
            {
                // Assuming the ID of the row to update is in the "id" column
                int idToUpdate = Convert.ToInt32(modifiedRow["id"]);
                await functions.ModifyActiveField(endpoint, modifiedRow, false);
                //await functions.LoadData<class_reference>(endpoint, gridcont_department);
                (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
            }
        }
    }

    
}
