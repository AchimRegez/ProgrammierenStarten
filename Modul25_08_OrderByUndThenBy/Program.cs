using System;
using System.Collections.Generic;
using System.Linq;

/*
 *OrderBy und ThenBy
 *Die Ergebnisser einer Abfrage sortieren
 *
 *
 *Die OrderBy-Methode
 *->Mit der OrderBy-Methode können wir die Ergebnisse einer Abfrage nach einem Key sortieren
 *-->Der Key ist der Wert, nach dem wir sortieren wollen
 *
 *->Mit OrderBy kann man die Ergebnisse aufsteigend und absteigend sortieren (standardmässig wird aufsteigend sortiert)
 */

namespace Modul25_08_OrderByUndThenBy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personList = new List<Person>();
            personList.Add(new Person("Daniela", "Johnson", 32));
            personList.Add(new Person("Benjamin", "Bauer", 23));
            personList.Add(new Person("Benjamin", "Adams", 40));
            personList.Add(new Person("Alex", "Effe", 26));
            personList.Add(new Person("Janek", "Bruin", 22));
            personList.Add(new Person("Carlos", "Sanchez", 40));
            personList.Add(new Person("Xaver", "Hill", 40));


            //Query-Syntax
            var personQuery = from person in personList
                              orderby person.FirstName, person.LastName //descending //ascending
                              select person;

            Console.WriteLine("Query-Syntax");
            foreach (Person person in personQuery)
            {
                Console.WriteLine(person.ToString());
            }


            //Methoden-Syntax
            //Aufsteigend Sortiert
            var personQueryMethod = personList.OrderBy((person) => person.FirstName).ThenBy((person) => person.LastName);

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax - Aufsteigend");
            foreach (Person person in personQueryMethod)
            {
                Console.WriteLine(person.ToString());
            }


            //Methoden-Syntax
            //Absteigend Sortiert
            var personQueryMethodDesc = personList.OrderByDescending((person) => person.FirstName).ThenByDescending((person) => person.LastName);

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax - Absteigend");
            foreach (Person person in personQueryMethodDesc)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age  { get; set; }


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age})";
        }
    }
}
