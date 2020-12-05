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

        private void BloodBankStatusForm_Load(object sender, EventArgs e)
        {
            initializeDepositDGV();
            initializeDonationDGV();

        }
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
                foreach (BloodType bloodType in bloodTypes)
                {
                    if (bloodType.BloodTypeId == d.BloodTypeId)
                    {
                        donorBloodTypeName = bloodType.BloodType1;
                    }
                }
                foreach(Donor donor in donors)
                {
                    if(donor.DonorId == d.DonorId)
                    {
                        donorName = donor.DonorLastName + ", "+ donor.DonorFirstName;
                    }
                }
                DateTime donationDate = d.DonationDate.Date;
                String date = donationDate.ToShortDateString();
                DisplayDonation dd = new DisplayDonation()
                {
                    displayDonorName = donorName,
                    displayMedicalReport = d.MedicalReport,
                    displayDonorBloodType = donorBloodTypeName,
                    displayDonationDate = date,
                };
                displayDonation.Add(dd);
            }
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
                foreach (BloodType bloodType in bloodTypes)
                {
                    if (bloodType.BloodTypeId == b.BloodTypeId)
                    {
                        depositBloodType = bloodType.BloodType1;
                    }
                }

                DateTime expiryDate = b.UnitExpiryDate;
                String date = expiryDate.ToShortDateString();
                decimal cost = Math.Round((b.UnitPrice * 100) / 100);
                DisplayDeposit dd = new DisplayDeposit()
                {
                    displayDepositId = b.UnitId.ToString(),
                    displayUnitPrice = cost.ToString(),
                    displayExpiryDate = date,
                    displayBloodType = depositBloodType,
                };
                displayDeposit.Add(dd);
            }
            dataGridViewStock.DataSource = displayDeposit;
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
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
    }
}
