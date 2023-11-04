//Vytvorte cyklus, ktery se uzivatele bude ptat na jeho rok narozeni tak dlouho, dokud uzivatel nezada spravne cislo
//kdyz zada spravne cislo, vypocitejte jeho vek

int rokNarozeni;

Console.WriteLine("Zadej rok narozeni:");
string vstup1 = Console.ReadLine();
bool povedloSe = int.TryParse(vstup1, out rokNarozeni);
while (povedloSe == false)  //while (!povedloSe)
{
    Console.WriteLine("To neni cislo. Zkus to znovu.");
    string vstup2 = Console.ReadLine();
    povedloSe = int.TryParse(vstup2, out rokNarozeni);
}

int vek = 2023 - rokNarozeni;
Console.WriteLine($"Tvuj vek je: {vek}");