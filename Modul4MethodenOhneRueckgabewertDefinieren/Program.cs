using System;

namespace Modul04MethodenOhneRueckgabewertDefinieren
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello("Achim", 38);
            SayHello("Franz", 56);
            SayHello("Miriam", 36);

            Console.ReadKey();
        }

        static void SayHello(string name, int age)
        {
            Console.WriteLine("Hallo {0}, du bist {1} Jahre alt!", name, age);
        }
    }
}
