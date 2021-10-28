using System;
using System.Collections.Generic;

namespace Modul15Aufgabe1Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>
            {
                "Peter",
                "Alina",
                "Sabine",
                "Florian"
            };

            Console.WriteLine("Unsortiert!");
            Console.WriteLine("-----------------------");
            
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine();
            Console.WriteLine("Sortiert!");
            Console.WriteLine("-----------------------");
            
            names.Sort();
            
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();
        }
    }
}
