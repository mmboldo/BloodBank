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

            button1.Click += ButtonWithdraw_Click;
            dataGridViewStock.SelectionChanged += (s, e) => GetSelection();
        }
        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            dataGridViewStock.DataSource = Controller<BloodBankEntities, BloodDeposit>.SetBindingList();

            dataGridViewClient.DataSource = Controller<BloodBankEntities, Client>.SetBindingList();
            dataGridViewStock.Columns.Remove("BloodType");
            dataGridViewStock.Columns.Remove("BloodWithdrawalUnits");
            dataGridViewClient.Columns.Remove("BloodWithdrawals");
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
            this.DialogResult = DialogResult.OK;
            Close();
        }
        //populates price from selected item
        private void GetSelection()
        {
            foreach (DataGridViewRow row in dataGridViewStock.SelectedRows)
            {
                textBoxTotal.Text = row.Cells["UnitPrice"].Value.ToString();
            }
        }
    }
}
