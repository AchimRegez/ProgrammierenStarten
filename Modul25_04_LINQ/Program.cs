using System;
using System.Linq;

namespace Modul25_04_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names =
             {
                "Janek",
                "Alina",
                "Kai",
                "Katja",
                "Hans",
                "Udo",
                "Nina",
                "Sabrina "
            };
            

            var exmpleQuery = from name in names
                              where name.Length <= 4
                              select name;


            foreach(string name in exmpleQuery)
            {
                Console.WriteLine(name);
            }

        }
    }
}
