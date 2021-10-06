using System;

namespace Modul10EigenschaftenUndDatenkapselung
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Hersteller = "BMW";
            Console.WriteLine(auto.Hersteller);            
            auto.AnzahlTueren = 4;
            Console.WriteLine(auto.AnzahlTueren);
        }

        class Auto
        {
            //Eigenschaften
            public string Hersteller { get; set; }

            private int anzahlTueren;
            public int AnzahlTueren
            {
                get
                {
                    return anzahlTueren;
                }
                set
                {
                    if (value < 1)
                    {
                        anzahlTueren = 1;
                    }
                    else
                    {
                        anzahlTueren = value;
                    }
                }
            }
        }
    }
}
