namespace FirstTask // Ensure this matches
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(265, 13);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter your first name, last name, and registration number:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(15, 25);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 1;
            this.txtFirstName.PlaceholderText = "First Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 25);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 2;
            this.txtLastName.PlaceholderText = "Last Name";
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(227, 25);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRegNumber.TabIndex = 3;
            this.txtRegNumber.PlaceholderText = "Reg Number";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(15, 51);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(312, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate Password";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(15, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(312, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.PlaceholderText = "Generated Password";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 121);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtRegNumber);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblInstructions);
            this.Name = "Form1";
            this.Text = "Password Generator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPassword;
    }
}
