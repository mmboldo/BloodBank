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
namespace BloodBankApp
{
    public partial class WithdrawalForm : Form
    {
        public WithdrawalForm()
        {
            //load the form
            InitializeComponent();
            this.Load += WithdrawForm_Load;

            buttonWithdrawBlood.Click += ButtonWithdraw_Click;
            dataGridViewStock.SelectionChanged += (s, e) => GetSelection();
        }
        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            initializeDepositDGV();
            initializeClientDGV();
            ReadCurrentFunds();
        }

        private void ReadCurrentFunds()
        {
            labelCurrentBalance.Text = BloodBankAppMainForm.SetFundsBalance.ToString() + ",00";
        }

        private void ButtonWithdraw_Click(object sender, EventArgs e)
        {
            BloodBankEntities context = new BloodBankEntities();
            //create a BloodWithdrawal object
            BloodWithdrawal bw = new BloodWithdrawal()
            {
                BloodWithdrawalId = context.BloodWithdrawals.Count() + 1,
                BloodWithdrawalDate = DateTime.Now.Date,
                TransactionValue = float.Parse(textBoxTotal.Text),
                UnitQuantity = 1,
                ClientId = Int32.Parse(dataGridViewClient.SelectedRows[0].Cells[0].Value.ToString())
            };
            //validate
            if (dataGridViewStock.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select an item to withdraw");
                return;
            }
            if (dataGridViewClient.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a client for withdrawal");
                return;
            }
            //add to db
            if (Controller<BloodBankEntities, BloodWithdrawal>.AddEntity(bw) == null)
            {
                MessageBox.Show("Cannot add withdrawal to database");
                return;
            }
            //creates a new BloodWithdrawalUnit object
            BloodWithdrawalUnit bwu = new BloodWithdrawalUnit()
            {
                BloodWithdrawalUnitsId = context.BloodWithdrawalUnits.Count() + 1,
                UnitId = Int32.Parse(dataGridViewStock.SelectedRows[0].Cells[0].Value.ToString()),
                BloodWithdrawalId = context.BloodWithdrawals.Count(),
            };
            context.Dispose();
            //add to d b
            if (Controller<BloodBankEntities, BloodWithdrawalUnit>.AddEntity(bwu) == null)
            {
                MessageBox.Show("Cannot add withdrawal to database");
                return;
            }

            // adds to the current balance after a withdrawal
            BloodBankAppMainForm.SetFundsBalance += Double.Parse(textBoxTotal.Text);
            ReadCurrentFunds(); // re-reads the current balance
        }
        //populates price from selected item
        private void GetSelection()
        {
            foreach (DataGridViewRow row in dataGridViewStock.SelectedRows)
            {
                textBoxTotal.Text = row.Cells[1].Value.ToString();
            }
        }
        //Initializes Stock DGV
        private void initializeDepositDGV()
        {
            List<DisplayDeposit> displayDeposit = new List<DisplayDeposit>();
            List<BloodDeposit> bloodDeposit = Controller<BloodBankEntities, BloodDeposit>.SetBindingList().ToList();
            List<BloodType> bloodTypes = Controller<BloodBankEntities, BloodType>.SetBindingList().ToList();
            List<BloodWithdrawalUnit> bwus = Controller<BloodBankEntities, BloodWithdrawalUnit>.SetBindingList().ToList();
            foreach (BloodDeposit b in bloodDeposit)
            {
                int isStocked = 1;
                string depositBloodType = "";
                //get blood type from id
                foreach (BloodType bloodType in bloodTypes)
                {
                    if (bloodType.BloodTypeId == b.BloodTypeId)
                    {
                        depositBloodType = bloodType.BloodType1;
                    }
                }
                //check if deposit has been withdrawn
                foreach(BloodWithdrawalUnit bwu in bwus)
                {
                    if(bwu.UnitId == b.UnitId)
                    {
                        isStocked = 0;
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
                if (isStocked == 1)
                {
                    displayDeposit.Add(dd);
                }
            }
            //add to DGV
            dataGridViewStock.DataSource = displayDeposit;
            dataGridViewStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        //Initializes Client DGV
        private void initializeClientDGV()
        {
            List<DisplayClient> displayClient = new List<DisplayClient>();
            List<Client> clients = Controller<BloodBankEntities, Client>.SetBindingList().ToList();

            foreach (Client c in clients)
            {
                //create display object
                DisplayClient dc = new DisplayClient()
                {
                    displayClientId = c.ClientId.ToString(),
                    displayClientName = c.ClientLastName + ", " + c.ClientFirstName,
                };
                displayClient.Add(dc);
            }
            //add to DGV
            dataGridViewClient.DataSource = displayClient;
            dataGridViewClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
        private class DisplayClient
        {

            [DisplayName("Client ID")]
            public string displayClientId { get; set; }
            [DisplayName("Name")]
            public string displayClientName { get; set; }

        }
    }
}
