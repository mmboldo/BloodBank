
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
            this.dataGridViewDonars = new System.Windows.Forms.DataGridView();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.textBoxDOB = new System.Windows.Forms.TextBox();
            this.buttonSearchDonar = new System.Windows.Forms.Button();
            this.dataGridViewSelectedDonars = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCurrentFunds = new System.Windows.Forms.TextBox();
            this.buttonMakeDonation = new System.Windows.Forms.Button();
            this.buttonWithdrawBlood = new System.Windows.Forms.Button();
            this.buttonAddDonar = new System.Windows.Forms.Button();
            this.buttonBloodBank = new System.Windows.Forms.Button();
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedDonars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDonars
            // 
            this.dataGridViewDonars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonars.Location = new System.Drawing.Point(33, 29);
            this.dataGridViewDonars.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewDonars.Name = "dataGridViewDonars";
            this.dataGridViewDonars.RowHeadersWidth = 62;
            this.dataGridViewDonars.Size = new System.Drawing.Size(787, 234);
            this.dataGridViewDonars.TabIndex = 0;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(124, 280);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(211, 280);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 26);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(346, 280);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 3;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(432, 280);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 26);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(575, 280);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(44, 20);
            this.labelDOB.TabIndex = 5;
            this.labelDOB.Text = "DOB";
            // 
            // textBoxDOB
            // 
            this.textBoxDOB.Location = new System.Drawing.Point(621, 280);
            this.textBoxDOB.Name = "textBoxDOB";
            this.textBoxDOB.Size = new System.Drawing.Size(100, 26);
            this.textBoxDOB.TabIndex = 6;
            // 
            // buttonSearchDonar
            // 
            this.buttonSearchDonar.Location = new System.Drawing.Point(377, 316);
            this.buttonSearchDonar.Name = "buttonSearchDonar";
            this.buttonSearchDonar.Size = new System.Drawing.Size(91, 39);
            this.buttonSearchDonar.TabIndex = 7;
            this.buttonSearchDonar.Text = "Search";
            this.buttonSearchDonar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelectedDonars
            // 
            this.dataGridViewSelectedDonars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelectedDonars.Location = new System.Drawing.Point(33, 361);
            this.dataGridViewSelectedDonars.Name = "dataGridViewSelectedDonars";
            this.dataGridViewSelectedDonars.RowHeadersWidth = 62;
            this.dataGridViewSelectedDonars.RowTemplate.Height = 28;
            this.dataGridViewSelectedDonars.Size = new System.Drawing.Size(816, 191);
            this.dataGridViewSelectedDonars.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 664);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Funds";
            // 
            // textBoxCurrentFunds
            // 
            this.textBoxCurrentFunds.Location = new System.Drawing.Point(158, 664);
            this.textBoxCurrentFunds.Name = "textBoxCurrentFunds";
            this.textBoxCurrentFunds.Size = new System.Drawing.Size(100, 26);
            this.textBoxCurrentFunds.TabIndex = 10;
            // 
            // buttonMakeDonation
            // 
            this.buttonMakeDonation.Location = new System.Drawing.Point(98, 577);
            this.buttonMakeDonation.Name = "buttonMakeDonation";
            this.buttonMakeDonation.Size = new System.Drawing.Size(109, 70);
            this.buttonMakeDonation.TabIndex = 11;
            this.buttonMakeDonation.Text = "Make Donation";
            this.buttonMakeDonation.UseVisualStyleBackColor = true;
            // 
            // buttonWithdrawBlood
            // 
            this.buttonWithdrawBlood.Location = new System.Drawing.Point(242, 577);
            this.buttonWithdrawBlood.Name = "buttonWithdrawBlood";
            this.buttonWithdrawBlood.Size = new System.Drawing.Size(112, 70);
            this.buttonWithdrawBlood.TabIndex = 12;
            this.buttonWithdrawBlood.Text = "Withdraw Blood";
            this.buttonWithdrawBlood.UseVisualStyleBackColor = true;
            // 
            // buttonAddDonar
            // 
            this.buttonAddDonar.Location = new System.Drawing.Point(382, 577);
            this.buttonAddDonar.Name = "buttonAddDonar";
            this.buttonAddDonar.Size = new System.Drawing.Size(86, 70);
            this.buttonAddDonar.TabIndex = 13;
            this.buttonAddDonar.Text = "Add Donar";
            this.buttonAddDonar.UseVisualStyleBackColor = true;
            // 
            // buttonBloodBank
            // 
            this.buttonBloodBank.Location = new System.Drawing.Point(497, 577);
            this.buttonBloodBank.Name = "buttonBloodBank";
            this.buttonBloodBank.Size = new System.Drawing.Size(78, 70);
            this.buttonBloodBank.TabIndex = 14;
            this.buttonBloodBank.Text = "Blood Bank";
            this.buttonBloodBank.UseVisualStyleBackColor = true;
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(604, 577);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(86, 70);
            this.buttonAddClient.TabIndex = 15;
            this.buttonAddClient.Text = "Add Client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(266, 316);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 38);
            this.buttonReset.TabIndex = 16;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            // 
            // BloodBankAppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(861, 702);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.buttonBloodBank);
            this.Controls.Add(this.buttonAddDonar);
            this.Controls.Add(this.buttonWithdrawBlood);
            this.Controls.Add(this.buttonMakeDonation);
            this.Controls.Add(this.textBoxCurrentFunds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewSelectedDonars);
            this.Controls.Add(this.buttonSearchDonar);
            this.Controls.Add(this.textBoxDOB);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.dataGridViewDonars);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BloodBankAppMainForm";
            this.Text = "Blood Bank Management System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelectedDonars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDonars;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.TextBox textBoxDOB;
        private System.Windows.Forms.Button buttonSearchDonar;
        private System.Windows.Forms.DataGridView dataGridViewSelectedDonars;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCurrentFunds;
        private System.Windows.Forms.Button buttonMakeDonation;
        private System.Windows.Forms.Button buttonWithdrawBlood;
        private System.Windows.Forms.Button buttonAddDonar;
        private System.Windows.Forms.Button buttonBloodBank;
        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.Button buttonReset;
    }
}

