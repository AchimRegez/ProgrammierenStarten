using System;

namespace Modul7Aufgabe1Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            AllEvenNumbers(1, 10);
            Console.ReadKey();
        }

        static void AllEvenNumbers(int from, int to)
        {
            while(from <= to)
            {
                if (from %2 == 0)
                {
                    Console.WriteLine(from);
                }

                from++;
            }
        }
    }
}
