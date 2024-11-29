using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Willkommen zum Passwort-Generator!");
        Console.Write("Wie lang soll das Passwort sein? (min. 8): ");

        if (int.TryParse(Console.ReadLine(), out int length) && length >= 8)
        {
            Console.WriteLine("\nOptionen:");
            Console.WriteLine("1. Nur Buchstaben");
            Console.WriteLine("2. Buchstaben und Zahlen");
            Console.WriteLine("3. Buchstaben, Zahlen und Sonderzeichen");
            Console.Write("Wähle die Stärke des Passworts (1-3): ");

            string choice = Console.ReadLine();
            string password = choice switch
            {
                "1" => GeneratePassword(length, true, false, false),
                "2" => GeneratePassword(length, true, true, false),
                "3" => GeneratePassword(length, true, true, true),
                _ => "Ungültige Auswahl."
            };

            if (password != "Ungültige Auswahl.")
            {
                Console.WriteLine($"\nDein generiertes Passwort: {password}");
            }
            else
            {
                Console.WriteLine(password);
            }
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Passwort muss mindestens 8 Zeichen lang sein.");
        }
    }

    static string GeneratePassword(int length, bool includeLetters, bool includeNumbers, bool includeSpecialChars)
    {
        const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        const string numbers = "0123456789";
        const string specialChars = "!@#$%^&*()-_=+[]{}|;:,.<>?/";

        // Aufbau des möglichen Zeichenpools
        StringBuilder charPool = new StringBuilder();
        if (includeLetters) charPool.Append(letters);
        if (includeNumbers) charPool.Append(numbers);
        if (includeSpecialChars) charPool.Append(specialChars);

        if (charPool.Length == 0) throw new ArgumentException("Es müssen Zeichen ausgewählt werden!");

        StringBuilder password = new StringBuilder();
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = random.Next(0, charPool.Length);
            password.Append(charPool[index]);
        }

        return password.ToString();
    }
}
