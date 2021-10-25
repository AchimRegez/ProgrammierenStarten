﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul12Aufgab1
{
    class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override void GetArea()
        {
            float area = Radius * Radius * ((float)Math.PI);
            Console.WriteLine("Fläche des Kreises: {0}", area);
        }
    }
}
