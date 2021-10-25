using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12Aufgab1
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
    }
}
