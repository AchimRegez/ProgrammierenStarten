using System;

namespace Modul7Aufgabe7Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Gebe ein Wort ein: ");
            string text = Console.ReadLine();

            if (IsPalindrome(text))
            {
                Console.WriteLine(text + " ist ein Palindrom");
            }
            else
            {
                Console.WriteLine(text + " ist kein Palindrom");
            }

            Console.ReadKey();
        }

        static bool IsPalindrome(string text)
        {
            string reversed = "";

            for (int i = text.Length-1; i >= 0; i--)
            {
                reversed += text[i];
            }

            return reversed.ToLower() == text.ToLower();
        }
    }
}
