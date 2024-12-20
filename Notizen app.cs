using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> notes = new List<string>(); // Liste für Notizen
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("=== Notizen-App ===");
            Console.WriteLine("1. Notiz hinzufügen");
            Console.WriteLine("2. Notizen anzeigen");
            Console.WriteLine("3. Notiz löschen");
            Console.WriteLine("4. Beenden");
            Console.Write("Wähle eine Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddNote(notes);
                    break;
                case "2":
                    ShowNotes(notes);
                    break;
                case "3":
                    DeleteNote(notes);
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Programm beendet.");
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Drücke eine Taste, um es erneut zu versuchen.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AddNote(List<string> notes)
    {
        Console.Clear();
        Console.WriteLine("=== Neue Notiz hinzufügen ===");
        Console.Write("Gib deine Notiz ein: ");
        string note = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(note))
        {
            Console.WriteLine("Die Notiz darf nicht leer sein! Drücke eine Taste, um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        notes.Add(note);
        Console.WriteLine("Notiz erfolgreich hinzugefügt! Drücke eine Taste, um zurückzukehren.");
        Console.ReadKey();
    }

    static void ShowNotes(List<string> notes)
    {
        Console.Clear();
        Console.WriteLine("=== Alle Notizen ===");

        if (notes.Count == 0)
        {
            Console.WriteLine("Es gibt keine Notizen.");
        }
        else
        {
            for (int i = 0; i < notes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {notes[i]}");
            }
        }

        Console.WriteLine("\nDrücke eine Taste, um zurückzukehren.");
        Console.ReadKey();
    }

    static void DeleteNote(List<string> notes)
    {
        Console.Clear();
        Console.WriteLine("=== Notiz löschen ===");

        if (notes.Count == 0)
        {
            Console.WriteLine("Es gibt keine Notizen, die gelöscht werden können.");
            Console.WriteLine("Drücke eine Taste, um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Wähle die Nummer der Notiz, die du löschen möchtest:");
        for (int i = 0; i < notes.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {notes[i]}");
        }

        Console.Write("Deine Auswahl: ");
        if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= notes.Count)
        {
            notes.RemoveAt(choice - 1);
            Console.WriteLine("Notiz erfolgreich gelöscht!");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Keine Notiz wurde gelöscht.");
        }

        Console.WriteLine("Drücke eine Taste, um zurückzukehren.");
        Console.ReadKey();
    }
}






