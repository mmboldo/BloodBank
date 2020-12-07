using BloodBankCodeFirstFromDB;
using EFControllerUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankApp
{
    public partial class MakeDonationForm : Form
    {
        public MakeDonationForm()
        {
            InitializeComponent();
            this.Load += (s, e) => MakeDoationForm_Load();
            //labelTotalDonationPrice.TextChanged += (s, e) => TextBoxDonatedBloodVolume_TextChanged();
        }

        private void MakeDoationForm_Load()
        {
            // read from the strings created in the main form to populate the labels
            labelFullName.Text = BloodBankAppMainForm.SetMakeADonationFullName;
            labelDateOfBirth.Text = BloodBankAppMainForm.SetMakeADonationBirthday;
            labelEmail.Text = BloodBankAppMainForm.SetMakeADonationEmail;
            labelPhoneNumber.Text = BloodBankAppMainForm.SetMakeADonationPhoneNumber;
            labelBloodType.Text = BloodBankAppMainForm.SetMakeADonationBloodType;
            labelBloodTypePrice.Text = Math.Round(GetBloodTypePrice(BloodBankAppMainForm.SetMakeADonationBloodType), 2).ToString() + ",00";
            initializeBankBalance();

            buttonCalculateTotal.Click += ButtonCalculateTotal_click;

            BloodBankAppMainForm main = new BloodBankAppMainForm();
            this.FormClosed += (s, e) => main.initializeBankBalance();

        }

        // Gets the Blood type price to populate the label
        private double GetBloodTypePrice(String bloodType)
        {
            var bloodTypePrice = 0.0;
            using (BloodBankEntities context = new BloodBankEntities())
            {
                var b = context.BloodTypes.Single(x => x.BloodType1 == bloodType);
                bloodTypePrice = b.PricePerUnit;
            }
            return bloodTypePrice;
        }

        // Calculate button click event: calculates the donation monetary value based on the donated blood volume and the price per ml of the blood type
        private void ButtonCalculateTotal_click(object sender, EventArgs e)
        {
            double donatedVolume = 0.0;
            Double.TryParse(textBoxDonatedBloodVolume.Text, out donatedVolume);
            double pricePerUnit = GetBloodTypePrice(BloodBankAppMainForm.SetMakeADonationBloodType);
            labelTotalDonationPrice.Text = (donatedVolume * pricePerUnit / 500).ToString();
        }

        private void initializeBankBalance()
        {
            List<Donation> donations = Controller<BloodBankEntities, Donation>.SetBindingList().ToList();
            List<BloodWithdrawal> withdrawals = Controller<BloodBankEntities, BloodWithdrawal>.SetBindingList().ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.SetBindingList().ToList();
            decimal depositBalance = 0;
            decimal withdrawalBalance = 0;
            foreach (Donation d in donations)
            {
                float volume = d.DonationBloodVolume;
                float ppu = 0;
                foreach (BloodType b in bloodTypes)
                {
                    if (d.BloodTypeId == b.BloodTypeId)
                    {
                        ppu = b.PricePerUnit;
                    }
                }
                depositBalance += Decimal.Parse((volume * ppu).ToString());
            }
            foreach (BloodWithdrawal b in withdrawals)
            {
                withdrawalBalance += Decimal.Parse(b.TransactionValue.ToString());
            }
            labelCurrentBalance.Text = (depositBalance - withdrawalBalance).ToString();            
        }
    }
}
