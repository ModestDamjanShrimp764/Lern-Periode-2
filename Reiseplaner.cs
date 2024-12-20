using System;
using System.Collections.Generic;

class Reiseplaner
{
    static void Main()
    {
        List<Reise> reisen = new List<Reise>(); // Liste für Reisen
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Reiseplaner ===");
            Console.WriteLine("1. Reise hinzufügen");
            Console.WriteLine("2. Alle Reisen anzeigen");
            Console.WriteLine("3. Reise löschen");
            Console.WriteLine("4. Beenden");
            Console.Write("Wähle eine Option (1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ReiseHinzufügen(reisen);
                    break;
                case "2":
                    ReisenAnzeigen(reisen);
                    break;
                case "3":
                    ReiseLöschen(reisen);
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Programm beendet. Drücke eine beliebige Taste...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Drücke eine beliebige Taste, um es erneut zu versuchen.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void ReiseHinzufügen(List<Reise> reisen)
    {
        Console.Clear();
        Console.WriteLine("=== Neue Reise hinzufügen ===");

        Console.Write("Reiseziel: ");
        string ziel = Console.ReadLine();

        Console.Write("Abreisedatum (TT.MM.JJJJ): ");
        string abreisedatum = Console.ReadLine();

        Console.Write("Rückreisedatum (TT.MM.JJJJ): ");
        string rueckreisedatum = Console.ReadLine();

        Console.Write("Transportmittel (z. B. Auto, Flugzeug): ");
        string transportmittel = Console.ReadLine();

        // Validierung der Eingaben
        if (string.IsNullOrWhiteSpace(ziel) || string.IsNullOrWhiteSpace(abreisedatum) || string.IsNullOrWhiteSpace(rueckreisedatum) || string.IsNullOrWhiteSpace(transportmittel))
        {
            Console.WriteLine("Alle Felder müssen ausgefüllt sein! Drücke eine beliebige Taste, um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        // Neue Reise zur Liste hinzufügen
        reisen.Add(new Reise(ziel, abreisedatum, rueckreisedatum, transportmittel));
        Console.WriteLine("Reise erfolgreich hinzugefügt! Drücke eine beliebige Taste, um zurückzukehren.");
        Console.ReadKey();
    }

    static void ReisenAnzeigen(List<Reise> reisen)
    {
        Console.Clear();
        Console.WriteLine("=== Geplante Reisen ===");

        if (reisen.Count == 0)
        {
            Console.WriteLine("Es sind keine Reisen geplant.");
        }
        else
        {
            for (int i = 0; i < reisen.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Reiseziel: {reisen[i].Ziel}");
                Console.WriteLine($"   Abreise: {reisen[i].Abreisedatum}");
                Console.WriteLine($"   Rückreise: {reisen[i].Rueckreisedatum}");
                Console.WriteLine($"   Transportmittel: {reisen[i].Transportmittel}");
                Console.WriteLine(new string('-', 30));
            }
        }

        Console.WriteLine("Drücke eine beliebige Taste, um zurückzukehren.");
        Console.ReadKey();
    }

    static void ReiseLöschen(List<Reise> reisen)
    {
        Console.Clear();
        Console.WriteLine("=== Reise löschen ===");

        if (reisen.Count == 0)
        {
            Console.WriteLine("Es gibt keine geplanten Reisen, die gelöscht werden können.");
            Console.WriteLine("Drücke eine beliebige Taste, um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Geplante Reisen:");
        for (int i = 0; i < reisen.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {reisen[i].Ziel}");
        }

        Console.Write("Gib die Nummer der Reise ein, die du löschen möchtest: ");
        if (int.TryParse(Console.ReadLine(), out int nummer) && nummer >= 1 && nummer <= reisen.Count)
        {
            reisen.RemoveAt(nummer - 1);
            Console.WriteLine("Reise erfolgreich gelöscht! Drücke eine beliebige Taste, um zurückzukehren.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Drücke eine beliebige Taste, um zurückzukehren.");
        }

        Console.ReadKey();
    }
}

class Reise
{
    public string Ziel { get; set; }
    public string Abreisedatum { get; set; }
    public string Rueckreisedatum { get; set; }
    public string Transportmittel { get; set; }

    public Reise(string ziel, string abreisedatum, string rueckreisedatum, string transportmittel)
    {
        Ziel = ziel;
        Abreisedatum = abreisedatum;
        Rueckreisedatum = rueckreisedatum;
        Transportmittel = transportmittel;
    }
}


