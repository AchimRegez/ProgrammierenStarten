using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul10Aufgabe4
{
    class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }
        public void ListenToTeacher()
        {
            Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu...", FirstName, LastName);
        }
    }
}
