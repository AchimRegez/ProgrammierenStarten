using System;

namespace Modul02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Video Variablen
            // Deklaration
            string username;

            // Initialisierung
            username = "Felix";


            // Deklaration und Initialisierung
            string username2 = "Franz";


            Console.WriteLine("User: " + username + " User2: " + username2);
            username = "Thomas";
            Console.WriteLine("User: " + username + " User2: " + username2);
            Console.WriteLine("Taste drücken für Video Datentypen");
            Console.ReadKey();



            // Video Datentypen
            // Ganze Zahlen
            byte byte1 = 255;
            short short1 = 10000;
            int integer1 = 12000;
            long long1 = 10000000;

            Console.WriteLine(byte1);
            Console.WriteLine(short1);
            Console.WriteLine(integer1);
            Console.WriteLine(long1);


            // Fliesskomazahlen
            float float1 = 12345.345F;      // Allrounder F-Suffix
            double double1 = 1234.743;      // Geld
            decimal decimal1 = 2345.345M;   // Wissenschaftliche Arbeiten und Zwecke

            Console.WriteLine(double1);
            Console.WriteLine(decimal1);
            Console.WriteLine("Taste drücken für Video andere Datenypen");
            Console.ReadKey();



            // Andere Datentypen
            string string1 = "Hallo du Sau!!!!! ;)";    // Texte
            char character1 = 'A';                      // Einfache Zeichen
            bool boolean1 = true;
            bool boolean2 = false;

            Console.WriteLine(string1);
            Console.WriteLine(character1);
            Console.WriteLine(boolean1);
            Console.WriteLine(boolean2);
            Console.ReadKey();




            // Video eingaben in der Konsole
            // Variablen anlegen
            int age;
            string name;

            // Namen eingeben
            Console.WriteLine("Bitte gib deinen Namen ein: ");
            name = Console.ReadLine();

            // Alter eingeben
            Console.WriteLine("Bitte gib dein Alter ein: ");
            age = Convert.ToInt32(Console.ReadLine());


            // Hallo "Name"! Du bist "Alter" Jahre alt
            Console.WriteLine("Hallo " + name + "! Du bist " + age + " Jahre alt.");
            Console.ReadKey();





            // Übungsaufgaben
            byte agePerson = 37;
            double money = 134.45;
            byte weekDay = 7;
            string namePerson = "Hans Muster";
            bool marriaged = false;
        }
    }
}
