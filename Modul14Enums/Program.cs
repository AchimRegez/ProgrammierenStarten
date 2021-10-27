using System;

namespace Modul14Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Hans Nötig", Gender.Männlich);
            Console.WriteLine("Name: {0} Geschlecht: {1}", person1.Name, person1.Gender);
            Console.WriteLine((int)Gender.Weiblich);

            Console.ReadKey();
        }
    }

    enum Gender
    {
        Männlich = 0,   // Männlich,
        Weiblich = 1,   // Weiblich,
        Divers = 2      // Divers               --> Andere Schreibweise, funktioniert auch!
    }

    class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }

        public Person(string name, Gender gender)
        {
            Name = name;
            Gender = Gender;
        }
    }
}
