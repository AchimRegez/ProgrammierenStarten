using System;

//Schreibe eine Methode, die deinen Namen als Parameter annimmt und dich über eine Konsolenausgabe
//mit diesem Namen begrüßt

namespace Modul04MethodenAufgabe01
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";

            Console.WriteLine("Bitte gebe deinen Namen ein: ");
            name = Console.ReadLine();

            Output(name);

        }


        static void Output(string output)
        {
            Console.WriteLine("Hallo {0}", output);
        }
    }
}
