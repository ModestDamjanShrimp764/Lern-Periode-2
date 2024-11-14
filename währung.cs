using System;
using System.Collections.Generic;

namespace CurrencyConverter
{
    class Program
    {
        // Wechselkurse (Beispielwerte)
        private static readonly Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>()
        {
            { "USD", 1.0m },    // US Dollar als Basis
            { "EUR", 0.85m },   // Euro
            { "GBP", 0.75m },   // Britisches Pfund
            { "JPY", 110.0m },  // Japanischer Yen
            { "CHF", 0.92m },   // Schweizer Franken
        };

        static void Main(string[] args)
        {
            // Eingabe des Betrags
            Console.WriteLine("Geben Sie den Betrag ein, den Sie umrechnen möchten:");
            decimal amount;
            while (!decimal.TryParse(Console.ReadLine(), out amount) || amount <= 0)
            {
                Console.WriteLine("Ungültiger Betrag, bitte erneut eingeben:");
            }

            // Eingabe der Ausgangswährung
            Console.WriteLine("Wählen Sie die Ausgangswährung (z.B. USD, EUR, GBP, JPY, CHF):");
            string fromCurrency = Console.ReadLine().ToUpper();
            while (!exchangeRates.ContainsKey(fromCurrency))
            {
                Console.WriteLine("Ungültige Währung, bitte erneut wählen (z.B. USD, EUR, GBP, JPY, CHF):");
                fromCurrency = Console.ReadLine().ToUpper();
            }

            // Eingabe der Zielwährung
            Console.WriteLine("Wählen Sie die Zielwährung (z.B. USD, EUR, GBP, JPY, CHF):");
            string toCurrency = Console.ReadLine().ToUpper();
            while (!exchangeRates.ContainsKey(toCurrency))
            {
                Console.WriteLine("Ungültige Währung, bitte erneut wählen (z.B. USD, EUR, GBP, JPY, CHF):");
                toCurrency = Console.ReadLine().ToUpper();
            }

            // Umrechnung durchführen
            decimal result = ConvertCurrency(amount, fromCurrency, toCurrency);

            // Ergebnis anzeigen
            Console.WriteLine($"{amount} {fromCurrency} = {result:F2} {toCurrency}");
        }

        // Umrechnungsfunktion
        private static decimal ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == toCurrency)
                return amount;

            // Betrag von der Ausgangswährung in USD umrechnen
            decimal amountInUSD = amount / exchangeRates[fromCurrency];

            // Betrag von USD in die Zielwährung umrechnen
            return amountInUSD * exchangeRates[toCurrency];
        }
    }
}

