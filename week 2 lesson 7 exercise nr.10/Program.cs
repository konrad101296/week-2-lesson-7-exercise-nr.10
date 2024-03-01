Console.WriteLine("podaj pierwsza długość");
int długosc1 = int.Parse(Console.ReadLine());
Console.WriteLine("podaj druga długosc:");
int długosc2 = int.Parse(Console.ReadLine());
Console.WriteLine("podaj trzecia długosc");
int długosc3 = int.Parse(Console.ReadLine());

if (długosc1 >= długosc3 && długosc1 >= długosc2 && długosc3 + długosc2 > długosc1)
{
    Console.WriteLine("można zdudowac trojkat");
}
else if (długosc2 >= długosc1 && długosc2 >= długosc3 && długosc1 + długosc3 > długosc2)
{
    Console.WriteLine("można zdudowac trojkat");
}
else if (długosc3 >= długosc1 && długosc3 >= długosc2 && długosc1 + długosc2 > długosc3)
{
    Console.WriteLine("można zdudowac trojkat");
}
else
{
    Console.WriteLine("nie mozna zbudowac trojkata");
}