namespace Activity1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstFirstSets;
        private System.Windows.Forms.Button btnComputeFirstSets;

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
            this.lstFirstSets = new System.Windows.Forms.ListBox();
            this.btnComputeFirstSets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFirstSets
            // 
            this.lstFirstSets.FormattingEnabled = true;
            this.lstFirstSets.ItemHeight = 15;
            this.lstFirstSets.Location = new System.Drawing.Point(12, 41);
            this.lstFirstSets.Name = "lstFirstSets";
            this.lstFirstSets.Size = new System.Drawing.Size(337, 199);
            this.lstFirstSets.TabIndex = 0;
            // 
            // btnComputeFirstSets
            // 
            this.btnComputeFirstSets.Location = new System.Drawing.Point(12, 12);
            this.btnComputeFirstSets.Name = "btnComputeFirstSets";
            this.btnComputeFirstSets.Size = new System.Drawing.Size(150, 23);
            this.btnComputeFirstSets.TabIndex = 1;
            this.btnComputeFirstSets.Text = "Compute First Sets";
            this.btnComputeFirstSets.UseVisualStyleBackColor = true;
            this.btnComputeFirstSets.Click += new System.EventHandler(this.btnComputeFirstSets_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.btnComputeFirstSets);
            this.Controls.Add(this.lstFirstSets);
            this.Name = "Form1";
            this.Text = "First Set Computation";
            this.ResumeLayout(false);
        }
    }
}
