using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        private SymbolTable _symbolTable;

        public Form1()
        {
            InitializeComponent();
            _symbolTable = new SymbolTable();
        }

        private void btnAddSymbol_Click(object sender, EventArgs e)
        {
            string symbol = txtSymbol.Text;

            if (!string.IsNullOrEmpty(symbol))
            {
                _symbolTable.AddSymbol(symbol);
                lstSymbols.Items.Clear();
                foreach (var entry in _symbolTable.GetSymbols())
                {
                    lstSymbols.Items.Add(entry);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid symbol.");
            }
        }
    }
}
