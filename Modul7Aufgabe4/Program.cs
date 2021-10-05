using System;
using System.Drawing;

namespace Modul7Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe die Breite ein: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Gebe die Höhe ein: ");
            int height = Convert.ToInt32(Console.ReadLine());

            for (int i = width)
            {
                g.DrawRectangle(10, 5);
            }
        }
    }
}
