using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul13MethodenUeberladen
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Greet()
        {
            Console.WriteLine("{0} {1} says: Hello!!!", FirstName, LastName);
        }

        public void Greet(Person personToGreet)
        {
            Console.WriteLine("{0} {1} says: Hello {2} {3}", FirstName, LastName, personToGreet.FirstName, personToGreet.LastName);
        }
    }
}
