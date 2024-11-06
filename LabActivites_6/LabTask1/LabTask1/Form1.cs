using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        private Dictionary<string, List<string>> grammarRules;
        private Dictionary<string, HashSet<string>> firstSets;

        public Form1()
        {
            InitializeComponent();
            grammarRules = new Dictionary<string, List<string>>()
            {
                { "Statement", new List<string> { "if ( Expression ) Statement", "while ( Expression ) Statement", "{ Statements }", "id = Expression ;" } },
                { "Expression", new List<string> { "id", "number", "id + number", "id * number" } },
                { "Statements", new List<string> { "Statement Statements", "ε" } }
            };

            firstSets = new Dictionary<string, HashSet<string>>();

            // Initialize First sets for all non-terminals
            foreach (var nonTerminal in grammarRules.Keys)
            {
                firstSets[nonTerminal] = new HashSet<string>();
            }

            ComputeFirstSets();
        }

        private void ComputeFirstSets()
        {
            // Compute First set for all non-terminals
            foreach (var nonTerminal in grammarRules.Keys)
            {
                ComputeFirstSet(nonTerminal);
            }

            // Display the First Sets in the ListBox
            lstFirstSets.Items.Clear();
            foreach (var nonTerminal in firstSets)
            {
                lstFirstSets.Items.Add($"{nonTerminal.Key} : {string.Join(", ", nonTerminal.Value)}");
            }
        }

        private void ComputeFirstSet(string nonTerminal)
        {
            // If the first set for the non-terminal is already computed, return
            if (firstSets[nonTerminal].Count > 0)
                return;

            foreach (var production in grammarRules[nonTerminal])
            {
                foreach (var symbol in production.Split(' '))
                {
                    if (char.IsLower(symbol[0])) // Terminal symbol (assuming lowercase for terminals like id, number)
                    {
                        firstSets[nonTerminal].Add(symbol);
                        break;
                    }
                    else // Non-terminal symbol
                    {
                        if (!firstSets.ContainsKey(symbol))
                        {
                            firstSets[symbol] = new HashSet<string>();
                        }
                        ComputeFirstSet(symbol);
                        foreach (var firstSymbol in firstSets[symbol])
                        {
                            firstSets[nonTerminal].Add(firstSymbol);
                        }

                        // If epsilon is in the First set of the symbol, continue to next symbol
                        if (firstSets[symbol].Contains("ε"))
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
        }

        private void btnComputeFirstSets_Click(object sender, EventArgs e)
        {
            ComputeFirstSets();
        }
    }
}
