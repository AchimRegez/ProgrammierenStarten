using System;
using System.Linq;
using System.Collections.Generic;

/*
 *Komplexere Abfragen mit Aufrufketten
 *Umfangreichere Queries definieren
 */

namespace Modul25_10_KomplexereAbfragenMitAufrufketten
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("Daniela", "Johnson", 32, "Programmer"));
            personList.Add(new Person("Benjamin", "Bauer", 23, "Programmer"));
            personList.Add(new Person("Benjamin", "Adams", 19, "Artist"));
            personList.Add(new Person("Alex", "Effe", 26, "Artist"));
            personList.Add(new Person("Janek", "Bruin", 22, "Cook"));
            personList.Add(new Person("Carlos", "Sanchez", 40, "Cook"));
            personList.Add(new Person("Xaver", "Hill", 40, "Artist"));


            //Query-Syntax
            var query = from person in personList
                        where person.Age < 30
                        orderby person.FirstName, person.LastName
                        select person;


            Console.WriteLine("Query-Syntax");
            Console.WriteLine();
            foreach (Person person in query)
            {
                Console.WriteLine(person.ToString());
            }


            //Methoden-Syntax
            var queryMethod = personList.Where((person) => person.Age < 30).OrderBy((person) => person.FirstName).ThenBy((person) => person.LastName);

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax");
            Console.WriteLine();
            foreach (Person person in queryMethod)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Job { get; set; }


        public Person(string firstName, string lastName, int age, string job)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Job = job;
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age}) - {Job}";
        }
    }
}
