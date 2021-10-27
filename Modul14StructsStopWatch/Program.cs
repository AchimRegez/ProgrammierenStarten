using System;
using System.Diagnostics;


// Ändere struct zu class und stoppe die Zeit, danach ändere zurück und stoppe die Zeit


namespace Modul14StructsStopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Point[] points = new Point[10000000];

            sw.Start();
            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i, i);
            }

            for (int i = 0; i < points.Length; i++)
            {
                points[i].MovePosition(1, 1);
            }
            sw.Stop();

            Console.WriteLine("Fertig!");
            Console.WriteLine("Verstrichene Zeit: {0}", sw.ElapsedMilliseconds);

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
