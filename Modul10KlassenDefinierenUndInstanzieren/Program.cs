using System;

namespace Modul10KlassenDefinierenUndInstanzieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankkonto konto = new Bankkonto();
            Bankkonto konto2 = new Bankkonto();
            konto.Kontostand = 2500;
            konto.Besitzer = "Hans Nötig";

            konto2.Kontostand = 5375;
            konto2.Besitzer = "Hans No-Nötiger";

            konto.Einzahlen(250);
            konto.Auszahlen(500);

            konto2.Einzahlen(1523);
            konto2.Auszahlen(375);

            Console.WriteLine("Kontostand: {0}", konto.Kontostand);
            Console.WriteLine("Der Besitzer des Kontos ist: {0}", konto.Besitzer);

            Console.WriteLine("Kontostand: {0}", konto2.Kontostand);
            Console.WriteLine("Der Besitzer des Kontos ist: {0}", konto2.Besitzer);

            Console.ReadKey();
        }
    }
}
