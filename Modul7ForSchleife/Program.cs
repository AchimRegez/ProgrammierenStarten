using System;

namespace Modul7ForSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Schleifen Kopf in einzelteile zerlegt:
            // int i = 0;   --> initialisiere Zählervariable
            // i < 10;      --> Bedingung zum weitermachen
            // i++          --> erhöhe i um 1


            // For-Schleife ist eine Zählerschleife
            // Sie besitzt eine Zählervariable die man im Codeblock nutzen kann
            // Eignet sich gut zum durchlaufen von Arrays und anderen Datenstrukturen








            //////////////////////////////////////////////////////////////////////////////////////
            // For-Schleife Beispiel 1                                                          //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("For-Schleife Beispiel 1");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }



            //////////////////////////////////////////////////////////////////////////////////////
            // For-Schleife Beispiel 2                                                          //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("For-Schleife Beispiel 2");

            string[] names = new string[]
            {
                "Sebastian",
                "Horst",
                "Hendrik",
                "Franz",
                "Alina",
                "Christina",
                "Fritz",
                "Lala",
                "Lulu",
                "Nala"
            };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }







            //////////////////////////////////////////////////////////////////////////////////////
            // For-Schleife Beispiel 3                                                          //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("For-Schleife Beispiel 3");

            string[,] products = new string[,]
            {
                {
                    "Afpel",
                    "Smartphone",
                    "Schokolade"
                },
                {
                    "Lebensmittel",
                    "Elektronik",
                    "Lebensmittel"
                }
            };

            for(int zeile = 0; zeile < products.GetLength(1); zeile++)
            {
                for(int spalte = 0; spalte < products.GetLength(0); spalte++)
                {
                    Console.Write(products[spalte, zeile]);
                    Console.Write(" ");
                }

                Console.WriteLine();
            }










            Console.ReadKey();

        }
    }
}
