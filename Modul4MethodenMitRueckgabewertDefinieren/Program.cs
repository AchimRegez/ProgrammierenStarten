using System;

namespace Modul4MethodenMitRueckgabewertDefinieren
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = Addition(3, 7);
            Console.WriteLine(zahl);

            Console.WriteLine(AdditionShort(10, 2));
            Console.ReadKey();
        }

        static int Addition(int number1, int number2)
        {
            int ergebnis = number1 + number2;
            return ergebnis;
        }


        static int AdditionShort(int number3, int number4)
        {
            return number3 + number4;
        }
    }
}
