using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsInformationSystem.UI.Modules
{
    public partial class FrmDepartmentGrid : XtraForm
    {

        public static string endpoint = "api/deactivate_department";
        public FrmDepartmentGrid()
        {
            InitializeComponent();


        }
        private async void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
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
                        //await functions.ModifyActiveField(endpoint, selectedRowToDelete.Row, true);
                        // After deleting, refresh the grid to reflect the changes
                        await functions.LoadData<Department>(UcDepartment.endpoint, gridcont_department);
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    break;
                case "Refresh":
                    // Refresh the grid to reload the data from the database
                    gridView.OptionsBehavior.Editable = false;
                    await functions.LoadData<Department>(UcDepartment.endpoint, gridcont_department);
                    break;
                default:
                    MessageBox.Show("An Error occurred.");
                    break;
            }
        }


        private async void FrmDepartmentGrid_Load(object sender, EventArgs e)
        {
            await functions.LoadData<Department>(UcDepartment.endpoint, gridcont_department);
            gridView.OptionsBehavior.Editable = false;

        }

        private async void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Get the modified row
            DataRow modifiedRow = gridView.GetDataRow(e.RowHandle);
            if (modifiedRow != null)
            {
                // Access the updated values directly from the modified row
                Debug.WriteLine("Modified department value: " + modifiedRow["department"]);
                // Assuming the ID of the row to update is in the "id" column
                int idToUpdate = Convert.ToInt32(modifiedRow["id"]);
                //await functions.ModifyActiveField(endpoint, modifiedRow, false);
                await functions.LoadData<Department>(UcDepartment.endpoint, gridcont_department);
            }
        }

    }
}
