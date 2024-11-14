using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Eingabe des Gewichts
            Console.Write("Bitte geben Sie Ihr Gewicht in Kilogramm ein: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Eingabe der Größe
            Console.Write("Bitte geben Sie Ihre Größe in Metern ein (z.B. 1.75): ");
            double height = Convert.ToDouble(Console.ReadLine());

            // BMI berechnen
            double bmi = CalculateBMI(weight, height);

            // Ergebnis anzeigen
            Console.WriteLine($"Ihr BMI ist: {bmi:F2}");

            // BMI-Kategorie ermitteln
            string category = GetBMICategory(bmi);
            Console.WriteLine($"Kategorie: {category}");
        }

        // Funktion zur Berechnung des BMI
        static double CalculateBMI(double weight, double height)
        {
            if (height <= 0 || weight <= 0)
            {
                throw new ArgumentException("Gewicht und Größe müssen größer als 0 sein.");
            }

            return weight / (height * height);
        }

        // Funktion zur Bestimmung der BMI-Kategorie
        static string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
                return "Untergewicht";
            else if (bmi >= 18.5 && bmi < 24.9)
                return "Normalgewicht";
            else if (bmi >= 25 && bmi < 29.9)
                return "Übergewicht";
            else
                return "Adipositas";
        }
    }
}

