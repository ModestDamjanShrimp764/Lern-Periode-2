using System;
using System.Collections.Generic;

namespace KalenderApp
{
    class Program
    {
        static Dictionary<DateTime, List<string>> kalender = new Dictionary<DateTime, List<string>>();

        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Kalender-App");
                Console.WriteLine("------------");
                Console.WriteLine("1. Termin hinzufügen");
                Console.WriteLine("2. Termine anzeigen");
                Console.WriteLine("3. Termin löschen");
                Console.WriteLine("4. Beenden");
                Console.Write("Wähle eine Option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        TerminHinzufuegen();
                        break;
                    case "2":
                        TermineAnzeigen();
                        break;
                    case "3":
                        TerminLoeschen();
                        break;
                    case "4":
                        exit = true;
                        Console.WriteLine("Programm wird beendet. Auf Wiedersehen!");
                        break;
                    default:
                        Console.WriteLine("Ungültige Auswahl. Bitte wähle erneut.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void TerminHinzufuegen()
        {
            Console.Clear();
            Console.WriteLine("Termin hinzufügen");
            Console.WriteLine("-----------------");

            Console.Write("Gib das Datum ein (Format: TT.MM.JJJJ): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime datum))
            {
                Console.Write("Gib die Beschreibung des Termins ein: ");
                string beschreibung = Console.ReadLine();

                if (!kalender.ContainsKey(datum))
                {
                    kalender[datum] = new List<string>();
                }

                kalender[datum].Add(beschreibung);
                Console.WriteLine("Termin wurde erfolgreich hinzugefügt.");
            }
            else
            {
                Console.WriteLine("Ungültiges Datum. Bitte versuche es erneut.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren.");
            Console.ReadKey();
        }

        static void TermineAnzeigen()
        {
            Console.Clear();
            Console.WriteLine("Termine anzeigen");
            Console.WriteLine("----------------");

            if (kalender.Count == 0)
            {
                Console.WriteLine("Es sind keine Termine vorhanden.");
            }
            else
            {
                foreach (var datum in kalender.Keys)
                {
                    Console.WriteLine($"\n{datum:dd.MM.yyyy}:");
                    foreach (var termin in kalender[datum])
                    {
                        Console.WriteLine($"  - {termin}");
                    }
                }
            }

            Console.WriteLine("\nDrücke eine beliebige Taste, um fortzufahren.");
            Console.ReadKey();
        }

        static void TerminLoeschen()
        {
            Console.Clear();
            Console.WriteLine("Termin löschen");
            Console.WriteLine("--------------");

            Console.Write("Gib das Datum ein (Format: TT.MM.JJJJ): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime datum))
            {
                if (kalender.ContainsKey(datum))
                {
                    Console.WriteLine($"\nTermine für {datum:dd.MM.yyyy}:");
                    for (int i = 0; i < kalender[datum].Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {kalender[datum][i]}");
                    }

                    Console.Write("\nWähle die Nummer des Termins, den du löschen möchtest: ");
                    if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= kalender[datum].Count)
                    {
                        kalender[datum].RemoveAt(index - 1);
                        Console.WriteLine("Termin wurde erfolgreich gelöscht.");

                        if (kalender[datum].Count == 0)
                        {
                            kalender.Remove(datum);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Auswahl. Bitte versuche es erneut.");
                    }
                }
                else
                {
                    Console.WriteLine("Es sind keine Termine für dieses Datum vorhanden.");
                }
            }
            else
            {
                Console.WriteLine("Ungültiges Datum. Bitte versuche es erneut.");
            }

            Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren.");
            Console.ReadKey();
        }
    }
}
