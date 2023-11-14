namespace L7_Ukol1;

public class Usecka
{
    public Bod BodA;
    public Bod BodB;

    public Usecka(Bod bodA, Bod bodB)
    {
        BodA = bodA;
        BodB = bodB;
    }

    public void VypisInformace()
    {
        Console.WriteLine($"Usecka: {BodA.VratInformace()}, {BodB.VratInformace()}");
    }
}
