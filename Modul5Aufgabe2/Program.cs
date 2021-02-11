using System;

/* AUFGABE 2. GERADE ODER UNGERADE
Schreibe eine Methode die einen Integer-Wert als Parameter annimmt und einem über die
Konsolenausgabe mitteilt ob die Zahl gerade oder ungerade ist.
*/


namespace Modul5Aufgabe2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;


            Console.WriteLine("Bitte gib eine Ganzzahl ein: ");
            number = Convert.ToInt32(Console.ReadLine());


            //isEven(number);


            

            if (number % 2 == 0)
            {
                Console.WriteLine("Die eingegebene Zahl {0} ist gerade!", number);
            }
            else
            {
                Console.WriteLine("Die eingegebene Zahl {0} ist nicht gerade!", number);
            }



            if (isEven(number) == true)
            {
                Console.WriteLine("Die eingegebene Zahl {0} ist gerade!", number);
            }
            else
            {
                Console.WriteLine("Die eingegebene Zahl {0} ist nicht gerade!", number);
            }





            Console.ReadKey();
        }



        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
