using System;

namespace Modul5Aufgabe1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Bitte gib dein Alter ein: ");
            age = Convert.ToInt32(Console.ReadLine());


            if (age < 18)
            {
                Console.WriteLine("Dein Alter ist: {0}. Du bist noch nicht Volljährig!", age);
            }
            else
            {
                Console.WriteLine("Dein Alter ist: {0}. Du bist Volljährig!", age);
            }

            Console.ReadKey();
        }
    }
}
