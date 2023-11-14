class Odpocitavac {
    private int _hodnota;

    public Odpocitavac(int hodnota)
    {
        _hodnota = hodnota;
    }

    public void OdectiJednicku()
    {
        _hodnota -= 1;
    }

    public void VypisZbyvajiciPocet()
    {
        Console.WriteLine(_hodnota);
    }
}
