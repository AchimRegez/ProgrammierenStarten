using System;

namespace Modul11Aufgabe1Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund bello = new Hund("Männlich", 10);
            Katze lala = new Katze("Weiblich", 4);
            Maus feivel = new Maus("Männlich", 2);

            ITier[] tiere = new ITier[3];
            tiere[0] = bello;
            tiere[1] = lala;
            tiere[2] = feivel;

            foreach(ITier tier in tiere)
            {
                Console.WriteLine("Geschlecht: {0}", tier.Geschlecht);
                Console.WriteLine("Alter: {0}", tier.Alter);
                tier.Fressen();
                tier.Trinken();

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
