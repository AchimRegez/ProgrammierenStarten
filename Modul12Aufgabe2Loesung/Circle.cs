using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12Aufgabe2Loesung
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double GetArea()
        {
            return Radius * Radius * Math.PI;
        }

        public override string ToString()
        {
            return "Kreis mit einem Radius von " + Radius;
        }
    }
}
