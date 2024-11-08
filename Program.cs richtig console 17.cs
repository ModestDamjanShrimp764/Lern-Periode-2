using System;

class KaloriendefizitRechner
{
    static void Main()
    {
        Console.WriteLine("Willkommen beim Kaloriendefizitrechner!");

       
        Console.Write("Bitte gib dein aktuelles Gewicht in kg ein: ");
        double gewicht = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte gib deine Körpergröße in cm ein: ");
        double groesse = Convert.ToDouble(Console.ReadLine());

        Console.Write("Bitte gib dein Alter ein: ");
        int alter = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bitte gib dein Geschlecht ein (m für männlich, w für weiblich): ");
        char geschlecht = Convert.ToChar(Console.ReadLine().ToLower());

        
        double grundumsatz;
        if (geschlecht == 'm')
        {
            grundumsatz = 88.362 + (13.397 * gewicht) + (4.799 * groesse) - (5.677 * alter);
        }
        else if (geschlecht == 'w')
        {
            grundumsatz = 447.593 + (9.247 * gewicht) + (3.098 * groesse) - (4.330 * alter);
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe für das Geschlecht.");
            return;
        }

        
        Console.WriteLine("Bitte wähle dein Aktivitätslevel aus:");
        Console.WriteLine("1. Kaum oder keine Bewegung");
        Console.WriteLine("2. Leichte Bewegung (1-3 Tage pro Woche)");
        Console.WriteLine("3. Mäßige Bewegung (3-5 Tage pro Woche)");
        Console.WriteLine("4. Aktive Bewegung (6-7 Tage pro Woche)");
        Console.WriteLine("5. Sehr aktive Bewegung (Sport, körperliche Arbeit)");
        int aktivitaetsLevel = Convert.ToInt32(Console.ReadLine());

      
        double aktivitaetsFaktor;
        switch (aktivitaetsLevel)
        {
            case 1: aktivitaetsFaktor = 1.2; break;
            case 2: aktivitaetsFaktor = 1.375; break;
            case 3: aktivitaetsFaktor = 1.55; break;
            case 4: aktivitaetsFaktor = 1.725; break;
            case 5: aktivitaetsFaktor = 1.9; break;
            default:
                Console.WriteLine("Ungültige Eingabe für das Aktivitätslevel.");
                return;
        }

        
        double kalorienbedarf = grundumsatz * aktivitaetsFaktor;
        Console.WriteLine($"Dein täglicher Kalorienbedarf beträgt: {kalorienbedarf:F2} kcal");

       
        Console.Write("Bitte gib das gewünschte Kaloriendefizit pro Tag ein (z.B. 500 kcal): ");
        double kaloriendefizit = Convert.ToDouble(Console.ReadLine());

        
        double zielKalorienzufuhr = kalorienbedarf - kaloriendefizit;
        Console.WriteLine($"Um dein Kaloriendefizit zu erreichen, solltest du täglich etwa {zielKalorienzufuhr:F2} kcal zu dir nehmen.");

       
        double wochenDefizit = kaloriendefizit * 7;
        double gewichtsverlustProWoche = wochenDefizit / 7700;
        Console.WriteLine($"Bei diesem Kaloriendefizit würdest du voraussichtlich {gewichtsverlustProWoche:F2} kg pro Woche verlieren.");

        Console.WriteLine("--------------------------------------------");

     
        Console.WriteLine("\n--- Täglicher Plan für eine Woche ---");
        for (int tag = 1; tag <= 7; tag++)
        {
            Console.WriteLine($"\nTag {tag}:");
            ErstelleTagesplan(zielKalorienzufuhr);
        }

        Console.WriteLine("Vielen Dank für die Nutzung des Kaloriendefizitrechners!");
    }

  
    static void ErstelleTagesplan(double zielKalorienzufuhr)
    {
        
        string[] fruehstueck = { "Haferflocken mit Obst (ca. 300 kcal)", "Rührei mit Vollkornbrot (ca. 350 kcal)", "Joghurt mit Nüssen (ca. 280 kcal)", "Smoothie mit Banane und Spinat (ca. 250 kcal)", "Porridge mit Nüssen (ca. 270 kcal)" };
        string[] mittagessen = { "Gegrilltes Hähnchen mit Gemüse (ca. 450 kcal)", "Quinoa-Salat (ca. 500 kcal)", "Linsen-Curry mit Reis (ca. 400 kcal)", "Hähnchenwrap (ca. 350 kcal)", "Fisch mit Süßkartoffeln (ca. 480 kcal)" };
        string[] abendessen = { "Gegrillter Fisch mit Salat (ca. 350 kcal)", "Tofu mit Gemüse (ca. 350 kcal)", "Leichte Gemüsesuppe (ca. 250 kcal)", "Salat mit gegrilltem Hühnchen (ca. 400 kcal)", "Veganer Linsensalat (ca. 300 kcal)" };
        string[] snacks = { "Mandeln (ca. 150 kcal)", "Obst (ca. 100 kcal)", "Gemüse mit Hummus (ca. 120 kcal)", "Proteinriegel (ca. 200 kcal)", "Kekse aus Haferflocken (ca. 180 kcal)" };

       
        Random rand = new Random();
        string auswahlFruehstueck = fruehstueck[rand.Next(fruehstueck.Length)];
        string auswahlMittagessen = mittagessen[rand.Next(mittagessen.Length)];
        string auswahlAbendessen = abendessen[rand.Next(abendessen.Length)];
        string auswahlSnacks = snacks[rand.Next(snacks.Length)];

        
        double fruehstueckKalorien = zielKalorienzufuhr * 0.25;
        double mittagessenKalorien = zielKalorienzufuhr * 0.35;
        double abendessenKalorien = zielKalorienzufuhr * 0.25;
        double snacksKalorien = zielKalorienzufuhr * 0.15;

       
        Console.WriteLine("Frühstück: " + auswahlFruehstueck + $" (ca. {fruehstueckKalorien:F2} kcal)");
        Console.WriteLine("Mittagessen: " + auswahlMittagessen + $" (ca. {mittagessenKalorien:F2} kcal)");
        Console.WriteLine("Abendessen: " + auswahlAbendessen + $" (ca. {abendessenKalorien:F2} kcal)");
        Console.WriteLine("Snacks: " + auswahlSnacks + $" (ca. {snacksKalorien:F2} kcal)");

       
        Console.WriteLine("\nEmpfohlene körperliche Aktivitäten für den Tag:");
        string[] sportAktivitaeten = {
            "30 Minuten Joggen (ca. 300 kcal)",
            "1 Stunde Radfahren (ca. 500 kcal)",
            "1 Stunde Schwimmen (ca. 600 kcal)",
            "45 Minuten Krafttraining (ca. 200 kcal)",
            "1 Stunde Yoga (ca. 200 kcal)"
        };

        string auswahlSport = sportAktivitaeten[rand.Next(sportAktivitaeten.Length)];
        Console.WriteLine(auswahlSport);
    }
}


