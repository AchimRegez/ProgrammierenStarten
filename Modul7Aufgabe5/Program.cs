using System;

namespace Modul7Aufgabe5
{
    class Program
    {
        static void Main(string[] args)
        {
            LittleMultiplicationTables();
            Console.ReadKey();
        }

        static void LittleMultiplicationTables()
        {
            for(int y = 1; y <= 10; y++)
            {
                for(int x =1; x <= 10; x++)
                {
                    Console.Write("{0} * {1} = {2}  |", y, x, y * x);
                }

                Console.WriteLine();
            }
        }
    }
}
