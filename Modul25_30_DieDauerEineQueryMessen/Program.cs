using System;
using System.Linq;
using System.Diagnostics;

namespace Modul25_30_DieDauerEineQueryMessen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erstelle Stoppuhr und das Array
            Stopwatch sw = new Stopwatch();
            var numbers = Enumerable.Range(1, 100000000);

            //Zwei Beispiel-Queries
            var query = from num in numbers
                        where num % 12345678 == 0
                        select num;

            var query2 = from num in numbers.AsParallel()
                         where num % 12345678 == 0
                         select num;

            Console.WriteLine("Loading...");

            //Query ohne Parallelisierung
            sw.Start();

            foreach (int num in query)
                Console.WriteLine(num);

            sw.Stop();
            Console.WriteLine("Without PLINQ: " + sw.ElapsedMilliseconds);

            sw.Reset();


            //Query mit Parallelisierung
            sw.Start();
            foreach (int num in query2)
                Console.WriteLine(num);

            sw.Stop();
            Console.WriteLine("With PLINQ: " + sw.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
