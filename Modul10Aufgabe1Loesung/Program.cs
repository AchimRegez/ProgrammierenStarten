using System;

namespace Modul10Aufgabe1Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bello = new Dog("Bello", 12, "Schäferhund", "Rüde");

            Console.WriteLine(bello.Name);
            Console.WriteLine(bello.Age);
            Console.WriteLine(bello.Breed);
            Console.WriteLine(bello.Gender);

            bello.Bark();
            bello.Eat();

            Console.ReadKey();
        }
    }

    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string Gender { get; set; }

        public Dog(string name, int age, string breed, string gender)
        {
            Name = name;
            Age = age;
            Breed = breed;
            Gender = gender;
        }

        public void Bark()
        {
            Console.WriteLine("{0} bellt!!!", Name);
        }

        public void Eat()
        {
            Console.WriteLine("{0} frisst!!!", Name);
        }

    }
}
