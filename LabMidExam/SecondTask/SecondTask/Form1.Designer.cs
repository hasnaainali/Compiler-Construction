namespace RemoteCarController
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInstructions;

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
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            this.txtCommand.Location = new System.Drawing.Point(15, 35);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(200, 20);
            this.txtCommand.TabIndex = 0;
            
            this.btnSubmit.Location = new System.Drawing.Point(220, 33);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(15, 70);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 2;
            
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(15, 15);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(126, 13);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Enter command (start, stop, accelerate, right, left):";
            
            this.ClientSize = new System.Drawing.Size(310, 120);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtCommand);
            this.Name = "Form1";
            this.Text = "Remote Car Controller";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
