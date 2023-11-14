public class Kolo
{
    // Znacka kola, napr. Canyon, Santa Cruz, Rose Bikes, Propain, Author
    public string Znacka;

    // napr. Torque, V10, Spectral, Tyee, Spindrift, Stitched, Grail
    public string Model;

    public double Cena;
    
    // napr. horske, freeride, silnicni, enduro, e-bike, downhill, trail, cross country...
    public string Typ;

    public Kolo(string znacka, string model, double cena, string typ)
    {
        Znacka = znacka;
        Model = model;
        Cena = cena;
        Typ = typ;
    }

    public string VratInformace()
    {
        return $"Znacka: {Znacka}, Model: {Model}";
    }
}