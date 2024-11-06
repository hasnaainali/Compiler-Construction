using System;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        private const int MaxSymbols = 100; // Maximum number of symbols
        private string[] table;
        private int count;

        public Form1()
        {
            InitializeComponent();
            table = new string[MaxSymbols];
            count = 0;
        }

        private void btnAddSymbol_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text;

            if (!string.IsNullOrEmpty(symbol))
            {
                AddSymbol(symbol);
                lstSymbols.Items.Clear();
                foreach (var entry in GetSymbols())
                {
                    lstSymbols.Items.Add(entry);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid symbol.");
            }
        }

        // Add symbol to the table
        private void AddSymbol(string symbol)
        {
            if (count < MaxSymbols)
            {
                table[count] = symbol;
                count++;
            }
            else
            {
                MessageBox.Show("Symbol table is full.");
            }
        }

        // Retrieve symbols from the table
        private string[] GetSymbols()
        {
            string[] symbols = new string[count];
            Array.Copy(table, symbols, count);
            return symbols;
        }
    }
}
