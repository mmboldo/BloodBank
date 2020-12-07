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
            this.buttonbackup.Location = new System.Drawing.Point(539, 721);
            this.buttonbackup.Name = "buttonbackup";
            this.buttonbackup.Size = new System.Drawing.Size(148, 52);
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
            this.labelShowTotalDepositedBlood.Location = new System.Drawing.Point(40, 41);
            this.labelShowTotalDepositedBlood.Name = "labelShowTotalDepositedBlood";
            this.labelShowTotalDepositedBlood.Size = new System.Drawing.Size(111, 22);
            this.labelShowTotalDepositedBlood.TabIndex = 5;
            this.labelShowTotalDepositedBlood.Text = "Blood Deposit";
            // 
            // labelShowBloodWithdrawal
            // 
            this.labelShowBloodWithdrawal.AutoSize = true;
            this.labelShowBloodWithdrawal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelShowBloodWithdrawal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelShowBloodWithdrawal.Location = new System.Drawing.Point(32, 277);
            this.labelShowBloodWithdrawal.Name = "labelShowBloodWithdrawal";
            this.labelShowBloodWithdrawal.Size = new System.Drawing.Size(134, 22);
            this.labelShowBloodWithdrawal.TabIndex = 6;
            this.labelShowBloodWithdrawal.Text = "Blood Withdrawal";
            // 
            // labelTotalAvailableBlood
            // 
            this.labelTotalAvailableBlood.AutoSize = true;
            this.labelTotalAvailableBlood.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labelTotalAvailableBlood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalAvailableBlood.Location = new System.Drawing.Point(28, 490);
            this.labelTotalAvailableBlood.Name = "labelTotalAvailableBlood";
            this.labelTotalAvailableBlood.Size = new System.Drawing.Size(119, 22);
            this.labelTotalAvailableBlood.TabIndex = 7;
            this.labelTotalAvailableBlood.Text = "Available Blood";
            // 
            // dataGridViewBloodDeposited
            // 
            this.dataGridViewBloodDeposited.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodDeposited.Location = new System.Drawing.Point(32, 66);
            this.dataGridViewBloodDeposited.Name = "dataGridViewBloodDeposited";
            this.dataGridViewBloodDeposited.RowHeadersWidth = 62;
            this.dataGridViewBloodDeposited.RowTemplate.Height = 28;
            this.dataGridViewBloodDeposited.Size = new System.Drawing.Size(1015, 194);
            this.dataGridViewBloodDeposited.TabIndex = 8;
            // 
            // dataGridViewBloodWithdrawal
            // 
            this.dataGridViewBloodWithdrawal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBloodWithdrawal.Location = new System.Drawing.Point(28, 302);
            this.dataGridViewBloodWithdrawal.Name = "dataGridViewBloodWithdrawal";
            this.dataGridViewBloodWithdrawal.RowHeadersWidth = 62;
            this.dataGridViewBloodWithdrawal.RowTemplate.Height = 28;
            this.dataGridViewBloodWithdrawal.Size = new System.Drawing.Size(1019, 176);
            this.dataGridViewBloodWithdrawal.TabIndex = 9;
            // 
            // dataGridViewAvailableBlood
            // 
            this.dataGridViewAvailableBlood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAvailableBlood.Location = new System.Drawing.Point(28, 515);
            this.dataGridViewAvailableBlood.Name = "dataGridViewAvailableBlood";
            this.dataGridViewAvailableBlood.RowHeadersWidth = 62;
            this.dataGridViewAvailableBlood.RowTemplate.Height = 28;
            this.dataGridViewAvailableBlood.Size = new System.Drawing.Size(1019, 185);
            this.dataGridViewAvailableBlood.TabIndex = 10;
            // 
            // ReportsAndBackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1233, 785);
            this.Controls.Add(this.dataGridViewAvailableBlood);
            this.Controls.Add(this.dataGridViewBloodWithdrawal);
            this.Controls.Add(this.dataGridViewBloodDeposited);
            this.Controls.Add(this.labelTotalAvailableBlood);
            this.Controls.Add(this.labelShowBloodWithdrawal);
            this.Controls.Add(this.labelShowTotalDepositedBlood);
            this.Controls.Add(this.buttonbackup);
            this.Name = "ReportsAndBackupForm";
            this.Text = "ReportsAndBackupForm";
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