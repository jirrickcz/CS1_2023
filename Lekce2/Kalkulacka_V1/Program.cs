//Požádejte uživatele o zadání prvního čísla (ukládejte jako double, ať můžeme dělit a nezapomeňte, že v dotnetfiddle se používá desetinná tečka, zatímco ve Visual Studiu a jiných editorech to může být desetinná čárka, pokud máte operační systém v češtině) a pomocí double.Parse převeďte vstup na číselnou hodnotu.
//Poté požádejte uživatele o zadání operátoru pro matematickou operaci sčítání(+), odčítání(-), násobení(*) nebo dělení(/). Uživatel napíše jedno ze čtyř znamének a vy jej uložíte do string proměnné.
//Nakonec zopakujte první odrážku v této verzi, akorát pro druhé číslo.
//V tuto chvíli tedy máte dvě čísla a operátor.Vytvořte vícenásobný if-else, podle obsahu proměnné s operátorem(4 případy) vypočítejte výsledek operace, ten uložte do předpřipravené proměnné.
//Nakonec vypište celou operaci a k tomu výsledek.

Console.WriteLine("Zadej prvni cislo:");
string input1 = Console.ReadLine();
double cislo1 = double.Parse(input1);

Console.WriteLine("Zadej operator:");
string operace = Console.ReadLine();

Console.WriteLine("Zadej druhe cislo:");
string input2 = Console.ReadLine();
double cislo2 = double.Parse(input2);

if (operace == "+")
{
    double vysledek = cislo1 + cislo2;
    Console.WriteLine($"Vysledek: {cislo1} + {cislo2} = {vysledek}");
}
else if (operace == "-")
{
    double vysledek = cislo1 - cislo2;
    Console.WriteLine($"Vysledek: {cislo1} - {cislo2} = {vysledek}");
}
else if (operace == "*")
{
    double vysledek = cislo1 * cislo2;
    Console.WriteLine($"Vysledek: {cislo1} * {cislo2} = {vysledek}");
}
else if (operace == "/")
{
    double vysledek = cislo1 / cislo2;
    Console.WriteLine($"Vysledek: {cislo1} / {cislo2} = {vysledek}");
}
else
{
    Console.WriteLine("Neplatny operator");
}