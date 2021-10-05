using System;

namespace Modul7Aufgabe4Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawRectangle(3, 3);
            Console.ReadKey();
        }

        static void DrawRectangle(int width, int height)
        {
            for(int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }            
        }
    }
}
