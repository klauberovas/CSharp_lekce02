using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace CSharp_lekce02
{
    public class Clovek
    {
        //Upravte tridu Clovek tak, aby konstruktor vyhodil vyjimku, pokud jmeno neni platne (null nebo prazdny string)
        //nebo pokud tel cislo neni validni (zkontrolujte pocet cislic). Tip: Delku cisla zjistite zavolanim telCislo.ToString().Length.
        public string Jmeno;
        public int TelCislo;

        public Clovek(string jmeno, int telCislo)
        {
            var errors = new List<string>();

            if (string.IsNullOrWhiteSpace(jmeno))
            {
                errors.Add("The name must not empty.");
            }
            if (telCislo.ToString().Length != 9)
            {
                errors.Add("The length of phone number must contain 9 numbers.");
            }

            if (errors.Count > 0)
            {
                throw new ArgumentException(string.Join(" ", errors));
            }
            Jmeno = jmeno;
            TelCislo = telCislo;
        }

        public string VypisJmenoACislo()
        {
            return $"{Jmeno}: {TelCislo}";
        }
    }
}