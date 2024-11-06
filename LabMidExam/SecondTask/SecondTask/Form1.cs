using System;
using System.Windows.Forms;

namespace RemoteCarController
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string command = txtCommand.Text.Trim().ToLower();
            string result = ExecuteCommand(command);
            lblOutput.Text = result; 
        }

        private string ExecuteCommand(string command)
        {
            switch (command)
            {
                case "start":
                    return "Valid command: The car has started.";
                case "stop":
                    return "Valid command: The car has stopped.";
                case "accelerate":
                    return "Valid command: The car is accelerating.";
                case "right":
                    return "Valid command: The car turned right.";
                case "left":
                    return "Error: The car cannot turn left.";
                default:
                    return "Error: Command not recognized.";
            }
        }
    }
}
