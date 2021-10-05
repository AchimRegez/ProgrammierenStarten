using System;

namespace Modul7Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while(number < 10)
            {
                number++;

                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }       
                
            }

            Console.ReadKey();
        }
    }
}
