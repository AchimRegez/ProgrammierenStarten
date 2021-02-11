using System;

namespace Modul4MethodenPraxis
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = Subtraktion(10, 3);
            int number2 = Subtraktion(24564, 342);

            Output(number1);
            Output(number2);

            Console.ReadKey();
        }

        
        // Methodendefinition
        static int Subtraktion(int numA, int numB)
        {
            int sum = numA - numB;
            return sum;            
        }

        static void Output(int numO)
        {
            Console.WriteLine(numO);
        }

    }
}
