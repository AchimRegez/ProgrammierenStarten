using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Aufgabe1
{
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

        public void Barc()
        {
            Console.WriteLine("Der Hund {0} bellt!!! Wuff Wuff!!!", Name);
        }

        public void Eat()
        {
            Console.WriteLine("Der Hund {0} frisst!!!", Name);
        }
    }
}
