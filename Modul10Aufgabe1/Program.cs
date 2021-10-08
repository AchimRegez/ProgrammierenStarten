using System;

namespace Modul10Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bello = new Dog("Bello", 12, "Schäferhund", "Rüde");
            bello.Barc();
            bello.Eat();
            Console.WriteLine("Der Hund {0} ist {1} Jahre alt. Rasse: {2}, Geschlecht: {3}", bello.Name, bello.Age, bello.Breed, bello.Gender);

            Console.ReadKey();
        }
    }
}
