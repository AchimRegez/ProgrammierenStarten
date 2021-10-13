using System;

namespace Modul10Aufgabe3Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dreieck: {0}", AreaCalculator.GetTriangleArea(5, 12));
            Console.WriteLine("Rechteck: {0}", AreaCalculator.GetRectangleArea(10, 4));
            Console.WriteLine("Quadrat: {0}", AreaCalculator.GetSquareArea(4));
            Console.WriteLine("Kreis: {0}", AreaCalculator.GetCircleArea(10));
            Console.ReadKey();
        }
    }

    static class AreaCalculator
    {
        public static double GetRectangleArea(double width, double height)
        {
            return width * height;
        }

        public static double GetSquareArea(double lenght)
        {
            return lenght * lenght;
        }

        public static double GetCircleArea(double radius)
        {
            return radius * radius * Math.PI;
        }

        public static double GetTriangleArea(double triangleBase, double heigt)
        {
            return ((triangleBase * heigt) / 2);
        }
    }
}
