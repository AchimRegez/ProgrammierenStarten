using System;

namespace Modul6Aufgaben
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aufgabe 1

            string[] products = new string[4];

            products[0] = "Wasserflasche";
            products[1] = "Kaugummi";
            products[2] = "Nudeln";
            products[3] = "Kartoffeln";



            string[] shortProducts = new string[]
            {
                "Wasserflasche",
                "Kaugummi",
                "Nudeln",
                "Kartoffeln"
            };


            Console.WriteLine(products[0] + ", " + products[1] + ", " + products[2] + ", " + products[3]);
            Console.WriteLine("Bitte kaufe folgende Produkte: {0}, {1}, {2}, {3}.", shortProducts[0], shortProducts[1], shortProducts[2], shortProducts[3]);
            Console.WriteLine();





            // Aufgabe 2

            string[,] names = new string[2, 4];

            // Zeile 1
            names[0, 0] = "Sabine";
            names[1, 0] = "Müller";

            // Zeile 2
            names[0, 1] = "Sandra";
            names[1, 1] = "Maier";

            // Zeile 3
            names[0, 2] = "Klaus";
            names[1, 2] = "Schmied";

            // Zeile 4
            names[0, 3] = "Hans";
            names[1, 3] = "Nötig";





            string[,] shortNames = new string[,]
            {
                {
                    "Sabine",
                    "Sandra",
                    "Klaus",
                    "Hans"
                },
                {
                    "Müller",
                    "Maier",
                    "Schmied",
                    "Nötig"
                }
            };

            Console.WriteLine("Array Kurzform:");
            Console.WriteLine(names[0, 0] + " " + names[1, 0]);
            Console.WriteLine("Hallo {0} {1}, {2} {3}, {4} {5} und {6} {7}!", shortNames[0, 0], shortNames[1, 0], shortNames[0, 1], shortNames[1, 1], shortNames[0, 2], shortNames[1, 2], shortNames[0, 3], shortNames[1, 3]);
            Console.ReadKey();


        }
    }
}
