namespace LabTask1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnValidate;

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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // txtInput
            this.txtInput.Location = new System.Drawing.Point(50, 50); // Placed at x=50, y=50
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 20); // Larger text box for better visibility

            // btnValidate
            this.btnValidate.Location = new System.Drawing.Point(50, 90); // Added more space between controls
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(150, 30); // Increased button size
            this.btnValidate.Text = "Validate";
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(50, 140); // Space below the button for result
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 200); // Slightly bigger form for better layout
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnValidate);
            this.Name = "Form1";
            this.Text = "Floating-Point Validator"; // Added a title for clarity
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
