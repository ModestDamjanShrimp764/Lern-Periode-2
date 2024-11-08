using System;

class Program
{
    static void Main(string[] args)
    {
        int punkte = 0; // Initialer Punktestand des Spielers
        string eingabe;

        Console.WriteLine("Willkommen bei Schere, Stein, Papier!");

        // Abfrage der Regeln
        Console.WriteLine("Willst du die Regeln wissen? [y,n]");
        while (true)
        {
            eingabe = Console.ReadLine();
            switch (eingabe.ToLower())
            {
                case "y":
                    Console.WriteLine("Regeln:");
                    Console.WriteLine("1. Wähle zwischen Schere, Stein und Papier.");
                    Console.WriteLine("2. Für jeden Sieg erhältst du einen Punkt.");
                    Console.WriteLine("3. Für jede Niederlage verlierst du einen Punkt.");
                    Console.WriteLine("4. Bei Unentschieden bleibt der Punktestand unverändert.");
                    Console.WriteLine("5. Schere schlägt Papier, Papier schlägt Stein, Stein schlägt Schere.");
                    break;

                case "n":
                    Console.WriteLine("Alles klar, viel Erfolg!");
                    break;

                default:
                    Console.WriteLine("Bitte [y,n] eingeben.");
                    continue;
            }
            break;
        }

        Console.WriteLine("--------------------------------------------");

        while (true) // Schleife für mehrere Runden
        {
            int spielerWahl;
            string zahl;

            // Spieler wählt Schere, Stein oder Papier
            Console.WriteLine("Gebe entweder [1] für Schere, [2] für Stein oder [3] für Papier ein:");
            while (true)
            {
                zahl = Console.ReadLine();
                if (int.TryParse(zahl, out spielerWahl) && (spielerWahl >= 1 && spielerWahl <= 3))
                {
                    switch (spielerWahl)
                    {
                        case 1:
                            Console.WriteLine("Du: Schere");
                            break;
                        case 2:
                            Console.WriteLine("Du: Stein");
                            break;
                        case 3:
                            Console.WriteLine("Du: Papier");
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl zwischen 1 und 3 eingeben.");
                }
            }

            Console.WriteLine("vs");

            // Gegner wählt zufällig Schere, Stein oder Papier
            Random random = new Random();
            int gegnerWahl = random.Next(1, 4);
            switch (gegnerWahl)
            {
                case 1:
                    Console.WriteLine("Gegner: Schere");
                    break;
                case 2:
                    Console.WriteLine("Gegner: Stein");
                    break;
                case 3:
                    Console.WriteLine("Gegner: Papier");
                    break;
            }

            // Ergebnis bestimmen und Punktestand aktualisieren
            if (spielerWahl == gegnerWahl)
            {
                Console.WriteLine("Knappes Duell, aber unentschieden.");
            }
            else if ((spielerWahl == 1 && gegnerWahl == 3) || // Schere schlägt Papier
                     (spielerWahl == 2 && gegnerWahl == 1) || // Stein schlägt Schere
                     (spielerWahl == 3 && gegnerWahl == 2))   // Papier schlägt Stein
            {
                Console.WriteLine("Du hast gewonnen!");
                punkte++; // Punktestand um 1 erhöhen
            }
            else
            {
                Console.WriteLine("Du hast verloren.");
                punkte--; // Punktestand um 1 verringern
            }

            // Aktuellen Punktestand anzeigen
            Console.WriteLine($"Aktueller Punktestand: {punkte}");

            // Abfrage, ob der Spieler eine weitere Runde spielen möchte
            Console.WriteLine("Möchtest du eine weitere Runde spielen? [y,n]");
            string weiter = Console.ReadLine();
            if (weiter.ToLower() != "y")
            {
                Console.WriteLine("Spiel beendet.");
                Console.WriteLine($"Endgültiger Punktestand: {punkte}");
                break;
            }

            Console.WriteLine("--------------------------------------------");
        }
    }
}

