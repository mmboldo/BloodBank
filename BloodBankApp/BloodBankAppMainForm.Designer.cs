
namespace BloodBankApp
{
    partial class BloodBankAppMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDonorsDatabase = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDateOfBirth = new System.Windows.Forms.Label();
            this.textBoxDateOfBirth = new System.Windows.Forms.TextBox();
            this.buttonSearchDonor = new System.Windows.Forms.Button();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.labelCurrentFundsLabel = new System.Windows.Forms.Label();
            this.buttonMakeDonation = new System.Windows.Forms.Button();
            this.buttonWithdrawBlood = new System.Windows.Forms.Button();
            this.buttonAddNewDonor = new System.Windows.Forms.Button();
            this.buttonBloodBank = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.groupBoxSearchDonor = new System.Windows.Forms.GroupBox();
            this.labelDonorDatabase = new System.Windows.Forms.Label();
            this.labelSearchResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelCurrentFunds = new System.Windows.Forms.Label();
            this.buttonReportAndReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonorsDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.groupBoxSearchDonor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDonorsDatabase
            // 
            this.dataGridViewDonorsDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonorsDatabase.Location = new System.Drawing.Point(22, 37);
            this.dataGridViewDonorsDatabase.Name = "dataGridViewDonorsDatabase";
            this.dataGridViewDonorsDatabase.RowHeadersWidth = 62;
            this.dataGridViewDonorsDatabase.Size = new System.Drawing.Size(745, 152);
            this.dataGridViewDonorsDatabase.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 22);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(15, 37);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(125, 22);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(128, 37);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelDateOfBirth
            // 
            this.labelDateOfBirth.AutoSize = true;
            this.labelDateOfBirth.Location = new System.Drawing.Point(238, 22);
            this.labelDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateOfBirth.Name = "labelDateOfBirth";
            this.labelDateOfBirth.Size = new System.Drawing.Size(68, 13);
            this.labelDateOfBirth.TabIndex = 5;
            this.labelDateOfBirth.Text = "Date of birth:";
            // 
            // textBoxDateOfBirth
            // 
            this.textBoxDateOfBirth.Location = new System.Drawing.Point(241, 37);
            this.textBoxDateOfBirth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDateOfBirth.Name = "textBoxDateOfBirth";
            this.textBoxDateOfBirth.Size = new System.Drawing.Size(100, 20);
            this.textBoxDateOfBirth.TabIndex = 6;
            // 
            // buttonSearchDonor
            // 
            this.buttonSearchDonor.Location = new System.Drawing.Point(15, 80);
            this.buttonSearchDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSearchDonor.Name = "buttonSearchDonor";
            this.buttonSearchDonor.Size = new System.Drawing.Size(81, 25);
            this.buttonSearchDonor.TabIndex = 7;
            this.buttonSearchDonor.Text = "Search";
            this.buttonSearchDonor.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(22, 373);
            this.dataGridViewSearchResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.RowHeadersWidth = 62;
            this.dataGridViewSearchResult.RowTemplate.Height = 28;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(745, 122);
            this.dataGridViewSearchResult.TabIndex = 8;
            // 
            // labelCurrentFundsLabel
            // 
            this.labelCurrentFundsLabel.AutoSize = true;
            this.labelCurrentFundsLabel.Location = new System.Drawing.Point(5, 37);
            this.labelCurrentFundsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentFundsLabel.Name = "labelCurrentFundsLabel";
            this.labelCurrentFundsLabel.Size = new System.Drawing.Size(76, 13);
            this.labelCurrentFundsLabel.TabIndex = 9;
            this.labelCurrentFundsLabel.Text = "Current Funds:";
            // 
            // buttonMakeDonation
            // 
            this.buttonMakeDonation.Location = new System.Drawing.Point(113, 514);
            this.buttonMakeDonation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMakeDonation.Name = "buttonMakeDonation";
            this.buttonMakeDonation.Size = new System.Drawing.Size(73, 45);
            this.buttonMakeDonation.TabIndex = 11;
            this.buttonMakeDonation.Text = "Make a Donation";
            this.buttonMakeDonation.UseVisualStyleBackColor = true;
            // 
            // buttonWithdrawBlood
            // 
            this.buttonWithdrawBlood.Location = new System.Drawing.Point(437, 514);
            this.buttonWithdrawBlood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonWithdrawBlood.Name = "buttonWithdrawBlood";
            this.buttonWithdrawBlood.Size = new System.Drawing.Size(75, 45);
            this.buttonWithdrawBlood.TabIndex = 12;
            this.buttonWithdrawBlood.Text = "Withdraw Blood";
            this.buttonWithdrawBlood.UseVisualStyleBackColor = true;
            // 
            // buttonAddNewDonor
            // 
            this.buttonAddNewDonor.Location = new System.Drawing.Point(234, 514);
            this.buttonAddNewDonor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddNewDonor.Name = "buttonAddNewDonor";
            this.buttonAddNewDonor.Size = new System.Drawing.Size(62, 45);
            this.buttonAddNewDonor.TabIndex = 13;
            this.buttonAddNewDonor.Text = "Add New Donor";
            this.buttonAddNewDonor.UseVisualStyleBackColor = true;
            // 
            // buttonBloodBank
            // 
            this.buttonBloodBank.Location = new System.Drawing.Point(218, 37);
            this.buttonBloodBank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBloodBank.Name = "buttonBloodBank";
            this.buttonBloodBank.Size = new System.Drawing.Size(108, 68);
            this.buttonBloodBank.TabIndex = 14;
            this.buttonBloodBank.Text = "Blood Bank";
            this.buttonBloodBank.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(334, 514);
            this.buttonAddClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(57, 45);
            this.buttonAddClient.TabIndex = 15;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(128, 80);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 25);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchDonor
            // 
            this.groupBoxSearchDonor.Controls.Add(this.buttonReset);
            this.groupBoxSearchDonor.Controls.Add(this.textBoxLastName);
            this.groupBoxSearchDonor.Controls.Add(this.labelFirstName);
            this.groupBoxSearchDonor.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearchDonor.Controls.Add(this.labelLastName);
            this.groupBoxSearchDonor.Controls.Add(this.labelDateOfBirth);
            this.groupBoxSearchDonor.Controls.Add(this.textBoxDateOfBirth);
            this.groupBoxSearchDonor.Controls.Add(this.buttonSearchDonor);
            this.groupBoxSearchDonor.Location = new System.Drawing.Point(22, 211);
            this.groupBoxSearchDonor.Name = "groupBoxSearchDonor";
            this.groupBoxSearchDonor.Size = new System.Drawing.Size(369, 129);
            this.groupBoxSearchDonor.TabIndex = 17;
            this.groupBoxSearchDonor.TabStop = false;
            this.groupBoxSearchDonor.Text = "Search Donor";
            // 
            // labelDonorDatabase
            // 
            this.labelDonorDatabase.AutoSize = true;
            this.labelDonorDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDonorDatabase.Location = new System.Drawing.Point(19, 21);
            this.labelDonorDatabase.Name = "labelDonorDatabase";
            this.labelDonorDatabase.Size = new System.Drawing.Size(99, 13);
            this.labelDonorDatabase.TabIndex = 18;
            this.labelDonorDatabase.Text = "Donor Database";
            // 
            // labelSearchResult
            // 
            this.labelSearchResult.AutoSize = true;
            this.labelSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchResult.Location = new System.Drawing.Point(22, 358);
            this.labelSearchResult.Name = "labelSearchResult";
            this.labelSearchResult.Size = new System.Drawing.Size(87, 13);
            this.labelSearchResult.TabIndex = 19;
            this.labelSearchResult.Text = "Search Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCurrentFunds);
            this.groupBox1.Controls.Add(this.labelCurrentFundsLabel);
            this.groupBox1.Controls.Add(this.buttonBloodBank);
            this.groupBox1.Location = new System.Drawing.Point(397, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 129);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funds";
            // 
            // labelCurrentFunds
            // 
            this.labelCurrentFunds.AutoSize = true;
            this.labelCurrentFunds.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentFunds.Location = new System.Drawing.Point(86, 37);
            this.labelCurrentFunds.MaximumSize = new System.Drawing.Size(80, 0);
            this.labelCurrentFunds.MinimumSize = new System.Drawing.Size(80, 0);
            this.labelCurrentFunds.Name = "labelCurrentFunds";
            this.labelCurrentFunds.Size = new System.Drawing.Size(80, 15);
            this.labelCurrentFunds.TabIndex = 10;
            // 
            // buttonReportAndReport
            // 
            this.buttonReportAndReport.Location = new System.Drawing.Point(573, 514);
            this.buttonReportAndReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReportAndReport.Name = "buttonReportAndReport";
            this.buttonReportAndReport.Size = new System.Drawing.Size(94, 45);
            this.buttonReportAndReport.TabIndex = 21;
            this.buttonReportAndReport.Text = "Generate Report and Backup";
            this.buttonReportAndReport.UseVisualStyleBackColor = true;
            // 
            // BloodBankAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(789, 647);
            this.Controls.Add(this.buttonReportAndReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelSearchResult);
            this.Controls.Add(this.labelDonorDatabase);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.buttonAddNewDonor);
            this.Controls.Add(this.buttonWithdrawBlood);
            this.Controls.Add(this.buttonMakeDonation);
            this.Controls.Add(this.dataGridViewSearchResult);
            this.Controls.Add(this.dataGridViewDonorsDatabase);
            this.Controls.Add(this.groupBoxSearchDonor);
            this.Name = "BloodBankAppMainForm";
            this.Text = "Blood Bank Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonorsDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.groupBoxSearchDonor.ResumeLayout(false);
            this.groupBoxSearchDonor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDonorsDatabase;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDateOfBirth;
        private System.Windows.Forms.TextBox textBoxDateOfBirth;
        private System.Windows.Forms.Button buttonSearchDonor;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.Label labelCurrentFundsLabel;
        private System.Windows.Forms.Button buttonMakeDonation;
        private System.Windows.Forms.Button buttonWithdrawBlood;
        private System.Windows.Forms.Button buttonAddNewDonor;
        private System.Windows.Forms.Button buttonBloodBank;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.GroupBox groupBoxSearchDonor;
        private System.Windows.Forms.Label labelDonorDatabase;
        private System.Windows.Forms.Label labelSearchResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCurrentFunds;
        private System.Windows.Forms.Button buttonReportAndReport;
    }
}

