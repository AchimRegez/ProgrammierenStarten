using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *Die Union Methode
 *2 Collections verketten, ohne doppelten Werten
 *
 *
 *Was ist die Union Methode?
 *->Die Union Methode ruft man auf einer Collection auf und übergibt als Parameter eine andere Collection
 *->Sie gibt eine neue Collection zurück, die alle Werte der beiden Collections enthält (ohne doppelten Werten)
 *
 *
 *Braucht für eigene Klassen auch wieder eine Comparer Klasse wie in Modul_25_DistinctMethode und Modul_25_ExceptMethode
 * 
 */


namespace Modul25_22_UnionMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections            
            string[] names1 =
            {
                "Hendrik",
                "Alina",
                "Janek",
                "Claus"
            };

            string[] names2 =
            {
                "Hendrik",
                "Tom",
                "Peter",
                "Anna",
                "Claus"
            };

            var names3 = names1.Union(names2);

            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }
        }
    }
}
