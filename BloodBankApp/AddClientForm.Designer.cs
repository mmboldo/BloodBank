namespace BloodBankApp
{
    partial class AddClientForm
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
            this.labelAddClientTitle = new System.Windows.Forms.Label();
            this.labelAddClientFirstName = new System.Windows.Forms.Label();
            this.textBoxAddClientFirstName = new System.Windows.Forms.TextBox();
            this.labelAddClientLastName = new System.Windows.Forms.Label();
            this.textBoxAddClientLastName = new System.Windows.Forms.TextBox();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAddClientTitle
            // 
            this.labelAddClientTitle.AutoSize = true;
            this.labelAddClientTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAddClientTitle.Location = new System.Drawing.Point(34, 25);
            this.labelAddClientTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddClientTitle.Name = "labelAddClientTitle";
            this.labelAddClientTitle.Size = new System.Drawing.Size(170, 15);
            this.labelAddClientTitle.TabIndex = 0;
            this.labelAddClientTitle.Text = "Fill the following form to add client:";
            // 
            // labelAddClientFirstName
            // 
            this.labelAddClientFirstName.AutoSize = true;
            this.labelAddClientFirstName.Location = new System.Drawing.Point(50, 67);
            this.labelAddClientFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddClientFirstName.Name = "labelAddClientFirstName";
            this.labelAddClientFirstName.Size = new System.Drawing.Size(60, 13);
            this.labelAddClientFirstName.TabIndex = 3;
            this.labelAddClientFirstName.Text = "First Name:";
            // 
            // textBoxAddClientFirstName
            // 
            this.textBoxAddClientFirstName.Location = new System.Drawing.Point(114, 64);
            this.textBoxAddClientFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddClientFirstName.Name = "textBoxAddClientFirstName";
            this.textBoxAddClientFirstName.Size = new System.Drawing.Size(68, 20);
            this.textBoxAddClientFirstName.TabIndex = 4;
            // 
            // labelAddClientLastName
            // 
            this.labelAddClientLastName.AutoSize = true;
            this.labelAddClientLastName.Location = new System.Drawing.Point(50, 117);
            this.labelAddClientLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddClientLastName.Name = "labelAddClientLastName";
            this.labelAddClientLastName.Size = new System.Drawing.Size(61, 13);
            this.labelAddClientLastName.TabIndex = 5;
            this.labelAddClientLastName.Text = "Last Name:";
            // 
            // textBoxAddClientLastName
            // 
            this.textBoxAddClientLastName.Location = new System.Drawing.Point(114, 114);
            this.textBoxAddClientLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAddClientLastName.Name = "textBoxAddClientLastName";
            this.textBoxAddClientLastName.Size = new System.Drawing.Size(68, 20);
            this.textBoxAddClientLastName.TabIndex = 6;
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.Location = new System.Drawing.Point(78, 166);
            this.buttonAddNewClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(66, 27);
            this.buttonAddNewClient.TabIndex = 7;
            this.buttonAddNewClient.Text = "Add";
            this.buttonAddNewClient.UseVisualStyleBackColor = true;
            // 
            // AddClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 243);
            this.Controls.Add(this.buttonAddNewClient);
            this.Controls.Add(this.textBoxAddClientLastName);
            this.Controls.Add(this.labelAddClientLastName);
            this.Controls.Add(this.textBoxAddClientFirstName);
            this.Controls.Add(this.labelAddClientFirstName);
            this.Controls.Add(this.labelAddClientTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddClientForm";
            this.Text = "AddClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAddClientTitle;
        private System.Windows.Forms.Label labelAddClientFirstName;
        private System.Windows.Forms.TextBox textBoxAddClientFirstName;
        private System.Windows.Forms.Label labelAddClientLastName;
        private System.Windows.Forms.TextBox textBoxAddClientLastName;
        private System.Windows.Forms.Button buttonAddNewClient;
    }
}