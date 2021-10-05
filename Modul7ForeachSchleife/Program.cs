using System;

namespace Modul7ForeachSchleife
{
    class Program
    {
        static void Main(string[] args)
        {

            // Aufbau der Foreach-Schleife

            int[] numbers = new int[] { 1, 4, 5, 6 };

            foreach(int number in numbers)      // number = Variable in der, der durchlaufene Wert gespeichert wird => nicht manipulierbar (read only)        // numbers = Array
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();


            // Foreach Beispiel

            string[] names = new string[]
            {
                "Alina",
                "Horst",
                "Franz",
                "Sandra",
                "Hendrik"
            };

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }











            Console.ReadKey();

        }
    }
}
