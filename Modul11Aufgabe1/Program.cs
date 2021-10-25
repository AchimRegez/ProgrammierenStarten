using System;

namespace Modul11Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog bello = new Dog();
            bello.Gender = "Männlich";
            bello.Age = 3;

            Cat lulu = new Cat();
            lulu.Gender = "Weiblich";
            lulu.Age = 5;

            Mouse feivel = new Mouse();
            feivel.Gender = "Männlich";
            feivel.Age = 2;

            IPet[] pets = new IPet[3];
            pets[0] = bello;
            pets[1] = lulu;
            pets[2] = feivel;

            foreach(IPet pet in pets)
            {
                Console.WriteLine("Geschlecht: {0}", pet.Gender);
                Console.WriteLine("Alter: {0}", pet.Age);
                pet.Drink();
                pet.Eat();
                Console.WriteLine();
            }

            Console.ReadKey();


        }
    }
}
