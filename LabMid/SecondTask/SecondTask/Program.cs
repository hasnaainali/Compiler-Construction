using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string firstName = "HASNAIN";
        string lastName = "ALI";
        string regNumber = "05";
        string favoriteMovie = "Inception";

        string password = GeneratePassword(firstName, lastName, regNumber, favoriteMovie);
        Console.WriteLine($"Generated Password: {password}");
    }

    static string GeneratePassword(string firstName, string lastName, string regNumber, string favoriteMovie)
    {
        
        string regDigits = regNumber.Length >= 2 ? regNumber.Substring(0, 2) : regNumber + "0";

        char secondLetterFirstName = firstName.Length > 1 ? firstName[1] : 'A';
        char secondLetterLastName = lastName.Length > 1 ? lastName[1] : 'A';

        string movieChars = favoriteMovie.Length >= 2 ? favoriteMovie.Substring(0, 2) : "XX";

        string specialChars = GetRandomSpecialCharacters(2);

        StringBuilder passwordBuilder = new StringBuilder();
        passwordBuilder.Append(regDigits);               
        passwordBuilder.Append(secondLetterFirstName);   
        passwordBuilder.Append(secondLetterLastName);    
        passwordBuilder.Append(movieChars);              
        passwordBuilder.Append(specialChars);            

        while (passwordBuilder.Length < 14)
        {
            passwordBuilder.Append(GetRandomAlphabets(1));
        }

        string password = passwordBuilder.ToString();

        return ValidatePassword(password) ? password : "Failed to generate a valid password.";
    }

    static string GetRandomSpecialCharacters(int count)
    {
        const string specialChars = "!@$%^&*()-_=+[]{}|;:',.<>?";
        Random random = new Random();
        StringBuilder specialCharacters = new StringBuilder();

        for (int i = 0; i < count; i++)
        {
            specialCharacters.Append(specialChars[random.Next(specialChars.Length)]);
        }

        return specialCharacters.ToString();
    }

    static string GetRandomAlphabets(int count)
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

    static bool ValidatePassword(string password)
    {
        string pattern = @"^(?=.*[a-zA-Z])(?=.*[!@$%^&*()\-_=+\[\]{}|;:',.<>?])[^\#]{14}$";
        return Regex.IsMatch(password, pattern);
    }
}
