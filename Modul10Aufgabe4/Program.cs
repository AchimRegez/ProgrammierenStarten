using System;

namespace Modul10Aufgabe4
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating array of objects
            Person[] peopleInClassroom = new Person[5];
            //initlising objects by detauls/inbuilt constructors
            peopleInClassroom[0] = new Teacher("John", "Smith", 32);
            peopleInClassroom[1] = new Student("Sabrina", "Müller", 18);
            peopleInClassroom[2] = new Student("Anna", "Matt", 17);
            peopleInClassroom[3] = new Student("Peter", "Fredl", 18);
            peopleInClassroom[4] = new Student("Matthias", "Maier", 19);

            foreach(Person p in peopleInClassroom)
            {
                if (p is Teacher)
                {
                    p.PrintInformation();                    
                    Console.WriteLine();
                }
                else
                {
                    p.PrintInformation();   
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
