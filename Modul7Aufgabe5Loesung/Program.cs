using System;

namespace Modul7Aufgabe5Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 10; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("{0} * {1} = {2}", j, i, j * i);

                    int spaces = (j * 10) - Console.CursorLeft;

                    for(int k = 0; k < spaces; k++)
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
