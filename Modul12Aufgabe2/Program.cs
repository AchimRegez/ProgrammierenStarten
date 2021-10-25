using System;


/* 
Überschreibe die „ToString()“-Methode der „Circle“ und „Rectangle“ Klassen und gebe dabei für die Klasse „Rectangle“ den Text:

„Rechteck mit einer Höhe von {Höhe} und Breite von {Breite}.“

…und für die Klasse „Circle“ den Text:

„Kreis mit einem Radius von {Radius}.“

…aus.

Rufe die „ToString()“-Methode anschließend auf jeweils einer Instanz der beiden Klassen auf.
*/





namespace Modul12Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(12.2f, 23.6f);
            rectangle1.GetArea();
            Console.WriteLine(rectangle1.ToString()); 

            Console.WriteLine();

            Circle circle1 = new Circle(56f);
            circle1.GetArea();
            Console.WriteLine(circle1.ToString());

            Console.ReadKey();
        }
    }
}
