using System;

namespace Modul61DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[4];

            names[0] = "Hans";
            names[1] = "Franz";
            names[2] = "Eva";
            names[3] = "Lulu";

            Console.WriteLine(names[0]);
            Console.WriteLine("Hallo {0}, {1}, {2} und {3}!", names[0], names[1], names[2], names[3]);
            Console.WriteLine();



            // Kurzschreibweise oder wenn bekannt was in Arrays kommt
            string[] otherNames = new string[]
            {
                "Alina", 
                "Janek", 
                "Horst", 
                "Hendrik"
            };

            Console.WriteLine(otherNames[0]);
            Console.WriteLine("Hallo {0}, {1}, {2} und {3}!", otherNames[0], otherNames[1], otherNames[2], otherNames[3]);

            Console.ReadKey();
        }
    }
}
