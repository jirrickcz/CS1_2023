using L9_Kalkulacka;

public class Program
{
public static void Main()
	{
        Kalkulacka2 kalkulacka = new Kalkulacka2();

		while (true)
		{
            double cislo = NactiCislo("");

			Console.WriteLine("Zadejte operator (+, -, *, /, ^, =): Pro ukonceni programu zadejte X.");
			string operatorZnak = Console.ReadLine();
            if (operatorZnak.ToUpper() == "X")
			{
				Console.WriteLine("Konec programu.");
				return;
			}
			while (!(operatorZnak == "+" || operatorZnak == "-" || operatorZnak == "*" || operatorZnak == "/" || operatorZnak == "^" || operatorZnak == "="))
			{
				Console.WriteLine("Neplatny operator. Zadejte znovu.");
				operatorZnak = Console.ReadLine();
			}

			Console.WriteLine($"Nový výsledek: {kalkulacka.ProvedOperaci(cislo, operatorZnak)}");
		}
	}

	public static void MainOld()
	{
        double prvniCislo = NactiCislo("prvni");
        Kalkulacka kalkulacka = new Kalkulacka(prvniCislo);

		while (true)
		{
			Console.WriteLine("Zadejte operator (+, -, *, /, ^): Pro ukonceni programu zadejte X.");
			string operatorZnak = Console.ReadLine();
            if (operatorZnak.ToUpper() == "X")
			{
				Console.WriteLine("Konec programu.");
				return;
			}
			while (!(operatorZnak == "+" || operatorZnak == "-" || operatorZnak == "*" || operatorZnak == "/" || operatorZnak == "^"))
			{
				Console.WriteLine("Neplatny operator. Zadejte znovu.");
				operatorZnak = Console.ReadLine();
			}

			double dalsiCislo = NactiCislo("dalsi");

            switch (operatorZnak)
            {
            case "+":
                kalkulacka.Secti(dalsiCislo);
                break;
            case "-":
                kalkulacka.Odecti(dalsiCislo);
                break;
            case "/":
                kalkulacka.Vydel(dalsiCislo);
                break;
            case "*":
                kalkulacka.Vynasob(dalsiCislo);
                break;
            case "^":
                kalkulacka.Umocni(dalsiCislo);
                break;
            }

            double vysledek = kalkulacka.ZiskejVysledek();
			Console.WriteLine($"Výsledek: {prvniCislo} {operatorZnak} {dalsiCislo} = {vysledek}");
            prvniCislo = vysledek;
		}
	}

    private static double NactiCislo(string jakeCislo){
        Console.WriteLine($"Zadejte {jakeCislo} cislo:");
        bool jeCislo = double.TryParse(Console.ReadLine(), out double cislo);
        while (!jeCislo)
        {
            Console.WriteLine($"Neplatne {jakeCislo} cislo. Zkuste znovu:");
            jeCislo = double.TryParse(Console.ReadLine(), out cislo);
        }
        return cislo;
    }
}