// 6. (Bonus 2) Vytvoř dvě int proměnné, potom do každé z nich ulož nějakou hodnotu.Zkus hodnoty v těch dvou proměnných prohodit, aniž bys o některou z nich přišla.Můžeš použít pomocnou proměnnou.
int cislo1 = 15;
int cislo2 = 35;
Console.WriteLine("cislo 1: " + cislo1);
Console.WriteLine("cislo 2: " + cislo2);
int pomoc = cislo1;
cislo1 = cislo2;
cislo2 = pomoc;
Console.WriteLine("cislo 1: " + cislo1);
Console.WriteLine("cislo 2: " + cislo2);