using System;

namespace Modul10Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(6, "Bello", "Hans Nötig");
            Console.WriteLine("Der Hund heisst {0} und ist {1} Jahre alt. Der Halter des Hundes ist {2}.", dog1.Name, dog1.Age, dog1.Holder);

            Dog dog2 = new Dog(2, "Killer", "Max Mätzchen");
            Console.WriteLine("Der Hund heisst {0} und ist {1} Jahre alt. Der Halter des Hundes ist {2}.", dog2.Name, dog2.Age, dog2.Holder);

            Console.ReadKey();
        }

        class Dog
        {
            //Eigenschaften
            public int Age { get; set; }
            public string Name { get; set; }
            public string Holder { get; set; }

            //this.age initialisert dieses age
            //private int age; 

            //Konstruktor
            public Dog(int age, string name, string holder)
            {
                Age = age;
                Name = name;
                Holder = holder;

                //this.age = age;
            }
        }
    }
}
