using System;

namespace Modul7WhileUndDoWhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////////////////////////////////////////////////////
            // While-Schleife                                                                   //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("While-Schleife");
            int number = 0;

            while(number < 5) // solange "number" kleiner als 5 ist
            {                 // führe folgenden Codeblock aus
                number += 1; // erhöhe "number" um 1
                Console.WriteLine(number); // und gebe "number" aus
            }


            // While Schleife ist kopfgesteuert
            // Wird so oft wiederholt bis die Bedingung nicht mehr zutrifft






            //////////////////////////////////////////////////////////////////////////////////////
            // Do-While-Schleife                                                                //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Do-While-Schleife");
            int number1 = 0;

            do // betrete den Codeblock der Schleife
            {  
                number1 += 1; // erhöhe "number" um 1
                Console.WriteLine(number1); // und gebe "number" aus
            }
            while (number1 < 5);


            // Do-While-Schleife ist Fussgesteuert
            // Der Codeblock wird mindestens einmal ausgeführt







            //////////////////////////////////////////////////////////////////////////////////////
            // While-Schleife Beispiel                                                          //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();
            Console.WriteLine("Praxis: While-Schleife");
            Console.WriteLine("Gebe Integer 1 (tief) an: ");
            int numberExample1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe Integer 2 (hoch) an: ");
            int numberExample2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Ausgabe: ");

            while (numberExample1 <= numberExample2)
            {
                Console.WriteLine(numberExample1);
                numberExample1 += 1;
            }







            //////////////////////////////////////////////////////////////////////////////////////
            // Do-While-Schleife Beispiel                                                       //
            //////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine();

            string password = "HelloWorld";
            string input = "";

            do
            {
                Console.WriteLine("Gebe das Passwort ein: ");
                input = Console.ReadLine();
            } while (password != input);

            Console.WriteLine("Du hast das richtige Passwort eingegben!");





            Console.ReadKey();


        }
    }
}
