﻿using System;

namespace Modul7Aufgabe6Loesung
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hallo Welt";

            for(int i = 0; i < text.Length; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(text);
                }
                else
                {
                    Console.WriteLine(text[i]);
                }
            }

            Console.ReadKey();


        }
    }
}
 