class Album {
    private int _pocetStranek;

    public Album(int pocetStranek)
    {
        if (pocetStranek > 100)
        {
            Console.WriteLine("Prekrocil jsi maximum");
            pocetStranek = 100;
        }
        _pocetStranek = pocetStranek;
    }

    public Album() : this(16)
    {
    }

    public void VypisPocetStranek()
    {
        Console.WriteLine(_pocetStranek);
    }
}