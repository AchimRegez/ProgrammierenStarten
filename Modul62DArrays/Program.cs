using System;

namespace Modul62DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] products = new string[2, 3];  //[2, 3] 2 Spalten X Achse / 3 Zeilen Y Achse

            //Produkt 1 (Zeile 1)
            products[0, 0] = "Senf";
            products[1, 0] = "Lebensmittel";


            //Produkt 2 (Zeile 2)
            products[0, 1] = "Smartphone";
            products[1, 1] = "Elektronik";


            //Produkt 3 (Zeile 3)
            products[0, 2] = "Schokolade";
            products[1, 2] = "Lebensmittel";


            Console.WriteLine(products[0, 0] + " " + products[1, 0]);
            Console.WriteLine(products[0, 1] + " " + products[1, 1]);
            Console.WriteLine(products[0, 2] + " " + products[1, 2]);
            Console.WriteLine();






            // Kurzschreibweise oder wenn bekannt was in Arrays kommt
            string[,] otherProducts = new string[,]
            {
                {
                    "Ketchup",
                    "XBox",
                    "Kekse"
                },
                {
                    "Lebensmittel",
                    "Elektronik",
                    "Lebensmittel",
                }
            };

            Console.WriteLine("Array Kurzform:");
            Console.WriteLine(otherProducts[0, 0] + " " + otherProducts[1, 0]);
            Console.WriteLine(otherProducts[0, 1] + " " + otherProducts[1, 1]);
            Console.WriteLine(otherProducts[0, 2] + " " + otherProducts[1, 2]);
            Console.ReadKey();


        }
    }
}
