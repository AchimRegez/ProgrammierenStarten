using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1
{
    class Dog : IPet
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Drink()
        {
            Console.WriteLine("Der Hund trinkt...");
        }

        public void Eat()
        {
            Console.WriteLine("Der Hund frisst...");
        }
    }
}
