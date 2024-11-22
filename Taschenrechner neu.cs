using System;

class Program
{
    static void Main()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.Clear();
            Console.WriteLine("Willkommen beim Taschenrechner!");
            Console.WriteLine("Wählen Sie eine der folgenden Optionen:");
            Console.WriteLine("1: Addition (+)");
            Console.WriteLine("2: Subtraktion (-)");
            Console.WriteLine("3: Multiplikation (*)");
            Console.WriteLine("4: Division (/)");
            Console.WriteLine("5: Quadratwurzel (√)");
            Console.WriteLine("6: Potenzieren (^)");
            Console.WriteLine("7: Programm beenden");
            Console.Write("Ihre Auswahl: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PerformOperation((a, b) => a + b, "Addition (+)");
                    break;
                case "2":
                    PerformOperation((a, b) => a - b, "Subtraktion (-)");
                    break;
                case "3":
                    PerformOperation((a, b) => a * b, "Multiplikation (*)");
                    break;
                case "4":
                    PerformOperation((a, b) =>
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
                            return double.NaN;
                        }
                        return a / b;
                    }, "Division (/)");
                    break;
                case "5":
                    PerformSquareRoot();
                    break;
                case "6":
                    PerformPower();
                    break;
                case "7":
                    Console.WriteLine("Auf Wiedersehen!");
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                    Pause();
                    break;
            }
        }
    }

    static void PerformOperation(Func<double, double, double> operation, string operationName)
    {
        Console.Write($"Erste Zahl für die {operationName}: ");
        double num1 = GetValidNumber();
        Console.Write($"Zweite Zahl für die {operationName}: ");
        double num2 = GetValidNumber();

        double result = operation(num1, num2);
        if (!double.IsNaN(result))
        {
            Console.WriteLine($"Das Ergebnis der {operationName}: {result}");
        }
        Pause();
    }

    static void PerformSquareRoot()
    {
        Console.Write("Geben Sie die Zahl ein, für die die Quadratwurzel berechnet werden soll: ");
        double num = GetValidNumber();

        if (num < 0)
        {
            Console.WriteLine("Fehler: Quadratwurzel einer negativen Zahl ist nicht definiert.");
        }
        else
        {
            double result = Math.Sqrt(num);
            Console.WriteLine($"Die Quadratwurzel von {num} ist {result}");
        }
        Pause();
    }

    static void PerformPower()
    {
        Console.Write("Basiszahl: ");
        double baseNumber = GetValidNumber();
        Console.Write("Exponent: ");
        double exponent = GetValidNumber();

        double result = Math.Pow(baseNumber, exponent);
        Console.WriteLine($"{baseNumber} hoch {exponent} ergibt {result}");
        Pause();
    }

    static double GetValidNumber()
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (double.TryParse(input, out double number))
            {
                return number;
            }
            Console.Write("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein: ");
        }
    }

    static void Pause()
    {
        Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren...");
        Console.ReadKey();
    }
}
