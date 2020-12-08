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

            // Initializes the first data grid view, which displays the donors database
            initializeDonorsDataGridView();           

            // search button on the main page
            buttonSearchDonor.Click += ButtonSearchDonor_Click;

            // Creating the forms
            DonorAddForm donorAddForm = new DonorAddForm();
            buttonAddNewDonor.Click += (s, e) => AddOrUpdateForm<Donor>(dataGridViewDonorsDatabase, donorAddForm);
            BloodBankStatusForm bbStatForm = new BloodBankStatusForm();
            buttonBloodBank.Click += (s, e) => AddOrUpdateForm<BloodBankEntities>(null, bbStatForm);
            WithdrawalForm withdraw = new WithdrawalForm();
            buttonWithdrawBlood.Click += (s, e) => AddOrUpdateForm<BloodWithdrawal>(dataGridViewDonorsDatabase, withdraw);
            
            // Event handlers to add behavior when the form is closed
            withdraw.FormClosing += new FormClosingEventHandler(Form_FormClosing); // event habndler to refresh the current funds in the main form.
            buttonMakeDonation.Click += ButtonMakeDonation_Click; // This form was created differently, but the event handlers are similar.

            // Getting the current balance
            ReadCurrentFunds();

            //Searching the donor through textboxes
            buttonReset.Click += ButtonReset_Click;
            buttonAddClient.Click += ButtonAddClient_Click;
            buttonReportAndReport.Click += ButtonReportAndReport_Click;
        }

        // Strings that will contain the selected donor. 
        // This is to be used to populate the labels in the Make a Donation Form
        public static string SetMakeADonationFullName = "";
        public static string SetMakeADonationEmail = "";
        public static string SetMakeADonationBirthday = "";
        public static string SetMakeADonationPhoneNumber = "";
        public static string SetMakeADonationBloodType = "";

        // This variable holds the current balance of funds available to the bank.
        public static double SetFundsBalance = 5000.0;

        // Reads the Bank's current funds balance and adds it to the label
        public void ReadCurrentFunds()
        {
            labelCurrentFunds.Text = SetFundsBalance.ToString() + ",00";            
        }

        // Takes the user to the Report And Report
        private void ButtonReportAndReport_Click(object sender, EventArgs e)
        {
            ReportsAndBackupForm reportsAndBackupForm = new ReportsAndBackupForm();
            reportsAndBackupForm.Show();
        }

        // Takes the user to the Add Client Form
        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            AddClientForm addClientForm = new AddClientForm();
            addClientForm.Show();
        }

        // Takes the user to the Make Donation Form
        private void ButtonMakeDonation_Click(object sender, EventArgs e)
        {
            // A donor needs to be selected to go to the Make a Donation Form
            if (dataGridViewDonorsDatabase.SelectedRows == null)
            {
                MessageBox.Show("You must first select a donor.");
            } 
            else
            { // used the data from the datagridview to be used in the form's labels
                SetMakeADonationFullName = dataGridViewDonorsDatabase.CurrentRow.Cells[0].Value.ToString() + " " + dataGridViewDonorsDatabase.CurrentRow.Cells[1].Value.ToString();
                SetMakeADonationEmail = dataGridViewDonorsDatabase.CurrentRow.Cells[2].Value.ToString();
                SetMakeADonationBirthday = dataGridViewDonorsDatabase.CurrentRow.Cells[3].Value.ToString();
                SetMakeADonationPhoneNumber = dataGridViewDonorsDatabase.CurrentRow.Cells[4].Value.ToString();
                SetMakeADonationBloodType = dataGridViewDonorsDatabase.CurrentRow.Cells[5].Value.ToString();
            }
            // instantiate the form object and displays it to the user
            MakeDonationForm makeDonationForm = new MakeDonationForm();
            makeDonationForm.FormClosing += new FormClosingEventHandler(Form_FormClosing);
            makeDonationForm.Show();
        }

        // This handles the event of closing the form and reloading the current funds value to the labelCurrentFunds label
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            //when Make a Donation form is closed, this code is executed
            this.Refresh();
            ReadCurrentFunds();
        }

        // Resets the search fields and the data grid view with the search result
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            dataGridViewSearchResult.Columns.Clear();
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
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

                // get the donor birthday (DateTime) and get only the date part, ignoring the time portion
                var donorBirthday = donor.DonorBirthday;
                var shortDateValue = donorBirthday.ToShortDateString();

                // instantiate a DisplayDonor object and set its values to the ones from the DB
                var completeDonor = new DisplayDonor()
                    {
                        displayDonorFirstName = donor.DonorFirstName,
                        displayDonorLastName = donor.DonorLastName,
                        displayDonorAddress = donor.DonorAddress,
                        displayDonorBirthday = shortDateValue,
                        displayDonorPhoneNumber = donor.DonorPhone,
                        displayDonorBloodType = displayDonorBloodTypeName,
                    };
                    displayDonor.Add(completeDonor); // adding the new object to the list
                }

                // setting up the data grid view columns
            dataGridViewDonorsDatabase.DataSource = displayDonor;
            dataGridViewDonorsDatabase.Columns[0].Width = 100;
            dataGridViewDonorsDatabase.Columns[1].Width = 100;
            dataGridViewDonorsDatabase.Columns[2].Width = 150;
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
        {
            List<DisplayDonor> displayDonor = new List<DisplayDonor>();
            List<Donor> donors = Controller<BloodBankEntities, Donor>.GetEntitiesWithIncluded("BloodType").ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.GetEntitiesWithIncluded("Donors").ToList();

            // string variables to store the search text boxes content
            String searchedDonorFirstName = "";
            String SearchedDonorLastName = "";
            String SearchedDonorBirthday = "";

            try
            {
                searchedDonorFirstName = textBoxFirstName.Text;
                SearchedDonorLastName = textBoxLastName.Text;
                SearchedDonorBirthday = textBoxDateOfBirth.Text;
            } 
            catch (Exception ex)
            {
                Debug.WriteLine("ouch! " + ex.Message);
            }

            // go through all the donors and check if there is any donor names that look like what's begin searched
            foreach (Donor donor in donors)
            {
                if (donor.DonorFirstName.Contains(searchedDonorFirstName) && donor.DonorLastName.Contains(SearchedDonorLastName) && donor.DonorBirthday.ToString().Contains(SearchedDonorBirthday))
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

                    // get the donor birthday (DateTime) and get only the date part, ignoring the time portion
                    var donorBirthday = donor.DonorBirthday;
                    var shortDateValue = donorBirthday.ToShortDateString();

                    // instantiate a DisplayDonor object and set its values to the ones from the DB
                    var completeDonor = new DisplayDonor()
                    {
                        displayDonorFirstName = donor.DonorFirstName,
                        displayDonorLastName = donor.DonorLastName,
                        displayDonorAddress = donor.DonorAddress,
                        displayDonorBirthday = shortDateValue,
                        displayDonorPhoneNumber = donor.DonorPhone,
                        displayDonorBloodType = displayDonorBloodTypeName,
                    };
                    displayDonor.Add(completeDonor); // adding the new object to the list
                }
            }

            // checks if all the search text boxes are blank
            if (searchedDonorFirstName == "" && SearchedDonorLastName == "" && SearchedDonorBirthday == "")
            {
                MessageBox.Show("One or more search fields are blank.");
            }
            else if (displayDonor.Count == 0) // no results returned to the search
            {
                MessageBox.Show("This donor is not registered. Please add new donor.");
            }
            else
            {
                // setting up the data grid view columns
                dataGridViewSearchResult.DataSource = displayDonor;
                dataGridViewSearchResult.Columns[0].Width = 100;
                dataGridViewSearchResult.Columns[1].Width = 100;
                dataGridViewSearchResult.Columns[2].Width = 150;
                dataGridViewSearchResult.Columns[3].Width = 70;
                dataGridViewSearchResult.Columns[4].Width = 90;
                dataGridViewSearchResult.Columns[5].Width = 80;
            }
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
                // update the gridview
                initializeDonorsDataGridView();               
            }
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

            override
            public string ToString()
            {
                return (displayDonorFirstName + " " + displayDonorLastName);
            }
        }
    }
}
