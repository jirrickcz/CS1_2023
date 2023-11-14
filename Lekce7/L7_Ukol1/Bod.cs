namespace L7_Ukol1;

public class Bod
{
    public int X;
    public int Y;

    public Bod(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void VypisInformace()
    {
        Console.WriteLine($"Bod: {VratInformace()}");
    }

    public string VratInformace()
    {
        return $"[{X}, {Y}]";
    }
}
