using System;

namespace Modul21RandomNextMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zufallszahl:");
            //Erzeuge Random Objekt
            Random rnd = new Random();

            //Erzeuge Zufallszahl zwischen 1 und 9 -> MERKE 10 ist EXKLUSIV (nicht mehr enthalten)
            int numb = rnd.Next(1, 10);

            //Ausgabe
            Console.WriteLine(numb);

            //Console.ReadKey();




            //Städte-Zufallsgenerator
            //Erstelle Städte-Array
            Console.WriteLine();
            Console.WriteLine("Städte-Zufallsgenerator:");
            string[] cityList = new string[]
            {
                "Berlin",
                "Ingoldstadt",
                "Düsseldorf",
                "Duisburg"
            };

            //Erzeuge Random Objekt
            Random cityRandom = new Random();

            for(int i = 0; i < 5; i++)
            {
                //Erzeuge zufälligen Index -> 4 ist EXKLUSIV, nur 4 Objekte im Array Index: 0,1,2,3
                int index = cityRandom.Next(0, cityList.Length);

                //Gebe Stadt aus
                Console.WriteLine(cityList[index]);
            }
            

            Console.ReadKey();
        }
    }
}
