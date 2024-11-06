namespace LabTask1
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
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnAddSymbol = new System.Windows.Forms.Button();
            this.lstSymbols = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(12, 12);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(256, 20);
            this.txtSymbol.TabIndex = 0;
            // 
            // btnAddSymbol
            // 
            this.btnAddSymbol.Location = new System.Drawing.Point(274, 12);
            this.btnAddSymbol.Name = "btnAddSymbol";
            this.btnAddSymbol.Size = new System.Drawing.Size(75, 23);
            this.btnAddSymbol.TabIndex = 1;
            this.btnAddSymbol.Text = "Add Symbol";
            this.btnAddSymbol.UseVisualStyleBackColor = true;
            this.btnAddSymbol.Click += new System.EventHandler(this.btnAddSymbol_Click);
            // 
            // lstSymbols
            // 
            this.lstSymbols.FormattingEnabled = true;
            this.lstSymbols.ItemHeight = 15;
            this.lstSymbols.Location = new System.Drawing.Point(12, 41);
            this.lstSymbols.Name = "lstSymbols";
            this.lstSymbols.Size = new System.Drawing.Size(337, 199);
            this.lstSymbols.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.lstSymbols);
            this.Controls.Add(this.btnAddSymbol);
            this.Controls.Add(this.txtSymbol);
            this.Name = "Form1";
            this.Text = "Symbol Table";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnAddSymbol;
        private System.Windows.Forms.ListBox lstSymbols;
    }
}
