using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Activity1
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
                { "S", new List<string> { "AB" } },
                { "A", new List<string> { "a", "ε" } },
                { "B", new List<string> { "b", "c" } },
                { "C", new List<string> { "A", "b" } }
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
                foreach (var symbol in production)
                {
                    if (char.IsLower(symbol)) // Terminal symbol
                    {
                        firstSets[nonTerminal].Add(symbol.ToString());
                        break;
                    }
                    else // Non-terminal symbol
                    {
                        if (!firstSets.ContainsKey(symbol.ToString()))
                        {
                            firstSets[symbol.ToString()] = new HashSet<string>();
                        }
                        ComputeFirstSet(symbol.ToString());

                        foreach (var firstSymbol in firstSets[symbol.ToString()])
                        {
                            firstSets[nonTerminal].Add(firstSymbol);
                        }

                        // If epsilon is in the First set of the symbol, continue to next symbol
                        if (firstSets[symbol.ToString()].Contains("ε"))
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
