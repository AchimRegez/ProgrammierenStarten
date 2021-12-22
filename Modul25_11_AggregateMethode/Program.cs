using System;
using System.Linq;
using System.Collections.Generic;

/*
 *Die Aggregate-Methode
 * Mathematische Operationen an den Ergebnissen einer Query durchführen
 * 
 * 
 * Was ist die Aggregate-Methode?
 * ->Die Aggregate-Methode führt eine Operation auf jedem Element der Liste aus und gibt dabei immer das Ergebnis an das nächste Element weiter
 * ->Man übergibt bei jedem Durchlauf das vorherige Ergebnis als Parameter mit und den Wert den man aktuell durchläuft
 */

namespace Modul25_12_AggregateMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };

            var result = numbers.Aggregate((currentValue, nextValue) => currentValue + nextValue);

            Console.WriteLine(result);



            string[] names = { "Tom", "Peter", "Alina", "Sabrina" };

            var resultNames = names.Aggregate((string1, string2) => string1 + ", " + string2);

            Console.WriteLine(resultNames);
        }
    }
}
