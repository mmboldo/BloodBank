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

            InitializeDataGridView<BloodDeposit>(dataGridView1, "UnitId" );
            InitializeDataGridView<BloodType>(dataGridView2, "BloodTypeId");
            InitializeDataGridView<BloodWithdrawal>(dataGridView3, "BloodWithdrawalId");
            InitializeDataGridView<BloodWithdrawalUnit>(dataGridView4 ,"BloodWithdrawalUnitsId");
            InitializeDataGridView<Client>(dataGridView5 ,"ClientId");
            InitializeDataGridView<Donation>(dataGridView6 ,"DonationId");
            InitializeDataGridView<Donor>(dataGridView7 ,"DonorId");
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
            gridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // set the handler used to delete an item. Note use of generics.

            gridView.UserDeletingRow += (s, e) => DeletingRow<T>(s as DataGridView, e);

            // probably not needed, but just in case we have some issues

            gridView.DataError += (s, e) => HandleDataError<T>(s as DataGridView, e);

            gridView.DataSource = Controller<BloodBankEntities, T>.SetBindingList();


            foreach (string column in columnsToHide)
                gridView.Columns[column].Visible = false;
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
    }
}
