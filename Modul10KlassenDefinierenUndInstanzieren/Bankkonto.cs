using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10KlassenDefinierenUndInstanzieren
{
    class Bankkonto
    {
        //Eigenschaften (schreibt man Gross)
        public decimal Kontostand { get; set; }
        public string Besitzer { get; set; }

        //Methoden
        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
            Console.WriteLine("Es wurden {0} CHF auf das Konto eingezahlt!", betrag);
            Console.WriteLine("Der neue Kontostand beträgt {0} CHF!", Kontostand);
        }

        public void Auszahlen(decimal betrag)
        {
            Kontostand -= betrag;
            Console.WriteLine("Es wurden {0} CHF vom Konto abgehoben!", betrag);
            Console.WriteLine("Der neue Kontostand beträgt {0} CHF!", Kontostand);
        }
    }
}
