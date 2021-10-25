using System;

/* 
Erstelle eine Abstrakte Klasse namens „Shape“ (Form) welche als Basisklasse für geometrische Formen dienen soll. Die „Shape“-Klasse soll eine Abstrakte Methode
„GetArea()“ vorgeben, welche den Flächeninhalt der Form zurückgibt.

Erstelle anschließend 2 Abgeleitete Klassen „Rectangle“ (Rechteck) und „Circle“ (Kreis), welche die Methode „GetArea()“ jeweils implementieren.

Rechteck Flächenberechnung: Fläche = Höhe * Breite

Kreis Flächenberechnung: Fläche = Radius * Radius * PI

Die Klasse „Rectangle“ benötigt die Eigenschaften „Width“ (Breite) und „Height“ (Höhe).

Die Klasse „Circle“ benötigt die Eigenschaft „Radius“.
Erstelle für die Klassen „Rectangle“ und „Circle“ jeweils einen Konstruktor zum initialisieren der Eigenschaften.
*/



namespace Modul12Aufgab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(12.2f, 23.6f);
            rectangle1.GetArea();

            Console.WriteLine();

            Circle circle1 = new Circle(56f);
            circle1.GetArea();

            Console.ReadKey();
        }
    }
}
