namespace BloodBankApp
{
    partial class BloodBankStatusForm
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
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewDonations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewWithdrawals = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdrawals)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.AllowUserToAddRows = false;
            this.dataGridViewStock.AllowUserToDeleteRows = false;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(12, 28);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.ReadOnly = true;
            this.dataGridViewStock.Size = new System.Drawing.Size(776, 184);
            this.dataGridViewStock.TabIndex = 0;
            // 
            // dataGridViewDonations
            // 
            this.dataGridViewDonations.AllowUserToAddRows = false;
            this.dataGridViewDonations.AllowUserToDeleteRows = false;
            this.dataGridViewDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDonations.Location = new System.Drawing.Point(12, 254);
            this.dataGridViewDonations.Name = "dataGridViewDonations";
            this.dataGridViewDonations.ReadOnly = true;
            this.dataGridViewDonations.Size = new System.Drawing.Size(776, 184);
            this.dataGridViewDonations.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Donations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Blood Bank Stock";
            // 
            // dataGridViewWithdrawals
            // 
            this.dataGridViewWithdrawals.AllowUserToAddRows = false;
            this.dataGridViewWithdrawals.AllowUserToDeleteRows = false;
            this.dataGridViewWithdrawals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWithdrawals.Location = new System.Drawing.Point(16, 488);
            this.dataGridViewWithdrawals.Name = "dataGridViewWithdrawals";
            this.dataGridViewWithdrawals.ReadOnly = true;
            this.dataGridViewWithdrawals.Size = new System.Drawing.Size(776, 184);
            this.dataGridViewWithdrawals.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Withdrawals";
            // 
            // BloodBankStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewWithdrawals);
            this.Controls.Add(this.dataGridViewDonations);
            this.Controls.Add(this.dataGridViewStock);
            this.Name = "BloodBankStatusForm";
            this.Text = "BloodBankStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDonations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWithdrawals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridView dataGridViewDonations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewWithdrawals;
        private System.Windows.Forms.Label label3;
    }
}