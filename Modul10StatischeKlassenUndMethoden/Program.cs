using System;

namespace Modul10StatischeKlassenUndMethoden
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = Mathematics.RectangleArea(12.12, 43.06);
            Console.WriteLine("Fläche des Rechtecks: {0} cm2.", area);
            
            //Klasse Math ist eine statische Klasse im .Net Framework
            double squareRoot = Math.Sqrt(50);
            Console.WriteLine("Quadratwurzel von 50 ist gleich {0}.", squareRoot);
            Console.ReadKey();
        }
    }

    static class Mathematics
    {
        public static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
