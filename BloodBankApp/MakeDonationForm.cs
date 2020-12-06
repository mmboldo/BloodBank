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
            
            // calculate the value based on the qty of ml donated and the price per ml of the blood type

            // Context... make donation
        }
    }
}
