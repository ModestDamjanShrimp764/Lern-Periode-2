using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> todoList = new List<string>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== TO-DO LIST ===");
            Console.WriteLine("1. Aufgaben anzeigen");
            Console.WriteLine("2. Aufgabe hinzufügen");
            Console.WriteLine("3. Aufgabe entfernen");
            Console.WriteLine("4. Programm beenden");
            Console.Write("Option auswählen: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    ShowTasks(todoList);
                    break;
                case "2":
                    AddTask(todoList);
                    break;
                case "3":
                    RemoveTask(todoList);
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Programm beendet.");
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte erneut versuchen.");
                    break;
            }

            if (running)
            {
                Console.WriteLine("Drücke eine beliebige Taste, um fortzufahren...");
                Console.ReadKey();
            }
        }
    }

    static void ShowTasks(List<string> todoList)
    {
        Console.WriteLine("=== Aufgaben ===");
        if (todoList.Count == 0)
        {
            Console.WriteLine("Keine Aufgaben vorhanden.");
        }
        else
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }

    static void AddTask(List<string> todoList)
    {
        Console.Write("\nNeue Aufgabe hinzufügen: ");
        string task = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(task))
        {
            todoList.Add(task);
            Console.WriteLine("Aufgabe hinzugefügt.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Aufgabe konnte nicht hinzugefügt werden.");
        }
    }

    static void RemoveTask(List<string> todoList)
    {
        Console.Write("Aufgabennummer zum Entfernen: ");
        if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= todoList.Count)
        {
            todoList.RemoveAt(taskNumber - 1);
            Console.WriteLine("Aufgabe entfernt.");
        }
        else
        {
            Console.WriteLine("Ungültige Nummer. Keine Aufgabe entfernt.");
        }
    }
}
