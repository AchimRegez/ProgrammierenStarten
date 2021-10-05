using System;

namespace Modul7Aufgabe8Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe einen Text ein: ");
            string text = Console.ReadLine();
            string newText = "";

            foreach(char c in text)
            {
                if (char.IsLetter(c))
                {
                    newText += c;
                }
            }

            Console.WriteLine("Der neue Text: " + newText);
            Console.ReadKey();
        }
    }
}
