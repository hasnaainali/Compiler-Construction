using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string pattern = @"^[+-]?\d+e[+-]?\d+$";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    string input = row.Cells[0].Value.ToString();
                    if (Regex.IsMatch(input, pattern))
                    {
                        row.Cells[1].Value = "Valid";
                    }
                    else
                    {
                        row.Cells[1].Value = "Invalid";
                    }
                }
            }
        }
    }
}
