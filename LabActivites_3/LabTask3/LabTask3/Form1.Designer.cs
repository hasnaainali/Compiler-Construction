namespace LabTask3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDocument;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFindWords;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTitle;

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
            this.txtDocument = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnFindWords = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();

            // Title Label
            this.lblTitle.Text = "Word Finder Application";
            this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(120, 10);
            this.lblTitle.Size = new System.Drawing.Size(250, 30);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtDocument
            this.txtDocument.Location = new System.Drawing.Point(30, 50);
            this.txtDocument.Multiline = true;
            this.txtDocument.Name = "txtDocument";
            this.txtDocument.Size = new System.Drawing.Size(400, 100);
            this.txtDocument.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDocument.Padding = new System.Windows.Forms.Padding(5);

            // dataGridView1
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.Add("MatchedWords", "Matched Words");
            this.dataGridView1.Location = new System.Drawing.Point(30, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(400, 200);

            // btnFindWords
            this.btnFindWords.Location = new System.Drawing.Point(30, 390);
            this.btnFindWords.Name = "btnFindWords";
            this.btnFindWords.Size = new System.Drawing.Size(100, 40);
            this.btnFindWords.Text = "Find Words";
            this.btnFindWords.BackColor = System.Drawing.Color.LightGreen;
            this.btnFindWords.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnFindWords.Click += new System.EventHandler(this.btnFindWords_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(150, 390);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.Text = "Clear";
            this.btnClear.BackColor = System.Drawing.Color.Salmon;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnEdit
            this.btnEdit.Location = new System.Drawing.Point(270, 390);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.Text = "Edit";
            this.btnEdit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtDocument);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFindWords);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Name = "Form1";
            this.Text = "Word Finder";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
