// Cyklus, ktery vypise poporade vsechna cisla od 0 do 20
// modifikujte cyklus tak, aby vypsal jen suda cisla 
// volitelne si od uzivatele vyzadejte pocatecni a koncova cisla, aby mohl vypsat napr. vsechna suda cisla od 100 od 200

Console.WriteLine("Vsechna cisla od 0 do 20:");
for (int i = 0; i <= 20; i++) 
{
    Console.WriteLine(i);
}

Console.WriteLine("Vsechna cisla od 20 do 0:");
for (int i = 20; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("Suda cisla od 1 do 20 podle Jirky:");
for (int i = 1; i <= 20; i++) //i = i + 1
{
    int zbytekPoDeleni2 = (i % 2);
    bool jeSude = (zbytekPoDeleni2 == 0);
    if (jeSude)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Suda cisla od 0 do 20 podle Honzy:");
for (int i = 0; i <= 20; i = i + 2)
{
    Console.WriteLine(i);
}

//Console.WriteLine("Suda cisla od X do Y:");
//int dolniMez = X; // jako u roku narozeni
//int horniMez = Y; // to same jen podruhe

//for (int i = dolniMez; i <= horniMez; i++) //i = i + 1
//{
//    int puvodniCislo = i; // 7
//    int puvodniCisloDeleno2 = puvodniCislo / 2; // 3
//    int vynasobenoZpet2 = puvodniCisloDeleno2 * 2; // 6
//    bool jeSude = (puvodniCislo == vynasobenoZpet2);

//    if (jeSude)
//    {
//        Console.WriteLine(i);
//    }
//}