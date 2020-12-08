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
            ReadCurrentFunds();

            // Adding the button click events
            buttonCalculateTotal.Click += ButtonCalculateTotal_Click;
            buttonAddToBloodBank.Click += ButtonAddToBloodBank_Click;
            buttonBackToMain.Click += ButtonBackToMain_Click;
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
        private void ButtonCalculateTotal_Click(object sender, EventArgs e)
        {
            double donatedVolume = 0.0;
            Double.TryParse(textBoxDonatedBloodVolume.Text, out donatedVolume);
            double pricePerUnit = GetBloodTypePrice(BloodBankAppMainForm.SetMakeADonationBloodType);
            labelTotalDonationPrice.Text = (donatedVolume * pricePerUnit / 500).ToString();
        }

        // it reads from a double variable contained in the Main Form and populates the Current Balance label
        private void ReadCurrentFunds()
        {
            labelCurrentBalance.Text = BloodBankAppMainForm.SetFundsBalance.ToString();
        }

        private void ButtonAddToBloodBank_Click(object sender, EventArgs e)
        {
            double value;
            // first try if there is any value
            if (Double.TryParse(labelTotalDonationPrice.Text, out value)){
                BloodBankAppMainForm.SetFundsBalance -= value;
            }
            else
            {
                MessageBox.Show("Nothing to add. Please calculate the total donation value and try again.");
            }
            //BloodBankAppMainForm.SetFundsBalance -= Int32.Parse(labelTotalDonationPrice.Text);
            // then calculated and change the value of the current funds            
            ReadCurrentFunds();
        }

        // The form can be closed by clicking on either this button or the red X
        private void ButtonBackToMain_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
