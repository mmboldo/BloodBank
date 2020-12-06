using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EFControllerUtilities;
using BloodBankCodeFirstFromDB;
using System.Data.Entity;

namespace BloodBankApp
{
    public partial class BloodBankStatusForm : Form
    {
        public BloodBankStatusForm()
        {
            InitializeComponent();
            this.Load += BloodBankStatusForm_Load;

        }
        //load form
        private void BloodBankStatusForm_Load(object sender, EventArgs e)
        {
            initializeDepositDGV();
            initializeDonationDGV();
            initializeWithdrawalDGV();

        }
        //create DGV for donations
        private void initializeDonationDGV()
        {
            List<DisplayDonation> displayDonation = new List<DisplayDonation>();
            List<Donation> donations = Controller<BloodBankEntities, Donation>.SetBindingList().ToList();
            List<Donor> donors = Controller<BloodBankEntities, Donor>.GetEntitiesWithIncluded("BloodType").ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.GetEntitiesWithIncluded("Donors").ToList();
            foreach (Donation d in donations)
            {
                string donorBloodTypeName = "";
                string donorName = "";
                //get blood type from id
                foreach (BloodType bloodType in bloodTypes)
                {
                    if (bloodType.BloodTypeId == d.BloodTypeId)
                    {
                        donorBloodTypeName = bloodType.BloodType1;
                    }
                }
                //get donor name from id
                foreach(Donor donor in donors)
                {
                    if(donor.DonorId == d.DonorId)
                    {
                        donorName = donor.DonorLastName + ", "+ donor.DonorFirstName;
                    }
                }
                DateTime donationDate = d.DonationDate.Date;
                String date = donationDate.ToShortDateString();
                //create display object
                DisplayDonation dd = new DisplayDonation()
                {
                    displayDonorName = donorName,
                    displayMedicalReport = d.MedicalReport,
                    displayDonorBloodType = donorBloodTypeName,
                    displayDonationDate = date,
                };
                displayDonation.Add(dd);
            }
            //add to DGV
            dataGridViewDonations.DataSource = displayDonation;
            dataGridViewDonations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }
        private void initializeDepositDGV()
        {
            List<DisplayDeposit> displayDeposit = new List<DisplayDeposit>();
            List<BloodDeposit> bloodDeposit = Controller<BloodBankEntities, BloodDeposit>.SetBindingList().ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.SetBindingList().ToList();
            foreach (BloodDeposit b in bloodDeposit)
            {
                string depositBloodType = "";
                //get blood type from id
                foreach (BloodType bloodType in bloodTypes)
                {
                    if (bloodType.BloodTypeId == b.BloodTypeId)
                    {
                        depositBloodType = bloodType.BloodType1;
                    }
                }

                DateTime expiryDate = b.UnitExpiryDate;
                String date = expiryDate.ToShortDateString();
                //round price to 2 decimals
                decimal cost = Math.Round(b.UnitPrice, 2);
                //create display object
                DisplayDeposit dd = new DisplayDeposit()
                {
                    displayDepositId = b.UnitId.ToString(),
                    displayUnitPrice = cost.ToString(),
                    displayExpiryDate = date,
                    displayBloodType = depositBloodType,
                };
                displayDeposit.Add(dd);
            }
            //add to DGV
            dataGridViewStock.DataSource = displayDeposit;
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void initializeWithdrawalDGV()
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
            dataGridViewWithdrawals.DataSource = displayWithdrawal;
            dataGridViewWithdrawals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        //display object classes
        private class DisplayDonation
        {
            [DisplayName("Name")]
            public string displayDonorName { get; set; }

            [DisplayName("Medical Report")]
            public string displayMedicalReport { get; set; }

            [DisplayName("Blood Type")]
            public string displayDonorBloodType { get; set; }
            [DisplayName("Donation Date")]
            public string displayDonationDate { get; set; }
        }
        private class DisplayDeposit
        {
            [DisplayName("Deposit ID")]
            public string displayDepositId { get; set; }

            [DisplayName("Unit Price")]
            public string displayUnitPrice { get; set; }

            [DisplayName("Expiry Date")]
            public string displayExpiryDate { get; set; }
            [DisplayName("Blood Type")]
            public string displayBloodType { get; set; }
        }
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
    }
}
