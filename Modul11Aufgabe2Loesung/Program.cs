using System;

namespace Modul11Aufgabe2Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Hans Nötig";
            Console.WriteLine(person.Name);
            Console.ReadKey();
        }
    }
}
