using System;
using System.Collections.Generic;
using System.Linq;


/*
 *Empty(), Range() und Repeat() 
 *Methoden zum Generieren von Collections
 *
 *
 *Die Empty() Methode
 *->Die Empty Methode gibt eine leere Collection von einem gewünschten Typen zurück
 *->Sie ist keine Erweiterungsmethode von "IEnumerable" sondern als statische Methode in der statischen Klasse "Enumerable" definiert
 * 
 * 
 * 
 * Die Range() Methode
 * ->Die Range() Methode gibt eine Collection vom Typ "IEnumerable<int>" zurück, die eine bestimmte Anzahl an Elementen und eine Sequenz von Werten beinhaltet
 * ->Auch diese Methode ist als statische Methode in der Klasse "Enumerable"implementiert
 * 
 * 
 * 
 * Die Repeat() Methode
 * ->Die Repeat() Methode gibt eine Collection vom Typ "IEnumerable<T> zurück, die eine bestimmte Anzahl an Elementen mit immer demselben angegebenen Wert beinhaltet
 * ->Auch diese Methode ist als statische Methode in der Klasse "Enumerable" implementiert 
 */



namespace Modul25_17_EmptyRangeUndRepeat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empty() Methode
            Console.WriteLine("Empty Method");
            var emptyCollection = Enumerable.Empty<string>();

            Console.WriteLine(emptyCollection.Count());
            Console.WriteLine(emptyCollection.GetType());



            //Range() Methode
            Console.WriteLine();
            Console.WriteLine("Range Method");
            var numbers = Enumerable.Range(10, 10);

            for (int i = 0; i < numbers.Count(); i++)
            {
                Console.WriteLine("Index[{0}] = {1}", i, numbers.ElementAt(i));
            }



            //Repeat() Methode
            Console.WriteLine();
            Console.WriteLine("Repeat Method");
            var numbersRepeat = Enumerable.Repeat<string>("Hallo Welt", 10);

            for (int i = 0; i < numbersRepeat.Count(); i++)
            {
                Console.WriteLine("Index[{0}] = {1}", i, numbersRepeat.ElementAt(i));
            }
        }
    }
}
