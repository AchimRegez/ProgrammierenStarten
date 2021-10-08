using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Aufgabe3
{
    static class AreaCalculator
    {
        public static double GetRectangleArea(double height, double width)
        {
            return (height * width);
        }

        public static double GetSquareArea(double sideLenght)
        {
            return (sideLenght * sideLenght);
        }

        public static double GetCircleArea(double radius)
        {
            return (radius * radius * 3.14159265359);
        }

        public static double GetTriangleArea(double basicSidesLength, double height)
        {
            return ((basicSidesLength * height)/2);
        }
    }
}
