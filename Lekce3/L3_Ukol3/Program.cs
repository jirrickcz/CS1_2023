Random generator = new Random();
int nahodneCislo = generator.Next(11);

int pokusuZbyva = 5;
bool uhodnuto = false;

Console.WriteLine($"Myslím si číslo od 0 do 10, hádej {pokusuZbyva}x!");

while(uhodnuto == false && pokusuZbyva > 0)
{
    pokusuZbyva--; // pokusuZbyva = pokusuZbyva - 1;

    string vstup = Console.ReadLine();
    int tip = int.Parse(vstup);

    if (tip == nahodneCislo)
    {
        uhodnuto = true;
        Console.WriteLine("Skvele.");
    }
    else
    {
        if (pokusuZbyva > 0)
        {
            Console.WriteLine($"Kdepak, zkus to znovu, mas jeste {pokusuZbyva}");
        }
        else
        {
            Console.WriteLine("Kdepak, konec hry");
        }
    }
}

Console.ReadLine();