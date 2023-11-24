namespace L9_Kalkulacka;

public class Kalkulacka
{
    public Kalkulacka() : this(0)
    {
    }

    public Kalkulacka(double prvniCislo)
    {
        _posledniVysledek = prvniCislo;
    }

    private double _posledniVysledek;

    public void Secti(double cislo){
        _posledniVysledek += cislo;
    }

    public void Odecti(double cislo){
        _posledniVysledek -= cislo;
    }

    public void Vynasob(double cislo){
        _posledniVysledek *= cislo;
    }

    public void Vydel(double cislo){
        _posledniVysledek /= cislo;
    }

    public void Umocni(double cislo){
        _posledniVysledek = Math.Pow(_posledniVysledek, cislo);
    }

    public double ZiskejVysledek(){
        return _posledniVysledek;
    }

}
