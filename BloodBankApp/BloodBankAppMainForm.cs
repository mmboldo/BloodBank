using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BloodBankCodeFirstFromDB;
using EFControllerUtilities;
using System.Diagnostics;
using SeedDatabaseExtensions;


namespace BloodBankApp
{
    public partial class BloodBankAppMainForm : Form
    {
        public BloodBankAppMainForm()
        {
            InitializeComponent();
            this.Load += (s, e) => BloodBankAppMainForm_Load();
        }
        private void BloodBankAppMainForm_Load()
        {
            using (BloodBankEntities context = new BloodBankEntities())
            {
                context.SeedDatabase();
            }
            // common setup for datagridview controls
            //InitializeDataGridView<BloodDeposit>(dataGridView1, "UnitId" );
            //InitializeDataGridView<BloodType>(dataGridView2, "BloodTypeId");
            //InitializeDataGridView<BloodWithdrawal>(dataGridView3, "BloodWithdrawalId");
            //InitializeDataGridView<BloodWithdrawalUnit>(dataGridView4 ,"BloodWithdrawalUnitsId");
            //InitializeDataGridView<Client>(dataGridView5 ,"ClientId");
            //InitializeDataGridView<Donation>(dataGridView6 ,"DonationId");
            //InitializeDataGridView<Donor>(dataGridViewDonorsDatabase, "BloodTypes", "DonorId");      
            initializeDonorsDataGridView();           

            // search button on the main page
            buttonSearchDonor.Click += ButtonSearchDonor_Click;
            textBoxFirstName.TextChanged += TextBoxFirstName_TextChanged;

            DonorAddForm donorAddForm = new DonorAddForm();
            buttonAddNewDonor.Click += (s, e) => AddOrUpdateForm<Donor>(dataGridViewDonorsDatabase, donorAddForm);

            BloodBankStatusForm bbStatForm = new BloodBankStatusForm();
            buttonBloodBank.Click += (s, e) => AddOrUpdateForm<BloodBankEntities>(null, bbStatForm);

            WithdrawalForm withdraw = new WithdrawalForm();
            buttonWithdrawBlood.Click += (s, e) => AddOrUpdateForm<BloodWithdrawal>(dataGridViewDonorsDatabase, withdraw);

            //Searching the donor through textboxes
            buttonReset.Click += ButtonReset_Click;
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            dataGridViewSelectedDonors.Columns.Clear();
        }

        private void TextBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            BloodBankEntities bloodBankEntities = new BloodBankEntities();

            //BindingSource bindingSource = new BindingSource();
            //bindingSource.DataSource = dataGridViewDonors.DataSource;
            //bindingSource.Filter = "DonorFirstName like '" + textBoxFirstName.Text + "%'";
            dataGridViewSelectedDonors.DataSource = bloodBankEntities.Donors.Where(x => x.DonorFirstName
                                                    .Contains(textBoxFirstName.Text));
        }

        /// <summary>
        /// Initializes the Donor Database Data Grid View with the data from the tables Donor and Blood Type
        /// It reads from the contents of Donor and BloodType, instantiates a new DisplayDonor object and adds it to the 
        /// DisplayDonor list. 
        /// </summary>
        private void initializeDonorsDataGridView()
        {
                
                List<DisplayDonor> displayDonor = new List<DisplayDonor>();
                List<Donor> donors = Controller<BloodBankEntities, Donor>.GetEntitiesWithIncluded("BloodType").ToList();
                List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.GetEntitiesWithIncluded("Donors").ToList();

                foreach(Donor donor in donors)
                {
                    // Getting the string value of the Blood Type name (BloodType1)
                    string displayDonorBloodTypeName = "";
                    foreach (BloodType bloodType in bloodTypes)
                    {
                        if (bloodType.BloodTypeId == donor.BloodTypeId)
                        {
                            displayDonorBloodTypeName = bloodType.BloodType1;
                        }                            
                    }

                    // instantiate a DisplayDonor object and set its values to the ones from the DB
                    var completeDonor = new DisplayDonor()
                    {
                        displayDonorFirstName = donor.DonorFirstName,
                        displayDonorLastName = donor.DonorLastName,
                        displayDonorAddress = donor.DonorAddress,
                        displayDonorBirthday = donor.DonorBirthday.ToString(),
                        displayDonorPhoneNumber = donor.DonorPhone,
                        displayDonorBloodType = displayDonorBloodTypeName,
                    };
                    displayDonor.Add(completeDonor); // adding the new object to the list
                }
            dataGridViewDonorsDatabase.DataSource = displayDonor;
            dataGridViewDonorsDatabase.Columns[0].Width = 100;
            dataGridViewDonorsDatabase.Columns[1].Width = 100;
            dataGridViewDonorsDatabase.Columns[2].Width = 135;
            dataGridViewDonorsDatabase.Columns[3].Width = 70;
            dataGridViewDonorsDatabase.Columns[4].Width = 90;
            dataGridViewDonorsDatabase.Columns[5].Width = 80;
        }


        /// <summary>
        /// search donor with firstname, last name and date of birth
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSearchDonor_Click(object sender, EventArgs e)
        {// ==XX==XX== Button click to be used for searching donor by name and birth date

            if (dataGridViewDonorsDatabase.SelectedRows.Count == 0)
            {
                MessageBox.Show("");
                return;
            }
            else
            {
                DisplaySelectedDonors();
            }
        }

        private void DisplaySelectedDonors()
        {
                // ==XX==XX== DISPLAY selected donor on the Data Grid View. 
                // create dataset to store selected donors to display
                DataTable donorsColumns = new DataTable();
                donorsColumns.Columns.Add("DonorId");
                donorsColumns.Columns.Add("DonorFirstName");
                donorsColumns.Columns.Add("DonorLastName");
                donorsColumns.Columns.Add("DonorBirthday");
                donorsColumns.Columns.Add("DonorAddress");
                donorsColumns.Columns.Add("DonorPhone");
                donorsColumns.Columns.Add("BloodTypeId");

                foreach (DataGridViewRow dataGridViewRow in dataGridViewDonorsDatabase.SelectedRows)
                {
                    if (dataGridViewDonorsDatabase.SelectedRows.Count > 0)
                    {
                        donorsColumns.Rows.Add(dataGridViewRow.Cells[0].Value, dataGridViewRow.Cells[1].Value, dataGridViewRow.Cells[2].Value,
                        dataGridViewRow.Cells[3].Value, dataGridViewRow.Cells[4].Value,
                        dataGridViewRow.Cells[5].Value, dataGridViewRow.Cells[6].Value);
                    }
                }
                dataGridViewSelectedDonors.DataSource = donorsColumns; // add selected donors to the datagridview
        }

        /// <summary>
        /// Common generic method to initialize datagridview controls. Allows users to add and delete data,
        /// sets the datasource, autosizes the control to the columns.
        /// <para>
        /// A list of columns to hide is an optional parameter. No error checking is done on this.
        /// </para>
        /// <para>
        /// We could use a form to delete items, but easy to use gridview for this, so set up 
        /// UserDeletingRow event. If we use UserDeletedRow, it is already gone! We need to use
        /// UserDeletingRow because we can't simply do savechanges - the item needs to be explicitly
        /// deleted.
        /// </para>
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="gridView">DataGridView to be initialized</param>
        /// <param name="columnsToHide">Columns to be hidden in the DataGridView</param>
        private void InitializeDataGridView<T>(DataGridView gridView, params string[] columnsToHide) where T : class
        {
            // Allow users to add/delete rows, and fill out columns to the entire width of the control
            gridView.AllowUserToAddRows = false;

            gridView.AllowUserToDeleteRows = true;
            gridView.ReadOnly = true;
            gridView.MultiSelect = false;
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item. Note use of generics.
            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // probably not needed, but just in case we have some issues
            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            gridView.DataSource = Controller<BloodBankEntities, T>.SetBindingList();

            //foreach (string column in columnsToHide)
            //    gridView.Columns[column].Visible = false;
        }

        /// <summary>
        /// Handler to delete the selected row (item) from a gridview and update the DB.
        /// Update the gridview with the revised data from the DB, as well
        /// as the customer orders report gridview.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView used to delete the row</param>
        /// <param name="e"></param>
        private void DeletingRow<T>(DataGridView dataGridView, DataGridViewRowCancelEventArgs e) where T : class
        {
            // get the item
            T item = e.Row.DataBoundItem as T;

            Debug.WriteLine("DeletingRow " + e.Row.Index + " entity " + typeof(T) + " " + item);

            // Delete the item in the DB. No need to worry about dependencies, as there is no context!
            // Just let cascade delete take care of it.
            Controller<BloodBankEntities, T>.DeleteEntity(item);
            dataGridView.Refresh();

            // The Orders table always gets updated, this forces the update from the DB.
            // It will show the effect of cascade delete in the DB.

            //if (typeof(T) != typeof(Order))
            //{
            //    dataGridViewOrders.DataSource = Controller<AutoLotEntities, Order>.Set();
            //    dataGridViewOrders.Refresh();
            //}

            //// update the customer orders report

            //dataGridViewCustomerOrders.DataSource = Controller<AutoLotEntities, CustomerOrder>.GetEntitiesNoTracking();
            //dataGridViewCustomerOrders.Refresh();
        }

        /// <summary>
        /// Catch any gridview data error, log to debug and cancel any event.
        /// Should not happen, as all of our gridviews are readonly. Might show up when items
        /// are deleted.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        private void HandleDataError<T>(DataGridView gridView, DataGridViewDataErrorEventArgs e)
        {
            Debug.WriteLine("DataError " + typeof(T) + " " + gridView.Name + " row " + e.RowIndex + " col " + e.ColumnIndex + " Context: " + e.Context.ToString());
            e.Cancel = true;
        }

        /// <summary>
        /// Generic method to display a form and then update the relevant gridviews.
        /// </summary>
        /// <typeparam name="T">Data type associated with the gridview</typeparam>
        /// <param name="dataGridView">DataGridView to be updated with new data from DB</param>
        /// <param name="form"></param>
        private void AddOrUpdateForm<T>(DataGridView dataGridView, Form form) where T : class
        {
            var result = form.ShowDialog();

            // form has closed
            if (result == DialogResult.OK)
            {
                // reload the db and update the gridview
                dataGridView.DataSource = Controller<BloodBankEntities, T>.SetBindingList();

                // update the customer orders report
                //dataGridViewCustomerOrders.DataSource = Controller<BloodBankEntities, CustomerOrder>.GetEntitiesNoTracking();
                //dataGridViewCustomerOrders.Refresh();
            }

            // do not close, as the form object will be disposed, 
            // just hide the form (make it invisible). 
            // 
            // when the inputForm is opened again (ShowDialog()), the Load event will fire
            //  and the form will be reinitialized

            form.Hide();
        }

        private class DisplayDonor
        {
            [DisplayName("First Name")]
            public string displayDonorFirstName { get; set; }

            [DisplayName("Last Name")]
            public string displayDonorLastName { get; set; }

            [DisplayName("Address")]
            public string displayDonorAddress { get; set; }

            [DisplayName("Birthday")]
            public string displayDonorBirthday { get; set; }

            [DisplayName("Phone")]
            public string displayDonorPhoneNumber { get; set; }

            [DisplayName("Blood Type")]
            public string displayDonorBloodType { get; set; }
        }
    }
}
