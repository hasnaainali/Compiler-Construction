using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Activity1
{
    public partial class Form1 : Form
    {
        // Grammar rules stored in a dictionary (non-terminal -> list of productions)
        private Dictionary<string, List<string>> grammarRules = new Dictionary<string, List<string>>();
        private Dictionary<string, HashSet<string>> firstSets = new Dictionary<string, HashSet<string>>();
        private Dictionary<string, HashSet<string>> followSets = new Dictionary<string, HashSet<string>>();

        public Form1()
        {
            InitializeComponent();
            InitializeGrammar();
        }

        // Initialize grammar rules for demonstration
        private void InitializeGrammar()
        {
            grammarRules.Add("S", new List<string> { "AB", "a" });
            grammarRules.Add("A", new List<string> { "BC", "b" });
            grammarRules.Add("B", new List<string> { "d", "ε" });
            grammarRules.Add("C", new List<string> { "e" });

            // Initialize first and follow sets
            foreach (var nonTerminal in grammarRules.Keys)
            {
                firstSets[nonTerminal] = new HashSet<string>();
                followSets[nonTerminal] = new HashSet<string>();
            }

            // Add $ to Follow(S) as the starting symbol
            followSets["S"].Add("$");
        }

        // Calculate the First sets for all non-terminals
        private void CalculateFirstSets()
        {
            bool changesMade;

            do
            {
                changesMade = false;

                foreach (var nonTerminal in grammarRules.Keys)
                {
                    foreach (var production in grammarRules[nonTerminal])
                    {
                        // Process each symbol in the production
                        foreach (var symbol in production)
                        {
                            string symbolStr = symbol.ToString();

                            if (char.IsLower(symbolStr[0])) // Terminal
                            {
                                if (!firstSets[nonTerminal].Contains(symbolStr))
                                {
                                    firstSets[nonTerminal].Add(symbolStr);
                                    changesMade = true;
                                }
                                break;
                            }
                            else // Non-terminal
                            {
                                foreach (var firstSymbol in firstSets[symbolStr])
                                {
                                    if (!firstSets[nonTerminal].Contains(firstSymbol) && firstSymbol != "ε")
                                    {
                                        firstSets[nonTerminal].Add(firstSymbol);
                                        changesMade = true;
                                    }
                                }

                                // If the first set contains ε, we need to continue looking at the next symbol
                                if (!firstSets[symbolStr].Contains("ε"))
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            } while (changesMade);
        }

        // Calculate the Follow sets for all non-terminals
        private void CalculateFollowSets()
        {
            bool changesMade;

            do
            {
                changesMade = false;

                foreach (var nonTerminal in grammarRules.Keys)
                {
                    foreach (var production in grammarRules[nonTerminal])
                    {
                        for (int i = 0; i < production.Length; i++)
                        {
                            string currentSymbol = production[i].ToString();

                            if (char.IsUpper(currentSymbol[0])) // Non-terminal symbol
                            {
                                // If we are at the end of the production, add Follow(nonTerminal) to Follow(currentSymbol)
                                if (i == production.Length - 1)
                                {
                                    foreach (var followSymbol in followSets[nonTerminal])
                                    {
                                        if (!followSets[currentSymbol].Contains(followSymbol))
                                        {
                                            followSets[currentSymbol].Add(followSymbol);
                                            changesMade = true;
                                        }
                                    }
                                }
                                else // Look ahead symbol
                                {
                                    string nextSymbol = production[i + 1].ToString();

                                    if (char.IsLower(nextSymbol[0])) // Terminal symbol
                                    {
                                        if (!followSets[currentSymbol].Contains(nextSymbol))
                                        {
                                            followSets[currentSymbol].Add(nextSymbol);
                                            changesMade = true;
                                        }
                                    }
                                    else // Non-terminal symbol
                                    {
                                        foreach (var firstSymbol in firstSets[nextSymbol])
                                        {
                                            if (firstSymbol != "ε" && !followSets[currentSymbol].Contains(firstSymbol))
                                            {
                                                followSets[currentSymbol].Add(firstSymbol);
                                                changesMade = true;
                                            }
                                        }

                                        // If the next symbol can derive ε, add Follow(nonTerminal) to Follow(currentSymbol)
                                        if (firstSets[nextSymbol].Contains("ε"))
                                        {
                                            foreach (var followSymbol in followSets[nonTerminal])
                                            {
                                                if (!followSets[currentSymbol].Contains(followSymbol))
                                                {
                                                    followSets[currentSymbol].Add(followSymbol);
                                                    changesMade = true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            } while (changesMade);
        }

        // Display the results for First and Follow sets
        private void DisplayResults()
        {
            textBoxResults.Text = "First Sets:\n";
            foreach (var nonTerminal in firstSets.Keys)
            {
                textBoxResults.AppendText($"{nonTerminal}: {{ {string.Join(", ", firstSets[nonTerminal])} }}\n");
            }

            textBoxResults.AppendText("\nFollow Sets:\n");
            foreach (var nonTerminal in followSets.Keys)
            {
                textBoxResults.AppendText($"{nonTerminal}: {{ {string.Join(", ", followSets[nonTerminal])} }}\n");
            }
        }

        // Button click event to calculate First and Follow sets
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateFirstSets();
            CalculateFollowSets();
            DisplayResults();
        }
    }
}
