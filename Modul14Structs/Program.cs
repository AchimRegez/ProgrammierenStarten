using System;
using System.Diagnostics;

namespace Modul14Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Struktur ist ein Wertetyp -> wird im Stack-Speicher gespeichert -> schnellere Perfomance weil aufgeräumter
            // Erstellen einer Variable des Typs Point
            Point point1;
            // Variable mit Werte füllen
            point1.x = 10;
            point1.y = 5;

            point1.MovePosition(2, 2);

            // Konstruktor aufruf
            Point point2 = new Point(66, 69);
            Point point3 = point2;

            point3.x = 12;
            point3.y = 12;
            Console.WriteLine("{0}, {1}", point1.x, point1.y);
            Console.WriteLine("{0}, {1}", point2.x, point2.y);
            Console.WriteLine("{0}, {1}", point3.x, point3.y);
            Console.ReadKey();
        }
    }

    struct Point
    {
        public int x;
        public int y;

        // Konstruktor
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void MovePosition(int x_movement, int y_movement)
        {
            x += x_movement;
            y += y_movement;
        }
    }
}
