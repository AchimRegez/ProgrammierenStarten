using System;
using System.Linq;

namespace Modul25_31_EinführungInParallel_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nubmers = Enumerable.Range(1, 100).ToArray();

            var allEvenNumbers = from num in nubmers
                                 where num % 2 == 0
                                 select num;

            foreach (int number in allEvenNumbers)
                Console.WriteLine(number);



            int[] nubmersParallel = Enumerable.Range(1, 100).ToArray();

            var allEvenNumbersParallel = from num in nubmers.AsParallel().AsOrdered()
                                 where num % 2 == 0
                                 select num;

            foreach (int number in allEvenNumbersParallel)
                Console.WriteLine(number);

            Console.ReadKey();
        }
    }
}
