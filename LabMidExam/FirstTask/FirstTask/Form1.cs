using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FirstTask // Ensure this matches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string regNumber = txtRegNumber.Text;

            string password = GeneratePassword(firstName, lastName, regNumber);
            txtPassword.Text = password;
        }

        private string GeneratePassword(string firstName, string lastName, string regNumber)
        {
            char secondLetterFirstName = firstName.Length > 1 ? firstName[1] : 'A';
            char secondLetterLastName = lastName.Length > 1 ? lastName[1] : 'A';

            StringBuilder passwordBuilder = new StringBuilder();
            passwordBuilder.Append(regNumber);
            passwordBuilder.Append(secondLetterFirstName);
            passwordBuilder.Append(secondLetterLastName);

            passwordBuilder.Append(GetRandomSpecialCharacters(2));

            string password = passwordBuilder.ToString();
            if (password.Length < 14)
            {
                password += GetRandomAlphabets(14 - password.Length);
            }

            return ValidatePassword(password) ? password : "Failed to generate a valid password.";
        }

        private string GetRandomSpecialCharacters(int count)
        {
            const string specialChars = "!@#$%^&*()-_=+[]{}|;:',.<>?";
            Random random = new Random();
            StringBuilder specialCharacters = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                specialCharacters.Append(specialChars[random.Next(specialChars.Length)]);
            }

            return specialCharacters.ToString();
        }

        private string GetRandomAlphabets(int count)
        {
            const string alphabets = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            StringBuilder randomAlphabets = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                randomAlphabets.Append(alphabets[random.Next(alphabets.Length)]);
            }

            return randomAlphabets.ToString();
        }

        private bool ValidatePassword(string password)
        {
            string pattern = @"^(?=.*[a-zA-Z])(?=.*[!@#$%^&*()\-_=+[\]{}|;:',.<>?])[^\#]{14,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
