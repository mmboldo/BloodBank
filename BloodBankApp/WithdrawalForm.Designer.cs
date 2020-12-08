namespace BloodBankApp
{
    partial class WithdrawalForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonWithdrawBlood = new System.Windows.Forms.Button();
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCurrentBalance = new System.Windows.Forms.GroupBox();
            this.labelCurrentBalanceLabel = new System.Windows.Forms.Label();
            this.labelCurrentBalance = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.groupBoxCurrentBalance.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blood Bank Stock";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(36, 389);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cost";
            // 
            // buttonWithdrawBlood
            // 
            this.buttonWithdrawBlood.Location = new System.Drawing.Point(45, 415);
            this.buttonWithdrawBlood.Name = "buttonWithdrawBlood";
            this.buttonWithdrawBlood.Size = new System.Drawing.Size(75, 23);
            this.buttonWithdrawBlood.TabIndex = 3;
            this.buttonWithdrawBlood.Text = "Withdraw";
            this.buttonWithdrawBlood.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Location = new System.Drawing.Point(16, 29);
            this.dataGridViewStock.MultiSelect = false;
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStock.Size = new System.Drawing.Size(606, 150);
            this.dataGridViewStock.TabIndex = 4;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(16, 219);
            this.dataGridViewClient.MultiSelect = false;
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(606, 150);
            this.dataGridViewClient.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Client";
            // 
            // groupBoxCurrentBalance
            // 
            this.groupBoxCurrentBalance.Controls.Add(this.labelCurrentBalanceLabel);
            this.groupBoxCurrentBalance.Controls.Add(this.labelCurrentBalance);
            this.groupBoxCurrentBalance.Location = new System.Drawing.Point(497, 389);
            this.groupBoxCurrentBalance.Name = "groupBoxCurrentBalance";
            this.groupBoxCurrentBalance.Size = new System.Drawing.Size(125, 45);
            this.groupBoxCurrentBalance.TabIndex = 7;
            this.groupBoxCurrentBalance.TabStop = false;
            this.groupBoxCurrentBalance.Text = "Current Balance";
            // 
            // labelCurrentBalanceLabel
            // 
            this.labelCurrentBalanceLabel.AutoSize = true;
            this.labelCurrentBalanceLabel.Location = new System.Drawing.Point(12, 19);
            this.labelCurrentBalanceLabel.Name = "labelCurrentBalanceLabel";
            this.labelCurrentBalanceLabel.Size = new System.Drawing.Size(30, 13);
            this.labelCurrentBalanceLabel.TabIndex = 8;
            this.labelCurrentBalanceLabel.Text = "CA$:";
            // 
            // labelCurrentBalance
            // 
            this.labelCurrentBalance.AutoSize = true;
            this.labelCurrentBalance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurrentBalance.Location = new System.Drawing.Point(43, 19);
            this.labelCurrentBalance.MinimumSize = new System.Drawing.Size(70, 15);
            this.labelCurrentBalance.Name = "labelCurrentBalance";
            this.labelCurrentBalance.Size = new System.Drawing.Size(70, 15);
            this.labelCurrentBalance.TabIndex = 7;
            // 
            // WithdrawalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.groupBoxCurrentBalance);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.dataGridViewStock);
            this.Controls.Add(this.buttonWithdrawBlood);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "WithdrawalForm";
            this.Text = "New Withdrawal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.groupBoxCurrentBalance.ResumeLayout(false);
            this.groupBoxCurrentBalance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonWithdrawBlood;
        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxCurrentBalance;
        private System.Windows.Forms.Label labelCurrentBalanceLabel;
        private System.Windows.Forms.Label labelCurrentBalance;
    }
}