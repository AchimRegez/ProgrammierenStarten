using System;

namespace Modul5Aufgabe3NewLoesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe Zahl 1 ein: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gebe einen Operator ein: ");
            char operation = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Gebe Zahl 2 ein: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case '+':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 + number2);
                    break;

                case '-':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 - number2);
                    break;

                case '*':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 * number2);
                    break;

                case '/':
                    Console.WriteLine("{0} {1} {2} = {3}", number1, operation, number2, number1 / number2);
                    break;

                default:
                    Console.WriteLine("Ungültige Operation");
                    break;
            }

            Console.ReadLine();
        }
    }
}
