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
using System.Text.RegularExpressions;
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
                        try
                        {
                            string idToDelete = selectedRowToDelete["id"].ToString();
                            // Call the new ModifyActiveField method
                            await functions.ModifyActiveField(modifyendpoint, "id", idToDelete, idToDelete, true);

                        }
                        catch (Exception argex)
                        {
                            Debug.WriteLine($"Error Catched: {argex}");
                            string offercode_to_delete = selectedRowToDelete["offercode"].ToString();
                            // Call the new ModifyActiveField method
                            await functions.ModifyActiveField(modifyendpoint, "offercode", offercode_to_delete, offercode_to_delete, true);
                        }
                        finally
                        {
                            (Application.OpenForms["FrmMain"] as FrmMain)?.InvokeMyFunction();
                        }
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
            if(myinstance.gview_general.RowCount == 0)
            {
                MessageBox.Show("Table is Empty, Please add some data.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }



        private void UcGrid_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            gview_general.OptionsBehavior.Editable = false;

            BackgroundImage = Properties.Resources.background__1_;
        }

        private async void gridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            // Get the modified row
            DataRow modifiedRow = gview_general.GetDataRow(e.RowHandle);
            if (modifiedRow != null)
            {
                try
                {
                    string idToUpdate = modifiedRow["id"].ToString();
                    string modifiedValue = modifiedRow[e.Column.FieldName].ToString();

                    // Check if the modified field is an email or contact info
                    if (e.Column.FieldName == "email" || e.Column.FieldName == "contact_info")
                    {
                        // Validate the modified value
                        if (e.Column.FieldName == "email" && !Regex.IsMatch(modifiedValue, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
                        {
                            MessageBox.Show("Invalid Email.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        else if (e.Column.FieldName == "contact_info" && !Regex.IsMatch(modifiedValue, @"^\d{11}$"))
                        {
                            MessageBox.Show("Invalid Contact Info.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Modify the active field
                    await functions.ModifyActiveField(modifyendpoint, e.Column.FieldName, modifiedValue, idToUpdate, false);
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
        }

    }
}

    

