using System;

namespace Modul7Aufgabe2Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                Console.WriteLine("Gebe Zahl 1 ein: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gebe Zahl 2 ein: ");
                double number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Gebe einen Mathematischen Operator ein: ");
                char operation = Convert.ToChar(Console.ReadLine());


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
