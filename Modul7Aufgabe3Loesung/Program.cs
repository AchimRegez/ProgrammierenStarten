using System;

namespace Modul7Aufgabe3Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicationlist(12);
            Console.ReadKey();
        }

        static void Multiplicationlist(int number)
        {
            for(int i = 1; i <= 100; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
    }
}
