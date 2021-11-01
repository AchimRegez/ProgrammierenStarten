using System;

namespace Modul17MulticastDelegates
{
    class Program
    {
        public delegate void AusgabeDelegate(string str);
        static void Main(string[] args)
        {
            AusgabeDelegate ausgabe = new AusgabeDelegate(SayHello);
            ausgabe += SayGoodbye;

            ausgabe("Peter");

            Console.WriteLine();
        }

        static void SayHello(string name)
        {
            Console.WriteLine("{0} sagt hallo!", name);
        }

        static void SayGoodbye(string name)
        {
            Console.WriteLine("{0} verabschiedet sich!", name);
        }
    }
}
