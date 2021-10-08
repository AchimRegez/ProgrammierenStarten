using System;

namespace Modul10SchluesselwoerterIsUndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.Name = "Hans Nötig";
            person1.Age = 33;

            Mechanic person2 = new Mechanic();
            person2.Name = "Ruedi Ruessel";
            person2.Age = 45;
            person2.RepairCar();

            //is: checkt ob person1 das selbe ist wie Mechanic/Person -> ergibt immer true oder false!!!
            Console.WriteLine();
            Console.WriteLine("Schlüsselwort is");
            Console.WriteLine(person1 is Mechanic);
            Console.WriteLine(person2 is Mechanic);
            Console.WriteLine(person1 is Person);
            Console.WriteLine(person2 is Person);
            Console.WriteLine("Hallo Welt!" is string);
            Console.WriteLine("Hallo Welt!" is int);
            Console.WriteLine(12 is string);
            Console.WriteLine(12 is int);
            Console.WriteLine(person2 is Object); //true, weil Object ist die Basisklasse jedes Objekt in C# -> Abgeleitet auf höchster Ebene!!!

            //as: wie is Schlüsselwort nur das konvertierung von Objekt in anderen Datentyp vorkommt
            Console.WriteLine();
            Console.WriteLine("Schlüsselwort as");

            object[] objects = new object[4];

            objects[0] = "Hallo Welt!";
            objects[1] = "Hello World!";
            objects[2] = 12;
            objects[3] = false;

            foreach(object o in objects)
            {
                string text = o as string; //konvertierung des Objekts in anderen Datentyp und wird zurück gegeben!

                if(text != null)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine("Das Objekt war kein String!!!");
                }
            }


            Console.ReadKey();
        }

        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Mechanic : Person
        {
            public void RepairCar()
            {
                Console.WriteLine("Der Mechniker {0} repariert das Auto!", Name);
            }
        }
    }
}
