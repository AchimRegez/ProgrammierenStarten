using System;

namespace Modul3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video Rechenoperationen
            int add = 2 + 3;
            int sub = 4 - 2;
            int mul = 3 * 5;
            int div = 21 / 7;

            int num1 = 3;
            int num2 = 8;
            int sum = num1 + num2;


            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraktion: " + sub);
            Console.WriteLine("Multiplikation: " + mul);
            Console.WriteLine("Division: " + div);
            Console.WriteLine("Ergebnis: " + sum);



            // Video Modulo (Restwert-Operator)
            int div2 = 6 / 4;       // 6 / 4 = 1 Rest: 2
            int savage = 6 % 4;

            Console.WriteLine("Division: " + div2);
            Console.WriteLine("Modulo: " + savage);
 




            // Übung

            int number1 = 10;
            int number2 = 2;

            int add1 = number1 + number2;
            int sub1 = number1 - number2;
            int mul1 = number1 * number2;
            int div1 = number1 / number2;
            int mod1 = number2 % number2;
            
            Console.WriteLine(number1 + " + " + number2 + " = " + add1);
            Console.WriteLine(number1 + " - " + number2 + " = " + sub1);
            Console.WriteLine(number1 + " * " + number2 + " = " + mul1);
            Console.WriteLine(number1 + " / " + number2 + " = " + div1);
            Console.WriteLine(number1 + " % " + number2 + " = " + mod1);


            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
            Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
            Console.WriteLine("{0} * {1} = {2}", number1, number2, number1 * number2);
            Console.WriteLine("{0} / {1} = {2}", number1, number2, number1 / number2);
            Console.WriteLine("{0} & {1} = {2}", number1, number2, number1 % number2);

            Console.ReadKey();


        }
    }
}
