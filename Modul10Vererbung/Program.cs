using System;

namespace Modul10Vererbung
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund bello = new Hund();
            bello.Name = "Bello";
            bello.Age = 12;
            bello.Breed = "Beagle";
            bello.Eat();
            bello.Bark();

            Wachhund killer = new Wachhund();
            killer.Name = "Killer";
            killer.Age = 3;
            killer.Breed = "Dobermann";
            killer.Guardhouse();
            killer.Eat();
            killer.Bark();
        }

        class Hund
        {
            //Eigenschaften
            public string Name { get; set; }
            public int Age { get; set; }
            public string Breed { get; set; }

            //Methoden
            public void Eat()
            {
                Console.WriteLine("Der Hund {0} frisst!", Name);
            }

            public void Bark()
            {
                Console.WriteLine("Der Hund {0} bellt! Wuff Wuff!", Name);
            }
        }

        class Wachhund : Hund
        {
            //Methoden
            public void Guardhouse()
            {
                Console.WriteLine("Der Hund {0} bewacht das Haus! Knurr Knurr", Name);
            }
        }
    }

}
