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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
            //this.Load += AddClientForm_Load;
            buttonAddNewClient.Click += ButtonAddClient_Click;
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {

            BloodBankEntities context = new BloodBankEntities();
            int id = context.Clients.Count() + 1;
            Client client = new Client()
            {
                // ClientId = ParseInt(textBoxAddClientID.Text),
                ClientId = id,
                ClientFirstName = textBoxAddClientFirstName.Text,
                ClientLastName = textBoxAddClientLastName.Text
            };

            //check if user fills name
            if (client.ClientFirstName.Trim().Length == 0 || client.ClientLastName.Trim().Length == 0)
            {
                MessageBox.Show("Please enter all fields");
                return;
            }
            if (Controller<BloodBankEntities, Client>.AddEntity(client) == null)
            {
                MessageBox.Show("Cannot add client to database");
                return;
            }
            // dispose the context and close the form.
            this.DialogResult = DialogResult.OK;
            context.Dispose();
            Close();
        }

        // IMPORTANT: 
        // CREATE HERE A CLASS SIMILAR TO THE ONE IN MAIN FORM TO 
        // POPULATE THE DATA GRID VIEWS WITHOUT ERROR
        // (end time you open the form is chaotic)

        //private void AddClientForm_Load(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
