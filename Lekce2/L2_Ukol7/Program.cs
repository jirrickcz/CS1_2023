//1.Vytvoř tři celočíselné proměnné, např. "cislo1", "cislo2", "cislo3" a přiřaď jim libovolné hodnoty.Vytvoř taky prázdnou proměnnou "vysledek".Pokud je "cislo3" větší než 5, ulož do proměnné "vysledek" součet "cislo1" a "cislo2", jinak proveď rozdíl. "vysledek" potom vypiš uživateli na obrazovku.
int cislo1 = 300;
int cislo2 = 3;
int cislo3 = -6;
int vysledek;
if (cislo3 > 5)
{
    vysledek = cislo1 + cislo2;
}
else
{
    vysledek = cislo1 - cislo2;
}
Console.WriteLine(vysledek);