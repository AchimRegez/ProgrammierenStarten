using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul11Aufgabe1
{
    class Mouse : IPet
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        public void Drink()
        {
            Console.WriteLine("Die Maus trinkt...");
        }

        public void Eat()
        {
            Console.WriteLine("Die Maus frisst...");
        }
    }
}
