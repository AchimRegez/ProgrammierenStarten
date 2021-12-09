using System;

namespace Modul21KonstruktorVonRandomUndDerSeed
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle Random-Objekt
            //Zahl, die mitgegeben wird, heisst SEED
            //SEED: Eine Zahl, mit der ein Startwert für Folgen von Pseudozufallszahlen berechnet wird. Wenn eine negative Zahl angegeben wird, wird der absolute Wert der Zahl verwendet
            //Zahlen werden anhand vom SEED errechnet
            Random rnd = new Random(298641269);

            Console.WriteLine(rnd.Next(1, 10));
            Console.WriteLine(rnd.Next(1, 10));

            Console.ReadKey();
        }
    }
}
