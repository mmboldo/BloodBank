using System.Data;
using System.Windows.Forms;
using EFControllerUtilities;
using BloodBankCodeFirstFromDB;
using DataTableAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace BloodBankApp
{
    public partial class ReportsAndBackupForm : Form
    {
        // field to keep the access layer field

        private SqlDataAccessLayer bloodBankDB;

        // dataset will hold all tables being used

        private DataSet bloodBankDataSet;


        public ReportsAndBackupForm()
        {
            InitializeComponent();
            DataGridViewInitializeWithdrawal();
            DataGridViewInitializeDepositedBlood();
            DataGridViewInitializeAvailableBlood();

            bloodBankDB = new SqlDataAccessLayer();

            bloodBankDataSet = new DataSet()
            {
                // must be named for backup purposes

                DataSetName = "BloodBankDataSet",
            };

            // get the connection string from App.config

            string connectionString = bloodBankDB.GetConnectionString("BloodBankConnection");
            bloodBankDB.OpenConnection(connectionString);
            // Initialise the DataGridViews and DataSets

            //InitializeDataGridViewAndDataSet(dataGridViewBloodDeposited, bloodBankDataSet, "BloodDeposit");
            //InitializeDataGridViewAndDataSet(dataGridViewBloodWithdrawal, bloodBankDataSet, "BloodWithdrawals");
            //InitializeDataGridViewAndDataSet(dataGridViewAvailableBlood, bloodBankDataSet, "BloodTypes");
            List<BloodWithdrawal> withdrawals = Controller<BloodBankEntities, BloodWithdrawal>.SetBindingList().ToList();
            List<Donor> donors = Controller<BloodBankEntities, Donor>.SetBindingList().ToList();

            // add button event handlers for database backup to xml
            buttonbackup.Click += (s, e) => bloodBankDB.BackupDataSetToXML(bloodBankDataSet);
            // buttonRestoreDatabaseFromBackup.Click += (s, e) => registrationDB.RestoreDataSetFromBackup(registrationDataSet);

            //close connection
            this.FormClosing += (s, e) => bloodBankDB.CloseConnection();
        }
        /// <summary>
        /// Initialise the data grid view with values 
        /// </summary>
        /// <param name="dataGridView"></param>
        /// <param name="dataSet"></param>
        /// <param name="tableName"></param>
        public void InitializeDataGridViewAndDataSet(DataGridView dataGridView, DataSet dataSet, string tableName)
        {
            // get the table filled with records from the db

            DataTable table = bloodBankDB.GetDataTable(tableName);


            // set the datasource to the table.
            // when the control changes, the table will change as well with one of the events below.
            // so make sure to handle relevant table change events

            // this autogenerates the column names, so no need to set them manually

            dataGridView.DataSource = table;

            // if we have an identity column, any time a row is added we want the
            // column to be set to -1

            if (table.Columns[0].AutoIncrement == true)
            {
                dataGridView.DefaultValuesNeeded += (s, e) => NewRowBeingAdded(s as DataGridView, e);
            }

            // handle insertion
            table.RowChanged += (s, e) => BloodBankTableRowChanged(e);

            // handle updates
            table.ColumnChanged += (s, e) => BloodBankTableColumnChanged(e);

            // handle deletes
            //table.RowDeleted += (s, e) => BloodBankTableRowDeleted(e);

            // autosize the columns to fill out as much as possible

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AllowUserToDeleteRows = false;
            // allow multiple select to allow for deletion of multiple rows

            dataGridView.MultiSelect = true;


            // add the table to the Tables collection.
            // This is only used for backup and restore

            dataSet.Tables.Add(table);
        }

        /// <summary>
        /// Delete a row in the database given the DataRow that was deleted from the control
        /// and the DataTable.
        /// 
        /// We don't accept changes to the datatable until DeleteTableRow() succeeds.
        /// 
        /// Another way to do this is to use the deleting event, set an error if it fails, then handle
        /// the error in the deleted event to roll back the row's state. RejectChanges() does
        /// not work in the RowDeleting event, as the row has not changed yet!
        /// </summary>
        /// <param name="e"></param>
        //private void BloodBankTableRowDeleted(DataRowChangeEventArgs e)
        //{
        //    try
        //    {
        // dataGridView.AllowUserToDeleteRows = false;
        //        bloodBankDB.DeleteTableRow(e.Row);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    // update the lower control (a view)

        //   // bloodBankDB.LoadDataTable(dataGridViewStudents.DataSource as DataTable);
        //}


        /// <summary>
        /// Update the database with the changed column in a DataTable row
        /// </summary>
        /// <param name="e">Contains row to be updated</param>
        private void BloodBankTableColumnChanged(DataColumnChangeEventArgs e)
        {
            // if the row is in the process of being added (detached), don't update the cells

            // only do this if an existing cell is changed

            if (e.Row.RowState != DataRowState.Detached)
            {
                // if this is an identity column, it is only modified by the db in InsertTableRow()
                //  so don't send an update back

                if (e.Column.AutoIncrement == false)
                {
                    // just update the entire row even though just one column was changed
                    // this could be optimized

                    try
                    {
                        bloodBankDB.UpdateTableRow(e.Row);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    // update the view (bottom control)

                    //bloodBankDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);
                }
            }
        }

        /// <summary>
        /// Insert a record into the database corresponding to a DataTable row
        /// </summary>
        /// <param name="e">Contains the row to be inserted</param>
        private void BloodBankTableRowChanged(DataRowChangeEventArgs e)
        {
            // only insert if there was an Add action. Updates will be handled
            // by ColumnChanged

            if (e.Action == DataRowAction.Add)
            {
                try
                {
                    bloodBankDB.InsertTableRow(e.Row);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Insertion failed: " + ex.Message); ;
                }

                // update the lower control, a view

                //registrationDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);
            }
        }

        /// <summary>
        /// If a new row is being added, set the id column in the control to -1
        /// </summary>
        /// <param name="e"></param>
        private void NewRowBeingAdded(DataGridView dataGridView, DataGridViewRowEventArgs e)
        {
            DataTable table = dataGridView.DataSource as DataTable;

            if (table.Columns[0].AutoIncrement == true)
            {
                e.Row.Cells[0].Value = -1;
            }
            //registrationDB.LoadDataTable(dataGridViewDepartmentMajorsCount.DataSource as DataTable);
        }

        /// <summary>
        /// Created list from the class and various tables used in fetching values
        /// get value through foreach loop
        /// saved it in array of type class
        /// showed in deposit datagridview
        /// </summary>
        private void DataGridViewInitializeDepositedBlood()
        {
            List<DisplayDeposited> displayDeposited = new List<DisplayDeposited>();
            List<Donor> donor = Controller<BloodBankEntities, Donor>.SetBindingList().ToList();
            List<Donation> donation = Controller<BloodBankEntities, Donation>.SetBindingList().ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.SetBindingList().ToList();

           
            foreach (Donation d in donation)
            {
                string bloodTypeString = "";
               
                //get blood type name from id
                foreach (BloodType type in bloodTypes)
                {
                    if (d.BloodTypeId == type.BloodTypeId)
                    {
                        bloodTypeString = type.BloodType1;
                    }
                }
                DateTime depositedDate = d.DonationDate;
                String date = depositedDate.ToShortDateString();

                float volume = d.DonationBloodVolume;
                DisplayDeposited dd = new DisplayDeposited()
                {
                    
                    displayBloodType = bloodTypeString,
                    displayDepositedDate = date,
                    displayQuantity = volume.ToString(),

                };
                displayDeposited.Add(dd);

            }
            dataGridViewBloodDeposited.DataSource = displayDeposited;
            dataGridViewBloodDeposited.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBloodDeposited.MultiSelect = true;
            dataGridViewBloodDeposited.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Created list from the class and various tables used in fetching values
        /// get value through foreach loop
        /// saved it in array of type class
        /// showed in Available datagridview
        /// </summary>
        private void DataGridViewInitializeAvailableBlood()
        {
            List<DisplayAvailable> displayAvailable = new List<DisplayAvailable>();
            List<BloodDeposit> deposit = Controller<BloodBankEntities, BloodDeposit>.SetBindingList().ToList();
            List<Donation> donation = Controller<BloodBankEntities, Donation>.SetBindingList().ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.SetBindingList().ToList();


            foreach (BloodDeposit d in deposit)
            {
                string bloodTypeString = "";
                float volume;
                //get blood type name from id
                foreach (BloodType type in bloodTypes)
                {
                    if (d.BloodTypeId == type.BloodTypeId)
                    {
                        bloodTypeString = type.BloodType1;
                    }
                }
                DateTime expiryDate = d.UnitExpiryDate;
                String date = expiryDate.ToShortDateString();

                foreach(Donation don in donation)
                {
                    volume = don.DonationBloodVolume;
                

                DisplayAvailable da = new DisplayAvailable()
                {
                    displayBloodTypeAvailable = bloodTypeString,
                    displayExpiryDate = date,
                    displayQuantityAvailable = volume.ToString(),

                };
                displayAvailable.Add(da);
                }
            }
            dataGridViewAvailableBlood.DataSource = displayAvailable;
            dataGridViewAvailableBlood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAvailableBlood.MultiSelect = true;
            dataGridViewAvailableBlood.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Created list from the class and various tables used in fetching values
        /// get value through foreach loop
        /// saved it in array of type class
        /// showed in withdrawal datagridview
        /// </summary>
        private void DataGridViewInitializeWithdrawal()
        {
            List<DisplayWithdrawal> displayWithdrawal = new List<DisplayWithdrawal>();
            List<BloodWithdrawal> bloodWithdrawal = Controller<BloodBankEntities, BloodWithdrawal>.SetBindingList().ToList();
            List<Client> clients = Controller<BloodBankEntities, Client>.SetBindingList().ToList();
            foreach (BloodWithdrawal b in bloodWithdrawal)
            {
                string clientName = "";

                //get client name from id
                foreach (Client client in clients)
                {
                    if (client.ClientId == b.ClientId)
                    {
                        clientName = client.ClientLastName + ", " + client.ClientFirstName;
                    }
                }

                DateTime withdrawalDate = b.BloodWithdrawalDate;
                String date = withdrawalDate.ToShortDateString();
                //round prices to 2 decimals
                decimal cost = Math.Round(Decimal.Parse(b.TransactionValue.ToString()), 2);
                //create display object
                DisplayWithdrawal dw = new DisplayWithdrawal()
                {
                    displayWithdrawalId = b.BloodWithdrawalId.ToString(),
                    displayClientName = clientName,
                    displayWithdrawalDate = date,
                    displayTransValue = cost.ToString(),
                    displayQuantity = b.UnitQuantity.ToString(),
                };
                displayWithdrawal.Add(dw);
            }
            //add objects to DGV
            dataGridViewBloodWithdrawal.DataSource = displayWithdrawal;
            dataGridViewBloodWithdrawal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewBloodWithdrawal.MultiSelect = true;
            dataGridViewBloodWithdrawal.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Class to display withdrawal blood
        /// </summary>
        private class DisplayWithdrawal
        {
            [DisplayName("Withdrawal ID")]
            public string displayWithdrawalId { get; set; }
            [DisplayName("Client Name")]
            public string displayClientName { get; set; }

            [DisplayName("Withdrawal Date")]
            public string displayWithdrawalDate { get; set; }
            [DisplayName("Transaction Value")]
            public string displayTransValue { get; set; }
            [DisplayName("Quantity")]
            public string displayQuantity { get; set; }

        }
        /// <summary>
        /// Class to display deposited blood 
        /// </summary>

        private class DisplayDeposited
        {
         
            [DisplayName("Blood Type")]
            public string displayBloodType { get; set; }

            [DisplayName("Deposited Date")]
            public string displayDepositedDate { get; set; }

            [DisplayName("Quantity")]
            public string displayQuantity { get; set; }
        }

        /// <summary>
        /// Class to display Available Blood
        /// </summary>
        private class DisplayAvailable
        {
            [DisplayName("Blood Type")]
            public string displayBloodTypeAvailable { get; set; }

            [DisplayName("Expiry Date")]
            public string displayExpiryDate { get; set; }

            [DisplayName("Quantity")]
            public string displayQuantityAvailable { get; set; }
        }
    }
}
		
