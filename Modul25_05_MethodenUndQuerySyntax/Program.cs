using System;
using System.Linq;

/*
 * Methoden und Query Syntax
 * Die 2 verschiedenen Arten um LINQ-Abfragen zu definieren
 * 
 * 
 * Query Syntax
 * ->Sehr stark angelehnt an SQL
 * ->Für Entwickler die bereits mit SQL gearbeitet haben und damit gut klarkokmmen
 * 
 * 
 * Methoden Syntax
 * ->Ermöglicht das definieren von LINQ-Abfragen mit reinem klassischen C#-Code
 * ->Methoden aus dem Namespace "System.Linq" ruft man hierbei selbst auf
 */

namespace Modul25_05_MethodenUndQuerySyntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names =
            {
                "John",
                "Alina",
                "Hendrik",
                "Kai",
                "Sabrina",
                "Angela",
                "Janek"
            };

            //Query Syntax
            var testQuery = from name in names
                            where name.Contains("J")
                            where name.Length <= 6
                            select name;

            Console.WriteLine("Query-Syntax");
            foreach (string name in testQuery)
            {
                Console.WriteLine(name);
            }


            //Methoden Syntax
            var testQuery2 = names.Where(name => name.Contains("J"));

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax");
            foreach (string name in testQuery2)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

        }
    }
}
