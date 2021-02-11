using System;

namespace Modul4MethodenAufgabe1Loesung
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
