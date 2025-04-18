namespace CSharp_lekce02;

class Program
{
    static void Main(string[] args)
    {
        NumDaysToVacation();
    }

    private static void NumDaysToVacation()
    {
        // Zbyvajici dny do dovolene
        // Postupne se uzivatele zeptej na den, mesic a rok odjezdu na dovolenou. Pomoci DateTime a TimeSpan vypocitej pocet
        // zbyvajicich dni do odjezdu na dovolenou a vypis je na konzoli.
        // Pozn.: pro zjednoduseni staci pouzit int.Parse
        Console.WriteLine("Kdy odjíždíš na dovolenou? Zadej den.");
        string vstup = Console.ReadLine();
        int.TryParse(vstup, out int den);

        Console.WriteLine("Zadej měsíc.");
        vstup = Console.ReadLine();
        int.TryParse(vstup, out int mesic);

        Console.WriteLine("Zadej rok.");
        vstup = Console.ReadLine();
        int.TryParse(vstup, out int rok);

        DateTime dateOfVac = new DateTime(rok, mesic, den);

        TimeSpan cas = dateOfVac - DateTime.Now;

        Console.WriteLine($"Zbývá {cas.Days} dní do tvé dovolené.");
    }
}
