using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            string pattern = @"^-?\d{1,4}(\.\d{1,2})?$";
            if (Regex.IsMatch(input, pattern))
            {
                lblResult.Text = "Valid floating-point number";
            }
            else
            {
                lblResult.Text = "Invalid floating-point number";
            }
        }
    }
}
