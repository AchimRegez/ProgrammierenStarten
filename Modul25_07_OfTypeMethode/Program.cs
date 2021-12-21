using System;
using System.Collections.Generic;
using System.Linq;

/*
 *Die OfType-Methode
 *Filter für Abfragen definieren
 *
 *->Mit der OfType-Methode kann man Objekte aus einer Datenquelle herausfiltern, die von einem bestimmten Datentyp sind
 *->Der OfType-Methode übergibt man einfach den herauszufilternden Datentyp
 */

namespace Modul25_07_OfTypeMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Dog("Coco"));
            animalList.Add(new Dog("Jil"));
            animalList.Add(new Dog("Idefix"));
            animalList.Add(new Lion());
            animalList.Add(new Lion());


            //Query Syntax
            var dogQuery = from animal in animalList.OfType<Dog>()
                           select animal;

            foreach (Dog dog in dogQuery)
            {
                dog.Eat();
                dog.Drink();
            }


            var lionQuery = from animal in animalList.OfType<Lion>()
                            select animal;

            foreach (Lion lion in lionQuery)
            {
                lion.Eat();
                lion.Drink();
            }


            //Methoden Syntax
            var dogQueryMethod = animalList.OfType<Dog>();

            foreach (Dog dog in dogQueryMethod)
            {
                dog.Eat();
                dog.Drink();
            }

            Console.ReadKey();
        }
    }

    public abstract class Animal
    {
        public abstract void Eat();
        public abstract void Drink();
    }

    public class Dog : Animal
    {
        public string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public override void Drink()
        {
            Console.WriteLine($"The dog {Name} is drinking...");
        }

        public override void Eat()
        {
            Console.WriteLine($"The dog {Name} is eating...");
        }
    }

    public class Lion : Animal
    {
        public override void Drink()
        {
            Console.WriteLine("The lion is drinking...");
        }

        public override void Eat()
        {
            Console.WriteLine("The lion is eating...");
        }
    }
}
