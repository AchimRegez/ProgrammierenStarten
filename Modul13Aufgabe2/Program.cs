using System;

/*
Erstelle eine Klasse „Dog“ welche einen Hund darstellt. Diese Klasse enthält 3 Eigenschaften:
string Name → Der Name des Hundes
int Age → Das Alter des Hundes
string Owner → Der Besitzer des Hundes
Diese Eigenschaften sollen über den Konstruktor initialisiert werden.
Erstelle 2 Überladungen für den Konstruktor. Einmal eine Überladung, bei welcher man nur den Namen und das Alter des Hundes als Parameter übergibt und eine Überladung, bei welcher man den Namen, das Alter und den Namen des Besitzers übergibt.
Sollte man keinen Besitzer übergeben, dann soll in die Eigenschaft „Owner“ der Text
„No owner“ geschrieben werden.
*/

namespace Modul13Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bello = new Dog("Bello", 3);
            Dog rico = new Dog("Rico", 6, "Hans Nötig");

            Console.WriteLine("{0} ist {1} Jahre alt!", bello.Name, bello.Age);
            Console.WriteLine("{0} ist {1} Jahre alt und sein Besitzer ist {2}", rico.Name, rico.Age, rico.Owner);
        }
    }
}
