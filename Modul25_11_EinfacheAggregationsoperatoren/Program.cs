using System;
using System.Linq;
using System.Collections.Generic;

/*
 *Einfache Aggregationsoperatoren
 *Mathematische Operationen an den Ergebnissen einer Query durchführen
 * 
 * 
 * ->Average() - Gibt den Durchschnittswert aller Ergebnisse der Query zurück
 * ->Min() - Gibt den kleinsten Wert der Ergebnisse zurück
 * ->Max() - Gibt den grössten Wert der Ergebnisse zurück
 * ->Sum() - Gibt die Summer aller Ergebnisse zurück
 * ->Count() - Gibt die Anzahl der Elemente unserer Query zurück
 */

namespace Modul25_11_EinfacheAggregationsoperatoren
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

            int[] numbers = { 10, 12, 20, 30, 40, 50 };



            var resultMax = numbers.Max();
            Console.WriteLine("Grösste Zahl in numbers Array:");
            Console.WriteLine(resultMax);
            Console.WriteLine();

            var resultMin = numbers.Min();
            Console.WriteLine("Kleinste Zahl in numbers Array:");
            Console.WriteLine(resultMin);
            Console.WriteLine();

            var resultAverage = personList.Average((person) => person.Age);
            Console.WriteLine("Durchschnittsalter in numbers Array:");
            Console.WriteLine(resultAverage);
            Console.WriteLine();

            var resultSum = personList.Sum((person) => person.Age);
            Console.WriteLine("Gesamtalter in numbers Array:");
            Console.WriteLine(resultSum);
            Console.WriteLine();

            var resultCount = personList.Count();
            Console.WriteLine("Objekte in numbers Array:");
            Console.WriteLine(resultCount);
            Console.WriteLine();

            var resultQuery1 = personList.Where((person) => person.Job == "Programmer").Count();
            Console.WriteLine("Programmierer in numbers Array:");
            Console.WriteLine(resultQuery1);
            Console.WriteLine();


            var queryMethodMax = personList.Max((person) => person.Age);
            var queryMethodMin = personList.Min((person) => person.Age);
           
            Console.WriteLine("Älteste Person in der Personen Liste:");
            Console.WriteLine(queryMethodMax);

            Console.WriteLine();
            Console.WriteLine("Jüngste Person in der Personen Liste:");
            Console.WriteLine(queryMethodMin);
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
