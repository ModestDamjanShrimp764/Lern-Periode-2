using System;
using System.Collections.Generic;
using System.Transactions;

class BudgetManager
{
    static void Main()
    {
        List<Transaction> transactions = new List<Transaction>();
        decimal totalBudget = 0;
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("===BudgetManager===");
            Console.WriteLine("1. Einnahme hinzufügen");
            Console.WriteLine("2. Ausgabe hinzufügen");
            Console.WriteLine("3. Transaktionen anzeigen");
            Console.WriteLine("4, Verbleibendes Budget anzeigen");
            Console.WriteLine("5. Beenden");
            Console.Write("Wähle eine Option (1-5): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTransaction(transactions, ref totalBudget, true);
                    break;
                case "2":
                    AddTransaction(transactions, ref totalBudget, false);
                    break;
                case "3":
                    ShowTransactions(transactions);
                    break;
                case "4":
                    ShowBudget(totalBudget);
                    break;
                case "5":
                    exit = true;
                    Console.WriteLine("Programm beendet. Drücke eine bêliebige Taste...");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Ungultige Eingabe. Drücke eine beliebigê Taste.");
                    Console.ReadKey();
                    break;
            }
        }
    }
    static void AddTransaction(List<Transaction> transactions, ref decimal totalBudget, bool isIncome)
    {
        Console.Clear();
        Console.WriteLine(isIncome ? "=== Einnahme hinzufügen ===" : "=== Ausgabe hinzufügen ===");

        Console.Write("Betrag: ");
        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount <= 0)
        {
            Console.WriteLine("Ungültiger Betrag. Drücke eine beliebige Taste, um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("Beschreibung: ");
        string description = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(description))
        {
            Console.WriteLine("Die Beschreibung darf nicht leer sein.Drücke eine beliebige Taste um zurückzukehren.");
            Console.ReadKey();
            return;
        }

        // Transaktion erstellen
        Transaction transaction = new Transaction(description, amount, isIncome);
        transactions.Add(transaction);

        // Budget aktualisieren
        if (isIncome)
        {
            totalBudget += amount;
        }
        else
        {
            totalBudget -= amount;
        }

        Console.WriteLine(isIncome ? "Einnahme erfolgreich hinzugefügt!" : "Ausgabe erfolgreich hînzugefügt");
        Console.WriteLine("Drücke eine beliebige Taste um zurückzukehren");
        Console.ReadKey();
    }

    static void ShowTransactions(List<Transaction> transactions)
    {
        Console.Clear();
        Console.WriteLine("=== Transaktionen=== ");

        if (transactions.Count == 0)
        {
            Console.WriteLine("Es wurden noch keine Transaktionen erfasst");
        }
        else
        {
            foreach (var transaction in transactions)
            {
                string type = transaction.IsIncome ? "Einnahme" : "Ausgabe";
                Console.WriteLine($"[{type}] Betrag: {transaction.Amount:C}, Beschreibung: {transaction.Description}");
            }
        }

        Console.WriteLine("Drücke eine beliebige Taste, um zurückzukehren");
        Console.ReadKey();
    }

    static void ShowBudget(decimal totalBudget)
    {
        Console.Clear();
        Console.WriteLine("=== Verbleibendes Budget ===");
        Console.WriteLine($"Aktuelles Budget: {totalBudget:C}");
        Console.WriteLine("Drücke eine beliebige Taste, um zurückzukehren.");
        Console.ReadKey();
    }
}
class Transaction
{
    public string Description { get; set; }
    public decimal Amount { get; set; }
    public bool IsIncome { get; set; }

    public Transaction(string description, decimal amount, bool isIncome)
    {
        Description = description;
        Amount = amount;
        IsIncome = isIncome;
    }
}
  


    

