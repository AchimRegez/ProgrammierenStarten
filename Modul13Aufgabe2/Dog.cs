
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13Aufgabe2
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }

        public Dog(string name, int age, string owner)
        {
            Name = name;
            Age = age;
            Owner = owner;
        }

        public Dog(string name, int age)
        {
            Name = name;
            Age = age;            
        }
    }
}
