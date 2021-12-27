using System;
using System.Collections.Generic;
using System.Linq;


/*
 *Die Concat Methode
 *Zwei Sequenzen miteinander verketten
 */


namespace Modul25_18_ConcatMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names1 = new List<string>();
            List<string> names2 = new List<string>();

            names1.Add("John");
            names1.Add("Peter");
            names1.Add("Claus");

            names2.Add("Alina");
            names2.Add("Sandra");
            names2.Add("Claudia");



            Console.WriteLine("All Names:");
            var allNames = names1.Concat(names2);

            foreach (string name in allNames)
            {
                Console.WriteLine(name);
            }



            Console.WriteLine();
            Console.WriteLine("Name startet mit: 'C'");
            var allNamesStartingWithC = from name in allNames
                                        where name.ToLower()[0] == 'c'
                                        select name;

            foreach (string name in allNamesStartingWithC)
            {
                Console.WriteLine(name);
            }
        }
    }
}
