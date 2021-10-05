using System;

namespace Modul7Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe eine Zahl ein: ");
            double number = Convert.ToDouble(Console.ReadLine());

            int numbers = 1;

            for (int i = 0; i < 10; i++)
            {
                
                Console.WriteLine("{0} * {1} = {2}", number, numbers, numbers * number);
                numbers = numbers + 1;
            }

            Console.ReadKey();
        }
    }
}
