using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *Die Intersect Methode 
 *Gemeinsame Werte von 2 Collections herausfinden
 *
 *
 *Was ist die Intersect Methode?
 *->Die Intersect() Methode ruft man auf einer Collection auf und übergibt als Parameter eine andere Collection
 *->Sie gibt eine neue Collection mit allen Werten zurück, die in der ersten und zweiten Collection vorkommen --> Alle gemeinsamen Werte
 * 
 * 
 * Braucht für eigene Klassen auch wieder eine Comparer Klasse wie in Modul_25_DistinctMethode und Modul_25_ExceptMethode
 */


namespace Modul25_21_IntersectMethode
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

            var names3 = names1.Intersect(names2);

            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }
        }
    }
}
