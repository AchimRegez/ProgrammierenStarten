using System;

namespace Modul5Aufgabe3New
{
    /*
     * Schreibe einen sehr einfachen Rechner in der Konsole. Dieser bittet den Benutzer zuerst eine Zahl1 einzugeben, dann bittet er um die Eingabe eines mathematischen Operators (+, -, *, /) und dann wird noch um eine Zahl2 gebeten.
Anschließend soll die passende mathematische Operation an den beiden Zahlen durchgeführt werden und als mathematischer Ausdruck mit Ergebnis ausgegeben werden.
Beispielausgabe: „2 + 4 = 6“
    */

    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;

            Console.WriteLine("Bitte gib Zahl 1 ein: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib Zahl 2 ein: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib die Mathematische Operation (+, -, *, /) ein: ");
            string mathOperator = Console.ReadLine();

            switch (mathOperator)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("{0} " + "{1} " + "{2} " + "= {3}", number1, mathOperator, number2, result);
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine("{0} " + "{1} " + "{2} " + "= {3}", number1, mathOperator, number2, result);
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine("{0} " + "{1} " + "{2} " + "= {3}", number1, mathOperator, number2, result);
                    break;

                case "/":
                    result = number1 / number2;
                    Console.WriteLine("{0} " + "{1} " + "{2} " + "= {3}", number1, mathOperator, number2, result);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe!");
                    break;
            }

            Console.ReadKey();

        }
    }
}
