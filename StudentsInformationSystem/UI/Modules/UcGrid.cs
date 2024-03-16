using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
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
        public static UcGrid myinstance;
        public static string endpoint;
        public static string modifyendpoint;
        public static string title;
        public static DirectXForm frm;
        public static bool firstload = false;
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
                    frm.ShowDialog();
                    break;
                case "Edit":

                    try
                    {
                        gview_general.OptionsBehavior.Editable = true;
                        gview_general.Columns["id"].OptionsColumn.ReadOnly = true;
                        gview_general.Columns["id"].OptionsColumn.AllowEdit = false;
                    }
                    catch(NullReferenceException nullex)
                    {
                        Debug.WriteLine($"Error Catched: {nullex}");
                        gview_general.Columns["offercode"].OptionsColumn.ReadOnly = true;
                        gview_general.Columns["offercode"].OptionsColumn.AllowEdit = false;
                    }
                  
                    break;

                case "Delete":
                    DataRowView selectedRowToDelete = (DataRowView)gview_general.GetFocusedRow();
                    if (selectedRowToDelete != null)
                    {
                        int idToDelete = Convert.ToInt32(selectedRowToDelete["id"]);
                        // Call the new ModifyActiveField method
                        await functions.ModifyActiveField(modifyendpoint, "id", idToDelete.ToString(), idToDelete, true);
                        (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    }
                    else
                    {
                        MessageBox.Show("Please select a row to delete.");
                    }
                    break;
                case "Refresh":
                    // Refresh the grid to reload the data from the database
                    gview_general.OptionsBehavior.Editable = false;
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

        public static async Task initload<T>() where T : class
        {
           
            myinstance.lbl_title.Text = title;
            await functions.ShowWaitFormAsync(myinstance, null, myinstance.gridcont_general);
            // Load data asynchronously
            await functions.LoadData<T>(endpoint, myinstance.gridcont_general);
            myinstance.gview_general.PopulateColumns();
        }



        private void UcGrid_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            gview_general.OptionsBehavior.Editable = false;
        }
    
        private async void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Get the modified row
            DataRow modifiedRow = gview_general.GetDataRow(e.RowHandle);
            if (modifiedRow != null)
            {
                try
                {
                    int idToUpdate = Convert.ToInt32(modifiedRow["id"]);
                    await functions.ModifyActiveField(modifyendpoint, e.Column.FieldName, modifiedRow[e.Column.FieldName].ToString(), idToUpdate, false);
                }
                catch (ArgumentException argex)
                {
                    Debug.WriteLine($"Error Catched: {argex}");
                    string offercode_to_update = modifiedRow["offercode"].ToString();
                    await functions.ModifyActiveField(modifyendpoint, e.Column.FieldName, modifiedRow[e.Column.FieldName].ToString(), null, false, offercode_to_update);
                }
                finally
                {
                    (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                    gview_general.OptionsBehavior.Editable = false;
                }
            }
                // Call the new ModifyActiveField method
               
        }
    }
}

    

