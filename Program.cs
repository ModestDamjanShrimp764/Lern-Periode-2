using System;

namespace WetterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur Wetter-App!");

            
            string[] stadtNamen = { "Aarau", "Zürich", "Bern", "Baden", "Reinach AG", "Basel" };
            string[] wetterDaten = { "Sonnig, 25°C", "Regnerisch, 18°C", "Bewölkt, 20°C", "Sonnig, 23°C", "Windig, 21°C" };

            
            WetterAbfragen(stadtNamen, wetterDaten);
        }

        static void WetterAbfragen(string[] stadtNamen, string[] wetterDaten)
        {
            while (true) 
            {
                Console.Write("\nGib eine Stadt ein (oder 'exit' zum Beenden): ");
                string stadt = Console.ReadLine();

               
                if (stadt.ToLower() == "exit")
                {
                    Console.WriteLine("Programm beendet.");
                    break;
                }

                
                string wetterInfo = SucheWetterInfo(stadt, stadtNamen, wetterDaten);

               
                if (wetterInfo != "")
                {
                    Console.WriteLine($"Das Wetter in {stadt} ist: {wetterInfo}");
                }
                else
                {
                    Console.WriteLine("Stadt nicht gefunden. Bitte versuche es erneut.");
                }
            }
        }

        
        static string SucheWetterInfo(string stadt, string[] stadtNamen, string[] wetterDaten)
        {
            for (int i = 0; i < stadtNamen.Length; i++)
            {
                if (stadtNamen[i].ToLower() == stadt.ToLower())
                {
                    return wetterDaten[i];
                }
            }
            return ""; 
        }
    }
}
