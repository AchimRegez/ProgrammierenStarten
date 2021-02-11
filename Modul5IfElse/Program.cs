using System;

namespace Modul5IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int alter = 9;
            bool inBegleitung = true; // In Begleitung einer Erwachsenen Person?

            if (alter >= 12)
            {
                Console.WriteLine("Du darfst das Spiel kaufen!");
            }
            else if(inBegleitung == true)
            {
                Console.WriteLine("Du bist zu jung aber kriegst das Spiel trotzdem!");
            }
            else
            {
                Console.WriteLine("Du bist zu jung!");
            }

            Console.ReadKey();





            // Meine Loesung
            byte age = 0;
            Console.WriteLine("Bitte gebe dein Alter ein: ");
            age = Convert.ToByte(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Du bist {0} Jahre alt und somit Volljährig, du hasst Zugriff auf die Inhalte! ;)", age);
            }
            else
            {
                Console.WriteLine("Du bist leider noch nicht Volljährig!");
            }    
        }
    }
}
