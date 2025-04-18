namespace CSharp_lekce02;

class Program
{
    static void Main(string[] args)
    {
        // BR 1
        // NumDaysToVacation();
        // ----------------------------------

        // BR 2
        //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
        //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
        //Do metody Main doplnte blok try-catch, ktery uzivatele upozorni, pokud udela chybu
        //Muzete pouzit obecnou tridu Exception, nebo lepe specifickou ArgumentException
        Console.WriteLine("Program na vytvareni telefonniho seznamu");
        Console.WriteLine("Zadejte jmeno: ");
        try
        {
            ControlInput();
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }

    }

    private static void ControlInput()
    {
        string jmeno = Console.ReadLine();

        Console.WriteLine("Zadejte telefonni cislo: ");

        string cislo = Console.ReadLine();

        Clovek prvniClovek = new Clovek(jmeno, int.Parse(cislo));

        prvniClovek.VypisJmenoACislo();

        Console.ReadLine();
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
