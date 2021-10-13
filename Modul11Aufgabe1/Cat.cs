using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1
{
    class Cat : IPet
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Drink()
        {
            Console.WriteLine("Die Katze trinkt...");
        }

        public void Eat()
        {
            Console.WriteLine("Die Katze frisst...");
        }
    }
}
