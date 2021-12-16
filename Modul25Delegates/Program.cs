using System;

/*
 * Was ist ein Delegate?
 * 
 * Ein Delegate ist ein Methoden-Zeiger
 * -> Ein Objekt in welches man eine oder mehrere Referenzen zu Methoden speichern kann
 * -> Über das Delegate-Objekt kann man diese Methoden dann aufrufen
 * 
 * 
 * Man verwendet Delgates z.B. um...
 * ...Methoden als Parameter übergeben können
 * ...eine aufzurufende Methode erst zur Laufzeit zu bestimmen
 * 
 * 
 */

namespace Modul25_01_Delegates
{
    class Program
    {
        delegate double Calculate(double x, double y);
        static void Main(string[] args)
        {
            Calculate calc = new Calculate(Multiplikation);

            Console.WriteLine(calc(10, 5));
            Console.ReadKey();
        }

        static double Summation(double x, double y)
        {
            return x + y;
        }

        static double Subtraktion(double x, double y)
        {
            return x - y;
        }

        static double Multiplikation(double x, double y)
        {
            return x * y;
        }

        static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
