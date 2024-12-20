using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nWillkommen zum Spiele-Hub!");
            Console.WriteLine("1. Hangman");
            Console.WriteLine("2. Schere, Stein, Papier");
            Console.WriteLine("3. Zahlenratespiel");
            Console.WriteLine("4. Beenden");

            Console.Write("Wähle ein Spiel (1-4): ");
            string auswahl = Console.ReadLine();

            switch (auswahl)
            {
                case "1":
                    Hangman();
                    break;
                case "2":
                    SchereSteinPapier();
                    break;
                case "3":
                    Zahlenratespiel();
                    break;
                case "4":
                    Console.WriteLine("Vielen Dank fürs Spielen. Auf Wiedersehen!");
                    return;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine Option zwischen 1 und 4.");
                    break;
            }
        }
    }

    static void Hangman()
    {
        Console.WriteLine("\nHangman: Errate das Wort!");
        string wort = "python";
        string geraten = "";
        int fehler = 0;
        int maxFehler = 6;

        while (fehler < maxFehler)
        {
            string ausgabe = "";
            foreach (char buchstabe in wort)
            {
                ausgabe += geraten.Contains(buchstabe) ? buchstabe + " " : "_ ";
            }

            Console.WriteLine(ausgabe.Trim());

            if (!ausgabe.Contains("_"))
            {
                Console.WriteLine("Glückwunsch, du hast gewonnen!");
                return;
            }

            Console.Write("Rate einen Buchstaben: ");
            string eingabe = Console.ReadLine().ToLower();

            if (eingabe.Length != 1)
            {
                Console.WriteLine("Bitte gib genau einen Buchstaben ein.");
                continue;
            }

            if (wort.Contains(eingabe))
            {
                geraten += eingabe;
            }
            else
            {
                fehler++;
                Console.WriteLine($"Falsch! Du hast noch {maxFehler - fehler} Versuche.");
            }
        }

        Console.WriteLine($"Du hast verloren. Das Wort war: {wort}");
    }

    static void SchereSteinPapier()
    {
        Console.WriteLine("\nSchere, Stein, Papier");
        string[] wahl = { "Schere", "Stein", "Papier" };
        Console.Write("Deine Wahl (Schere, Stein, Papier): ");
        string spieler = Console.ReadLine();

        if (Array.IndexOf(wahl, spieler) == -1)
        {
            Console.WriteLine("Ungültige Wahl. Bitte wähle Schere, Stein oder Papier.");
            return;
        }

        Random rand = new Random();
        string computer = wahl[rand.Next(wahl.Length)];
        Console.WriteLine($"Computer wählt: {computer}");

        if (spieler == computer)
        {
            Console.WriteLine("Unentschieden!");
        }
        else if ((spieler == "Schere" && computer == "Papier") ||
                 (spieler == "Stein" && computer == "Schere") ||
                 (spieler == "Papier" && computer == "Stein"))
        {
            Console.WriteLine("Du gewinnst!");
        }
        else
        {
            Console.WriteLine("Du verlierst!");
        }
    }

    static void Zahlenratespiel()
    {
        Console.WriteLine("\nZahlenratespiel: Rate die Zahl zwischen 1 und 10");
        Random rand = new Random();
        int zahl = rand.Next(1, 11);

        while (true)
        {
            Console.Write("Dein Tipp: ");
            if (int.TryParse(Console.ReadLine(), out int tipp))
            {
                if (tipp == zahl)
                {
                    Console.WriteLine("Richtig! Du hast gewonnen.");
                    break;
                }
                else if (tipp < zahl)
                {
                    Console.WriteLine("Zu niedrig.");
                }
                else
                {
                    Console.WriteLine("Zu hoch.");
                }
            }
            else
            {
                Console.WriteLine("Bitte gib eine gültige Zahl ein.");
            }
        }
    }
}

