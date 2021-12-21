using System;
using System.Collections.Generic;
using System.Linq;

/*
 *Die Where-Methode
 *Filter für Abfragen definieren
 *
 *
 *Die Where()-Methode
 *->Mit der Where-Methode kann man Objekte aus einer Datenquelle herausfiltern, die eine bestimmte Bedingung erfüllen
 *->Die Where-Methode erwartet als Parameter eine Methode die einen Boolean zurückgibt
 *-->In der als Parameter übergebenen Methode muss das Objekt auf die Bedingugn geprüft werden
 *
 */

namespace Modul25_06_WhereMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student("Sabrina", "Wilson", Courses.Maths, 21));
            studentList.Add(new Student("John", "Wilson", Courses.Engineering, 23));
            studentList.Add(new Student("Hendrik", "Pruin", Courses.Engineering, 27));
            studentList.Add(new Student("Alina", "Brown", Courses.Biology, 22));
            studentList.Add(new Student("Florian", "Johnson", Courses.Art, 24));
            studentList.Add(new Student("Angelika", "Smith", Courses.Art, 21));


            //Query Syntax
            var engineeringStudents = from student in studentList
                                      where student.Course == Courses.Engineering && student.Age < 25
                                      select student;

            Console.WriteLine("Query-Syntax");
            foreach (Student student in engineeringStudents)
            {
                Console.WriteLine(student.ToString());
            }


            //Methoden Syntax
            var engineeringStudentsMethod = studentList.Where((student) => student.Course == Courses.Engineering && student.Age < 25);

            Console.WriteLine();
            Console.WriteLine("Methoden-Syntax");
            foreach (Student student in engineeringStudentsMethod)
            {
                Console.WriteLine(student.ToString());
            }

            Console.ReadKey();
        }
    }


    public enum Courses
    {
        Art,
        Biology,
        Maths,
        Engineering
    }


    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Courses Course { get; set; }
        public int Age { get; set; }


        public Student(string firstName, string lastName, Courses cours, int age)
        {
            FirstName = firstName; 
            LastName = lastName;
            Course = cours;
            Age = age;
        }


        public override string ToString()
        {
            return $"{FirstName} {LastName} ({Age} - {Course})";
        }
    }
}
