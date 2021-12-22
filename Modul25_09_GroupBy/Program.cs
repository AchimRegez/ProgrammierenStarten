using System;
using System.Linq;
using System.Collections.Generic;

/*
 *Die GroupBy-Methode
 *Ergebnisse in Gruppen aufteilen
 *
 *
 *->Mit der GroupBy-Methode kann man die Ergebnisse einer Abfrage in Gruppen unterteilen
 *-->Die Einzelnen Gruppen kann man dann durchlaufen
 *
 *
 *->Dazu gibt man der GroupBy-Methode einen Key als Parameter mit, nach welchen die Gruppen erstellt werden
 *-->Alle Objekte mit demselben Key landen in derselben Gruppe
 *
 */

namespace Modul25_09_GroupBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("Daniela", "Johnson", 32, "Programmer"));
            personList.Add(new Person("Benjamin", "Bauer", 23, "Programmer"));
            personList.Add(new Person("Benjamin", "Adams", 40, "Artist"));
            personList.Add(new Person("Alex", "Effe", 26, "Artist"));
            personList.Add(new Person("Janek", "Bruin", 22, "Cook"));
            personList.Add(new Person("Carlos", "Sanchez", 40, "Cook"));
            personList.Add(new Person("Xaver", "Hill", 40, "Artist"));


            //Query-Syntax
            var personGroups = from person in personList
                               group person by person.Job;
                              

            Console.WriteLine("Query-Syntax");
            Console.WriteLine();
            foreach (var group in personGroups)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-------------------------------------------------------------");

                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }

                Console.WriteLine();

            }


            //Methoden-Syntax
            var personGroupsMethod = personList.GroupBy((person) => person.Job);

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax");
            Console.WriteLine();
            foreach (var group in personGroups)
            {
                Console.WriteLine(group.Key);
                Console.WriteLine("-------------------------------------------------------------");

                foreach (Person person in group)
                {
                    Console.WriteLine(person.ToString());
                }

                Console.WriteLine();

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
