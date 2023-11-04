// 5. (Bonus 1) Od uzivatele nacti nacti dve celociselne promenne. Nakonec obě hodnoty sečti a vypiš uživateli na obrazovku.
Console.WriteLine("Zadej prvni cislo:");
string input1 = Console.ReadLine();
int cislo1 = int.Parse(input1);

Console.WriteLine("Zadej druhe cislo:");
string input2 = Console.ReadLine();
int cislo2 = int.Parse(input2);

Console.WriteLine("Vyskedek:");
Console.WriteLine(cislo1 + cislo2);