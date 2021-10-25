using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12Aufgabe2
{
    class Rectangle : Shape
    {
        public float Height { get; set; }
        public float Width { get; set; }

        public Rectangle(float height, float width)
        {
            Height = height;
            Width = width;
        }

        public override void GetArea()
        {
            float area = Height * Width;
            Console.WriteLine("Fläche des Rechtecks: {0}", area);
        }

        public override string ToString()
        {
            return "Rechteck mit einer Höhe von " + Height + " und Breite von " + Width + ".";
        }
    }
}
