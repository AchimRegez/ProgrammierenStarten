using System;

namespace Modul4MethodenAufgabe2Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(21, 7));
            Console.WriteLine(Subtraktion(21, 7));
            Console.WriteLine(Multiplikation(21, 7));
            Console.WriteLine(Division(21, 7));
            Console.ReadKey();
        }

        static float Addition(float number1, float number2)
        {
            return number1 + number2;
        }

        static float Subtraktion(float number1, float number2)
        {
            return number1 - number2;
        }

        static float Multiplikation(float number1, float number2)
        {
            return number1 * number2;
        }

        static float Division(float number1, float number2)
        {
            return number1 / number2;
        }
    }
}
