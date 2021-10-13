using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Aufgabe4
{
    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }
        public void Teach()
        {
            Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse...", LastName);
        }
    }
}
