using System;
using System.Linq;

/*
Schreibe eine statische Methode „Sum()“, welche die Summe aus den übergebenen Parametern zurückgibt.
Diese Methode soll 2 Überladungen besitzen:

Sum(double a, double b) → Gibt die Summe aus „a“ und „b“ zurück.

Sum(double[] numbers) → Gibt die Summe aller Zahlen im Array „numbers“ zurück.
*/

namespace Modul13Aufgabe1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Sum(3, 23);
            

            double[] numbers1 = new double[] { 12.12, 23, 45.23, 67, 69.69 };
            double[] numbers2 = new double[] { 12.12, 23, 45.23, 67, 69.69 };

            foreach(double n in numbers2)
            {
                double sum = n;
                Console.WriteLine(sum);
            }


        }             

        public static void Sum(double a, double b)
        {
            Console.WriteLine(a * b);
        }

        public static void Sum(double[] numbers2)
        {
            Console.WriteLine(numbers2);
        }
    }
}
