using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Einfaches Wort
            string wordToGuess = "PROGRAMMIEREN";
            char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();

            int attemptsLeft = 6; // Anzahl der Versuche

            Console.WriteLine("Willkommen zu Hangman!");
            Console.WriteLine("Versuche, das Wort zu erraten.");

            // Spiel-Schleife
            while (attemptsLeft > 0)
            {
                Console.Clear();
                Console.WriteLine($"Wort: {new string(guessedWord)}");
                Console.WriteLine($"Verbleibende Versuche: {attemptsLeft}");
                Console.Write("Gib einen Buchstaben ein: ");

                string input = Console.ReadLine().ToUpper(); // Eingabe des Spielers in Großbuchstaben

                // Wenn der Spieler mehr als 1 Zeichen eingibt, ist die Eingabe ungültig
                if (input.Length != 1)
                {
                    Console.WriteLine("Bitte gib nur einen Buchstaben ein.");
                    continue;
                }

                char guessedLetter = input[0];

                bool correctGuess = false;

                // Überprüfen, ob der Buchstabe im Wort enthalten ist
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                        correctGuess = true;
                    }
                }

                // Wenn der Buchstabe falsch ist, Versuche verringern
                if (!correctGuess)
                {
                    attemptsLeft--;
                    Console.WriteLine("Falsch geraten!");
                }

                // Überprüfen, ob das Wort vollständig erraten wurde
                if (new string(guessedWord) == wordToGuess)
                {
                    Console.Clear();
                    Console.WriteLine($"Herzlichen Glückwunsch! Du hast das Wort '{wordToGuess}' erraten.");
                    break;
                }
            }

            // Wenn alle Versuche aufgebraucht sind, hat der Spieler verloren
            if (attemptsLeft == 0)
            {
                Console.Clear();
                Console.WriteLine("Du hast verloren! Das richtige Wort war '{0}'.", wordToGuess);
            }

            Console.WriteLine("Drücke eine beliebige Taste, um das Spiel zu beenden.");
            Console.ReadKey();
        }
    }
}

