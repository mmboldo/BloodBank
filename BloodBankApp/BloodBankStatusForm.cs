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
            dataGridViewDonations.DataSource = Controller<BloodBankEntities, Donation>.SetBindingList();

            dataGridViewStock.DataSource = Controller<BloodBankEntities, BloodDeposit>.SetBindingList();

            dataGridViewWithdrawals.DataSource = Controller<BloodBankEntities, BloodWithdrawal>.SetBindingList();
            dataGridViewDonations.Columns.Remove("Donor");
            dataGridViewDonations.Columns.Remove("BloodType");
            dataGridViewStock.Columns.Remove("BloodType");
            dataGridViewStock.Columns.Remove("BloodWithdrawalUnits");
            dataGridViewWithdrawals.Columns.Remove("Client");
            dataGridViewWithdrawals.Columns.Remove("BloodWithdrawalUnits");
            /*
            BloodBankEntities context = new BloodBankEntities();
            List<Donation> Aplus = context.Donations.Where(b => b.BloodTypeId == 1).ToList();
            List<Donation> Aminus = context.Donations.Where(b => b.BloodTypeId == 2).ToList();
            List<Donation> Bplus = context.Donations.Where(b => b.BloodTypeId == 3).ToList();
            List<Donation> Bminus = context.Donations.Where(b => b.BloodTypeId == 4).ToList();
            List<Donation> ABplus = context.Donations.Where(b => b.BloodTypeId == 5).ToList();
            List<Donation> ABminus = context.Donations.Where(b => b.BloodTypeId == 6).ToList();
            List<Donation> Oplus = context.Donations.Where(b => b.BloodTypeId == 7).ToList();
            List<Donation> Ominus = context.Donations.Where(b => b.BloodTypeId == 8).ToList();
            float AplusStock = 0;
            float AminusStock = 0;
            float BplusStock = 0;
            float BminusStock = 0;
            float ABplusStock = 0;
            float ABminusStock = 0;
            float OplusStock = 0;
            float OminusStock = 0;
            foreach(Donation a in Aplus)
            {
                AplusStock += a.DonationBloodVolume;
            }
            foreach(Donation a in Aminus)
            {
                AminusStock += a.DonationBloodVolume;
            }
            foreach(Donation b in Bplus)
            {
                BplusStock += b.DonationBloodVolume;
            }
            foreach(Donation b in Bminus)
            {
                BminusStock += b.DonationBloodVolume;
            }
            foreach(Donation ab in ABplus)
            {
                ABplusStock += ab.DonationBloodVolume;
            }
            foreach(Donation ab in ABminus)
            {
                ABminusStock += ab.DonationBloodVolume;
            }
            foreach(Donation o in Oplus)
            {
                OplusStock += o.DonationBloodVolume;
            }
            foreach(Donation o in Ominus)
            {
                OminusStock += o.DonationBloodVolume;
            }
            dataGridViewStock.Columns[0].HeaderText = "Blood Type";
            dataGridViewStock.Columns[1].HeaderText = "Quantity(units)";
            dataGridViewStock.Columns[2].HeaderText = "Price per unit";
            dataGridViewStock.Columns[3].HeaderText = "Expiry date";
            DataGridViewRow row = new DataGridViewRow();
            row.Cells[0].Value = "A+";
            row.Cells[1].Value = AplusStock;
            BloodType A = context.BloodTypes.Where(b => b.BloodTypeId == 1).First<BloodType>();
            row.Cells[2].Value = A.PricePerUnit;
            dataGridViewStock.Rows.Add(row);*/
        }

    }
}
