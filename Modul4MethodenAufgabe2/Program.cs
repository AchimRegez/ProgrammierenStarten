using System;

//Schreibe 4 Methoden, die zwei Werte von Typ Float als Parameter annehmen, und anhand dieser ein
//Ergebnis als Rückgabewert zurückgeben.
//Schreibe jeweils eine Methode für die Addition, Subtraktion, Division und Multiplikation

namespace Modul04MethodenAufgabe02
{
    class Program
    {
        static void Main(string[] args)
        {
            float number1 = 1.00F;
            float number2 = 1.00F;
            
            Console.WriteLine("Bitte gebe Zahl 1 mit Nachkommastellen ein: ");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Bitte gebe Zahl 2 mit Nachkommastellen ein: ");
            number2 = float.Parse(Console.ReadLine());

            float calcA = Addition(number1, number2);
            float calcS = Subtraktion(number1, number2);
            float calcM = Multiplikation(number1, number2);
            float calcD = Division(number1, number2);

            Console.WriteLine(calcA);
            Console.WriteLine(calcS);
            Console.WriteLine(calcM);
            Console.WriteLine(calcD);

        }

        static float Addition(float numberA1, float numberA2)
        {
            float sumA = numberA1 + numberA2;
            return sumA;
        }

        static float Subtraktion(float numberS1, float numberS2)
        {
            float sumS = numberS1 - numberS2;
            return sumS;
        }

        static float Multiplikation(float numberM1, float numberM2)
        {
            float sumM = numberM1 * numberM2;
            return sumM;
        }

        static float Division(float numberD1, float numberD2)
        {
            float sumD = numberD1 / numberD2;
            return sumD;
        }

        static void Output(float output)
        {
            Console.WriteLine(output);
        }
    }
}
