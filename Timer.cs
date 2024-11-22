using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Geben Sie die Countdown-Zeit in Sekunden ein:");
        if (int.TryParse(Console.ReadLine(), out int countdownTime) && countdownTime > 0)
        {
            StartCountdown(countdownTime);
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte eine positive ganze Zahl eingeben.");
        }
    }

    static void StartCountdown(int seconds)
    {
        Console.Clear();
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine($"Verbleibende Zeit: {i} Sekunden");
            Thread.Sleep(1000); // 1 Sekunde warten
            Console.Clear();
        }

        Console.WriteLine("Zeit abgelaufen!");
        // Hier können Sie eine Aktion ausführen, wenn der Timer abgelaufen ist
    }
}
