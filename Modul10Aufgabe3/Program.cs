using System;

namespace Modul10Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dreieck: " + AreaCalculator.GetTriangleArea(5, 12));
            Console.WriteLine("Rechteck: " + AreaCalculator.GetRectangleArea(10, 4));
            Console.WriteLine("Quadrat: " + AreaCalculator.GetSquareArea(4));
            Console.WriteLine("Kreis: " + AreaCalculator.GetCircleArea(10));
            Console.ReadKey();
        }
    }
}
