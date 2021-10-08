using System;

namespace Modul10VererbteKonstruktoren
{
    class Program
    {
        static void Main(string[] args)
        {
            ErbendeKlasse objectTest = new ErbendeKlasse("Hans Nötig", 69);
            Console.ReadKey();
        }

        class Basisklasse
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public Basisklasse(string name, int age)
            {
                Name = name;
                Age = age;
                Console.WriteLine("Der Basis Konstruktor wird ausgeführt....");
            }
        }

        class ErbendeKlasse : Basisklasse
        {
            public ErbendeKlasse(string name, int age) : base(name, age)
            {
                Console.WriteLine("Der ErbendeKlasse Konstruktor wird ausgeführt...");
            }
        }
    }
}
