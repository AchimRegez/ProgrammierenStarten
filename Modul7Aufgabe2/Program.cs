using System;

namespace Modul7Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {

            int loopNumber = 0;

            while (loopNumber < 1)
            {
                double number1 = 0;
                double number2 = 0;
                char operation;

                Console.Write("Gebe Zahl1 ein: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gebe Zahl2 ein: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gebe den Rechenoperator ein: ");
                operation = Convert.ToChar(Console.ReadLine());


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

                Console.ReadKey();
                Console.Clear();

            }

        }
    }
}
