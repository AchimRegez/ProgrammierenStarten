using System;
using System.Collections.Generic;

namespace Modul15Lists_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();

            namesList.Add("Hans");      // Index 0
            namesList.Add("Sabrina");   // Index 1 usw...
            namesList.Add("George");
            namesList.Add("Cathy");

            namesList.Remove("Hans");
            namesList.RemoveAt(2);

            foreach(string name in namesList)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(namesList[0]);

            List<string> namesList2 = new List<string>()
            {
                "Alina",
                "Felix",
                "Fritz",
                "Isabell"
            };

            Console.WriteLine(namesList2[3]);

            Console.ReadKey();
        }
    }
}
