namespace BloodBankApp
{
    partial class ReportsAndBackupForm
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
            this.buttonbackup = new System.Windows.Forms.Button();
            this.labelShowTotalDepositedBlood = new System.Windows.Forms.Label();
            this.labelShowBloodWithdrawal = new System.Windows.Forms.Label();
            this.labelTotalAvailableBlood = new System.Windows.Forms.Label();
            this.dataGridViewBloodDeposited = new System.Windows.Forms.DataGridView();
            this.dataGridViewBloodWithdrawal = new System.Windows.Forms.DataGridView();
            this.dataGridViewAvailableBlood = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodDeposited)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodWithdrawal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableBlood)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonbackup
            // 
            this.buttonbackup.Location = new System.Drawing.Point(359, 469);
            this.buttonbackup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonbackup.Name = "buttonbackup";
            this.buttonbackup.Size = new System.Drawing.Size(99, 34);
            this.buttonbackup.TabIndex = 3;
            this.buttonbackup.Text = "Backup";
            this.buttonbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonbackup.UseVisualStyleBackColor = true;
            // 
            // labelShowTotalDepositedBlood
            // 
            this.labelShowTotalDepositedBlood.AutoSize = true;
            this.labelShowTotalDepositedBlood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelShowTotalDepositedBlood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowTotalDepositedBlood.Location = new System.Drawing.Point(27, 27);
            this.labelShowTotalDepositedBlood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowTotalDepositedBlood.Name = "labelShowTotalDepositedBlood";
            this.labelShowTotalDepositedBlood.Size = new System.Drawing.Size(75, 15);
            this.labelShowTotalDepositedBlood.TabIndex = 5;
            this.labelShowTotalDepositedBlood.Text = "Blood Deposit";
            // 
            // labelShowBloodWithdrawal
            // 
            this.labelShowBloodWithdrawal.AutoSize = true;
            this.labelShowBloodWithdrawal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelShowBloodWithdrawal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowBloodWithdrawal.Location = new System.Drawing.Point(21, 180);
            this.labelShowBloodWithdrawal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelShowBloodWithdrawal.Name = "labelShowBloodWithdrawal";
            this.labelShowBloodWithdrawal.Size = new System.Drawing.Size(92, 15);
            this.labelShowBloodWithdrawal.TabIndex = 6;
            this.labelShowBloodWithdrawal.Text = "Blood Withdrawal";
            // 
            // labelTotalAvailableBlood
            // 
            this.labelTotalAvailableBlood.AutoSize = true;
            this.labelTotalAvailableBlood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTotalAvailableBlood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAvailableBlood.Location = new System.Drawing.Point(19, 318);
            this.labelTotalAvailableBlood.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAvailableBlood.Name = "labelTotalAvailableBlood";
            this.labelTotalAvailableBlood.Size = new System.Drawing.Size(82, 15);
            this.labelTotalAvailableBlood.TabIndex = 7;
            this.labelTotalAvailableBlood.Text = "Available Blood";
            // 
            // dataGridViewBloodDeposited
            // 
            this.dataGridViewBloodDeposited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodDeposited.Location = new System.Drawing.Point(21, 43);
            this.dataGridViewBloodDeposited.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBloodDeposited.Name = "dataGridViewBloodDeposited";
            this.dataGridViewBloodDeposited.RowHeadersWidth = 62;
            this.dataGridViewBloodDeposited.RowTemplate.Height = 28;
            this.dataGridViewBloodDeposited.Size = new System.Drawing.Size(677, 126);
            this.dataGridViewBloodDeposited.TabIndex = 8;
            // 
            // dataGridViewBloodWithdrawal
            // 
            this.dataGridViewBloodWithdrawal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodWithdrawal.Location = new System.Drawing.Point(19, 196);
            this.dataGridViewBloodWithdrawal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewBloodWithdrawal.Name = "dataGridViewBloodWithdrawal";
            this.dataGridViewBloodWithdrawal.RowHeadersWidth = 62;
            this.dataGridViewBloodWithdrawal.RowTemplate.Height = 28;
            this.dataGridViewBloodWithdrawal.Size = new System.Drawing.Size(679, 114);
            this.dataGridViewBloodWithdrawal.TabIndex = 9;
            // 
            // dataGridViewAvailableBlood
            // 
            this.dataGridViewAvailableBlood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableBlood.Location = new System.Drawing.Point(19, 335);
            this.dataGridViewAvailableBlood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAvailableBlood.Name = "dataGridViewAvailableBlood";
            this.dataGridViewAvailableBlood.RowHeadersWidth = 62;
            this.dataGridViewAvailableBlood.RowTemplate.Height = 28;
            this.dataGridViewAvailableBlood.Size = new System.Drawing.Size(679, 120);
            this.dataGridViewAvailableBlood.TabIndex = 10;
            // 
            // ReportsAndBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(822, 510);
            this.Controls.Add(this.dataGridViewAvailableBlood);
            this.Controls.Add(this.dataGridViewBloodWithdrawal);
            this.Controls.Add(this.dataGridViewBloodDeposited);
            this.Controls.Add(this.labelTotalAvailableBlood);
            this.Controls.Add(this.labelShowBloodWithdrawal);
            this.Controls.Add(this.labelShowTotalDepositedBlood);
            this.Controls.Add(this.buttonbackup);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportsAndBackupForm";
            this.Text = "Reports and Backup";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodDeposited)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBloodWithdrawal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAvailableBlood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonbackup;
        private System.Windows.Forms.Label labelShowTotalDepositedBlood;
        private System.Windows.Forms.Label labelShowBloodWithdrawal;
        private System.Windows.Forms.Label labelTotalAvailableBlood;
        private System.Windows.Forms.DataGridView dataGridViewBloodDeposited;
        private System.Windows.Forms.DataGridView dataGridViewBloodWithdrawal;
        private System.Windows.Forms.DataGridView dataGridViewAvailableBlood;
    }
}