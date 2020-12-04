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
    public partial class DonorAddForm : Form
    {
        public DonorAddForm()
        {
            InitializeComponent();
            this.Load += DonorAddForm_Load;
            buttonSubmit.Click += ButtonSubmit_Click;
        }

        private void DonorAddForm_Load(object sender, EventArgs e)
        {
            listBoxBloodType.DataSource = Controller<BloodBankEntities, BloodType>.SetBindingList();
            listBoxBloodType.SelectedIndex = -1;
        }
        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            BloodBankEntities context = new BloodBankEntities();
            int id = context.Donors.Count() + 1;
            Donor donor = new Donor()
            {
                DonorId = id,
                DonorFirstName = textBoxFirstName.Text,
                DonorLastName = textBoxLastName.Text,
                DonorBirthday = dateTimePickerBirthday.Value,
                DonorAddress = textBoxAddress.Text,
                DonorPhone = numericUpDown1.Value.ToString(),
                BloodTypeId = listBoxBloodType.SelectedIndex + 1,
            };
            
            if (!(listBoxBloodType.SelectedItem is BloodType type))
            {
                MessageBox.Show("Must select a blood type!");
                return;
            }
            if (donor.DonorFirstName.Trim().Length == 0 || donor.DonorFirstName.Trim().Length == 0 || donor.DonorBirthday == new DateTime(1900, 01, 01) || donor.DonorAddress.Trim().Length == 0 || donor.DonorPhone == "0" || donor.DonorPhone == null)
            {
                MessageBox.Show("Must fill all fields");
                return;
            }
            if (!donor.DonorAddress.Contains("@") || !donor.DonorAddress.Contains("."))
            {
                MessageBox.Show("Email is not valid");
                return;
            }
            if (Controller<BloodBankEntities, Donor>.AddEntity(donor) == null)
            {
                MessageBox.Show("Cannot add course to database");
                return;
            }
            // dispose the context and close the form.
            this.DialogResult = DialogResult.OK;
            context.Dispose();
            Close();
        }
    }
}
