using System;

namespace Modul5Aufgabe2NewLoesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe eine Jahreszahl ein: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine("Das {0} ist ein Schaltjahr", year);
            }
            else
            {
                Console.WriteLine("Das {0} ist kein Schaltjahr", year);
            }

            Console.ReadKey();
        }

        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }
    }
}
