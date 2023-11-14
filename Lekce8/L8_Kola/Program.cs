// Vytvoř několik instancí třídy Kolo (třeba 5) a ulož je do pole.
// Pomocí smyčky vypiš všechny dostupné informace o kole
// Pomocí smyčky vypočti průměrnou cenu všech kol v poli
// Pomocí smyčky vypiš všechny kola jedné značky nebo v nějaké cenové hladině (např. pokud je cena nižší než 10 000)

using System.Runtime.ConstrainedExecution;

/// Definice jednotlivych kol
Kolo kolo1 = new Kolo("Olpran", "Super", 10_000, "horske");
Kolo kolo2 = new Kolo("Specialized", "Extra", 20_000, "silnicni");
Kolo kolo3 = new Kolo("Scott", "Mini", 5_000, "freeride");

// Definice pole s pevne danym poctem prvku (kdyz nevim data dopredu)
Kolo[] kola = new Kolo[3];
kola[0] = new Kolo("Jine kolo", "Excelent", 1_000, "trail");
kola[1] = kolo2;
kola[2] = kolo3;

//Definice pole pres Object initializer (kdyz znam data dopredu, nemusim psat velikost, on vi kolik jsem zadal dat)
Kolo[] kola2 = new Kolo[] {
    kolo1,
    kolo2,
    kolo3,
    new Kolo("Canyon", "Spectral", 3_000, "enduro")
};


// Pomocí smyčky vypiš všechny dostupné informace o kole
for(int i = 0; i < kola.Length; i++)
{
    //Console.WriteLine($"Znacka: {kola[i].Znacka}, Model: {kola[i].Model}");
    Console.WriteLine(kola[i].VratInformace());
}

// Pomocí smyčky vypočti průměrnou cenu všech kol v poli
double soucetCen = 0;
for(int i = 0; i < kola.Length; i++)
{
    soucetCen += kola[i].Cena;
}
double prumernaCena = soucetCen / kola.Length;
Console.WriteLine(prumernaCena);

// Pomocí smyčky vypiš všechny kola jedné značky nebo v nějaké cenové hladině (např. pokud je cena nižší než 10 000)
for(int i = 0; i < kola.Length; i++)
{
    // Mohu si zadefinovat pomocnou promennou, abych porad nepsal `kola[i]` coz muze byt dlouhe nebo matouci
    Kolo kolo = kola[i];
    if (kolo.Cena < 10_000)
    {
        Console.WriteLine(kolo.VratInformace());
    }
}
