using System;

namespace Modul13Aufgabe2Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bello = new Dog("Bello", 3);
            Console.WriteLine("{0} ist {1} Jahre alt und sein Besitzer ist: {2}", bello.Name, bello.Age, bello.Owner);

            Dog rico = new Dog("Rico", 6, "Hans Nötig");
            Console.WriteLine("{0} ist {1} Jahre alt und sein Besitzer ist: {2}", rico.Name, rico.Age, rico.Owner);
        }
    }
}
