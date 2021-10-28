using System;
using System.Collections.Generic;

namespace Modul16GenerischeMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>();
            AddMultiple<string>(namesList, 5, "Hans Nötig");

            foreach(string name in namesList)
                Console.WriteLine(name);

            Console.ReadKey();
        }

        static void AddMultiple<T>(List<T> list, int amount, T value)
        {
            for(int i = 0; i < amount; i++)
            {
                list.Add(value);
            }
        }
    }
}
