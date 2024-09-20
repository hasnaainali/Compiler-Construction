using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFindWords_Click(object sender, EventArgs e)
        {
            string pattern = @"\b[tTmM]\w*\b";
            string documentText = txtDocument.Text;

            dataGridView1.Rows.Clear();

            MatchCollection matches = Regex.Matches(documentText, pattern);

            foreach (Match match in matches)
            {
                dataGridView1.Rows.Add(match.Value);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDocument.Clear();
            dataGridView1.Rows.Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtDocument.ReadOnly = false; 
        }
    }
}
