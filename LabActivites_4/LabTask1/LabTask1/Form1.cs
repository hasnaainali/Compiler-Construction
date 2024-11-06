using System;
using System.Text;
using System.Windows.Forms;

namespace LabTask1
{
    public partial class Form1 : Form
    {
        private string buffer1;
        private string buffer2;
        private int bufferSize;

        public Form1()
        {
            InitializeComponent();
            bufferSize = 256; // Size of each buffer
            buffer1 = string.Empty;
            buffer2 = string.Empty;
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            string inputText = inputTextBox.Text;
            LexicalAnalysis(inputText);
        }

        private void LexicalAnalysis(string input)
        {
            StringBuilder result = new StringBuilder();
            int currentIndex = 0;
            bool useBuffer1 = true;

            while (currentIndex < input.Length)
            {
                // Fill the buffer
                if (useBuffer1)
                {
                    buffer1 = input.Substring(currentIndex, Math.Min(bufferSize, input.Length - currentIndex));
                    currentIndex += bufferSize;
                }
                else
                {
                    buffer2 = input.Substring(currentIndex, Math.Min(bufferSize, input.Length - currentIndex));
                    currentIndex += bufferSize;
                }

                // Analyze current buffer
                string currentBuffer = useBuffer1 ? buffer1 : buffer2;
                result.AppendLine($"Analyzing buffer: {currentBuffer}");

                // Switch buffer
                useBuffer1 = !useBuffer1;
            }

            outputTextBox.Text = result.ToString();
        }
    }
}
