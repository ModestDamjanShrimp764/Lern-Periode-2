Console.WriteLine("Willkomme beim Taschenrechner von Damjan");
Console.WriteLine("Gebe sie die erste Zahl ein");
double zahl1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Geben sie den Operator +,-,*,/");
string operatorsymbol = Console.ReadLine();

Console.WriteLine("Geben sie die Zahl2 ein");
double zahl2 = Convert.ToDouble(Console.ReadLine());
double ergebnis = 0;
if (operatorsymbol == "+")
{
    ergebnis = zahl1 + zahl2;
}
else if (operatorsymbol == "-")
{
    ergebnis = zahl1 - zahl2;
}
else if (operatorsymbol == "*")
{
    ergebnis = zahl1 * zahl2;
}
else if (operatorsymbol == "/")
{
    ergebnis = zahl1 / zahl2;
}
else
{
    Console.WriteLine("Ungültiger Operator");
}
Console.WriteLine("ergebnis:" + ergebnis);

