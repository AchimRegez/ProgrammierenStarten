﻿using System;

namespace Modul12Aufgabe2Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(10, 20);
            Circle circle1 = new Circle(3);

            Console.WriteLine(rectangle1.GetArea());
            Console.WriteLine(circle1.GetArea());

            Console.WriteLine(rectangle1.ToString());
            Console.WriteLine(circle1.ToString());

            Console.ReadKey();
        }
    }
}
