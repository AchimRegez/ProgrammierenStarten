using System;

namespace Modul10Aufgabe4Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleInClassroom =
            {
                new Teacher("John", "Smith", 32),
                new Student("Sabrina", "Müller", 18),
                new Student("Hans", "Nötig", 17),
                new Student("Gina", "Blaser", 18),
                new Student("Anna", "Blasius", 18)
            };

            foreach(Person p in peopleInClassroom)
            {
                p.PrintInformation();

                if (p is Teacher)
                {
                    (p as Teacher).Teach();
                }
                else if (p is Student)
                {
                    (p as Student).ListenToTeacher();
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

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

    class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {

        }

        public void ListenToTeacher()
        {
            Console.WriteLine("Student {0} {1} hört dem Lehrer zu...", FirstName, LastName);
        }
    }
}
