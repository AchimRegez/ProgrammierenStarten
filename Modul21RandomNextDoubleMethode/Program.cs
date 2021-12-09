using System;

namespace Modul21RandomNextDoubleMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erzeuge Random-Objekt
            Random rnd = new Random();

            //Erstelle Zufallsdouble
            double numb = rnd.NextDouble();

            //Gebe die Zahl aus
            Console.WriteLine(numb);

            Console.ReadKey();
        }
    }
}
