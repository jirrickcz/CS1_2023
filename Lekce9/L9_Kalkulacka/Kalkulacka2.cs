namespace L9_Kalkulacka;

public class Kalkulacka2
{
    private double _posledniVysledek = 0;
    private string _posledniOperace = "=";

    public double Secti(double cislo)
    {
        return ProvedOperaci(cislo, "+");
    }

    public double Odecti(double cislo)
    {
        return ProvedOperaci(cislo, "-");
    }

    public double Vynasob(double cislo)
    {
        return ProvedOperaci(cislo, "*");
    }

    public double Vydel(double cislo)
    {
        return ProvedOperaci(cislo, "/");
    }

    public double Umocni(double cislo)
    {
        return ProvedOperaci(cislo, "^");
    }

    public double Vysledek(double cislo)
    {
        return ProvedOperaci(cislo, "=");
    }

    public double ProvedOperaci(double cislo, string operace)
    {
        switch (_posledniOperace)
        {
            case "=":
                _posledniVysledek = cislo;
                break;
            case "+":
                _posledniVysledek += cislo;
                break;
            case "-":
                _posledniVysledek -= cislo;
                break;
            case "*":
                _posledniVysledek *= cislo;
                break;
            case "/":
                _posledniVysledek /= cislo;
                break;
            case "^":
                _posledniVysledek = Math.Pow(_posledniVysledek, cislo);
                break;
        }
        _posledniOperace = operace;
        return _posledniVysledek;
    }
}
