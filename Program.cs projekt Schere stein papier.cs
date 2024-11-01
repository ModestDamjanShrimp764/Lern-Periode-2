string eingabe;

Console.WriteLine("Wilkommen bei Schere Stein Papier");

Console.WriteLine("Willst du die Regeln wissen[y,n}?");

while (true)

{

    eingabe = Console.ReadLine();


    if (eingabe == "y")

    {

        Console.WriteLine("Die Regeln lauten:");

        Console.WriteLine("1. Der Benutzer hat eine Auswahl von Schere, Stein und Papier");

        Console.WriteLine("2. Für jede gewonne Runde gibt es 1nen Punkt");

        Console.WriteLine("3. Für jede verlorene Runde wird einem 1nen Punkt abgezogen");

        Console.WriteLine("4. Unentschieden wird wiederholt");

        Console.WriteLine("5. Stein gewinnt gegen Schere");

        Console.WriteLine("6. Schere gewinnt gegen Papier");

        Console.WriteLine("7. Papier gewinnt gegen Stein");

        break;

    }

    else if (eingabe == "n")

    {

        Console.WriteLine("Alles klar, zeig dein können!");

        break;

    }

    else

    {

        Console.WriteLine("Gebe [y,n] ein");

    }

}

Console.WriteLine("--------------------------------------------");


Random random = new Random();

int zufallszahl = random.Next(1, 4);


string zahl;

int zahl1 = 0;


Console.WriteLine("Gebe entweder [1]für Schere [2] für Stein oder [3] für Papier ein ");

while (true)

{

    zahl = Console.ReadLine();

    if (int.TryParse(zahl, out zahl1))

    {

        if (zahl1 == 1)

        {

            Console.WriteLine("Du: Schere");

            break;

        }


        if (int.TryParse(zahl, out zahl1))

        {

            if (zahl1 == 2)

            {

                Console.WriteLine("Du: Stein");

                break;

            }

        }


        if (int.TryParse(zahl, out zahl1))

        {

            if (zahl1 == 3)

            {

                Console.WriteLine("Du: Papier");

                break;

            }

        }


        if (zahl1 != 1 || zahl1 != 2 || zahl1 != 3)

        {

            Console.WriteLine("Deine Zahl muss zwischen 1 und 3 liegen");

        }

    }


}


Console.WriteLine("vs");


while (true)

{

    if (zufallszahl == 1)

    {

        Console.WriteLine("Gegner: Schere");

        break;

    }


    if (zufallszahl == 2)

    {

        Console.WriteLine("Gegner: Stein");

        break;

    }


    if (zufallszahl == 3)

    {

        Console.WriteLine("Gegner: Papier");

        break;

    }

}


if (zahl1 == zufallszahl)

{

    Console.WriteLine("Knappes Duell, aber unentschieden");

}

else if ((zahl1 == 1 && zufallszahl == 3) || // Schere schlägt Papier

                (zahl1 == 2 && zufallszahl == 1) || // Stein schlägt Schere

                (zahl1 == 3 && zufallszahl == 2))   // Papier schlägt Stein

{

    Console.WriteLine("Du hast gewonnen");

}

else

{

    Console.WriteLine("Du hast verloren");

}

