using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Willkommen! Ich bin eine einfache KI. Sie können mit mir chatten.");
        Console.WriteLine("Geben Sie 'exit' ein, um das Gespräch zu beenden.");

        while (true)
        {
            Console.Write("\nSie: ");
            string userInput = Console.ReadLine()?.ToLower();

            if (userInput == "exit")
            {
                Console.WriteLine("KI: Auf Wiedersehen!");
                break;
            }

            string response = GetResponse(userInput);
            Console.WriteLine($"KI: {response}");
        }
    }

    static string GetResponse(string input)
    {
        // Einfache Regelbasierte Antworten
        Dictionary<string, string> responses = new Dictionary<string, string>
        {
            { "hallo", "Hallo! Wie kann ich Ihnen helfen?" },
            { "wie geht es dir", "Mir geht es gut, danke! Und Ihnen?" },
            { "was ist dein name", "Ich bin eine einfache KI, und mein Name ist Bot." },
            { "hilfe", "Ich kann einfache Fragen beantworten. Fragen Sie mich etwas!" },
            { "was ist die zeit", $"Die aktuelle Uhrzeit ist {DateTime.Now:HH:mm}." }
        };

        // Durchsucht die Schlüsselwörter und gibt eine passende Antwort
        foreach (var pair in responses)
        {
            if (input.Contains(pair.Key))
            {
                return pair.Value;
            }
        }

        // Standardantwort, wenn kein Schlüsselwort gefunden wird
        return "Entschuldigung, das habe ich nicht verstanden.";
    }
}
