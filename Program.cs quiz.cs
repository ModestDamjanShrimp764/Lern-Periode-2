using System.ComponentModel.Design;

string kontinenteingabe;

Console.WriteLine("Willkommen bei diesem Quiz");


    
    Console.WriteLine("Wie viele Kontinente gibt es");
    int[] kontinentauswahl = { 4, 5, 6, 7 };

    for (int i = 0; i < kontinentauswahl.Length; i++)
    {
        Console.WriteLine($"Option {i + 1}: {kontinentauswahl[i]}");
    }

while (true)
{
    Console.WriteLine("Geben sie ihre Zahl ein");
    kontinenteingabe = Console.ReadLine();

    if (kontinenteingabe == "7")
    {
        Console.WriteLine("Deine Eingabe ist richtig");
        break;
    }

    else if (kontinenteingabe == "5" || kontinenteingabe == "4" || kontinenteingabe == "6")
    {
        Console.WriteLine("Deine Zahl ist falsch geh mal lernen du coban");
    }

    else
    {

        Console.WriteLine("Ungültige Eingabe");
    }

}

Console.WriteLine("------------------------------------------------------------------");
string r;

Console.WriteLine("Kannst du die Rechnung lösen: 20*20");

while (true)
{
    r = Console.ReadLine();

    if (r == "400")
    {
        Console.WriteLine("Deine Eingabe ist richtig, du bist Genie");
        break;
    }
    else if (r != "400")

    {

        Console.WriteLine("Deine Zahl ist falsch geh mal lernen du fauler Sack");
        
    }
}
    

