using System;
using System.Collections.Generic;

namespace Modul17AnonymeMethodenUndLambdaAusdrücke
{
    class Program
    {
        public delegate bool FilterDelegate(string str);

        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Horst",
                "Alina",
                "Hendrik",
                "Kai",
                "Jan",
                "Peter"
            };
            // Anonyme Methode
            List<string> newList = ReturnNewList(names, delegate(string name) { return name[0] == 'H'; });

            foreach (string name in newList)
                Console.WriteLine(name);

            List<string> newList1 = ReturnNewList(names, (name) => { return name[0] == 'A'; });

            foreach (string name in newList1)
                Console.WriteLine(name);

            List<string> newList2 = ReturnNewList(names, (name) => { return name.Length < 5; });

            foreach (string name in newList2)
                Console.WriteLine(name);

            Console.ReadKey();
        }

        static List<string> ReturnNewList(List<string> original, FilterDelegate filterMethod)
        {
            List<string> newList = new List<string>();

            foreach (string str in original)
            {
                if (filterMethod(str) == true)
                    newList.Add(str);
            }

            return newList;
        }
    }
}
