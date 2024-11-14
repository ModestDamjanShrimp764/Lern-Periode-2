using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);  // Zufallszahl zwischen 1 und 100
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Willkommen zum Zahlerraten-Spiel!");
            Console.WriteLine("Ich habe eine Zahl zwischen 1 und 100 gewählt.");
            Console.WriteLine("Versuche, sie zu erraten!");

            // Solange der Benutzer die Zahl nicht erraten hat
            while (guess != targetNumber)
            {
                Console.Write("Gib deinen Tipp ein: ");
                string userInput = Console.ReadLine();

                // Überprüfen, ob die Eingabe eine gültige Zahl ist
                if (int.TryParse(userInput, out guess))
                {
                    attempts++;
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Die Zahl ist größer. Versuch es noch einmal.");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Die Zahl ist kleiner. Versuch es noch einmal.");
                    }
                    else
                    {
                        Console.WriteLine($"Glückwunsch! Du hast die Zahl {targetNumber} nach {attempts} Versuchen erraten.");
                    }
                }
                else
                {
                    Console.WriteLine("Bitte gib eine gültige Zahl ein.");
                }
            }
        }
    }
}
