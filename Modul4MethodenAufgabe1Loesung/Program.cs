using System;

namespace Modul04MethodenAufgabe01Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Begruessung("Achim");
            Begruessung("Felix");
            Console.ReadKey();
        }

        static void Begruessung(string name)
        {
            Console.WriteLine("Hallo {0}", name);
        }
    }
}
