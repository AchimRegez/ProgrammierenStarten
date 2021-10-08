using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Aufgabe4
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Alter: {0}", Age);
        }
    }
}
