using System;
using System.IO;

namespace Modul22StreamReader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Thanatos\Desktop\Testordner\Test.txt");

            //Console.WriteLine("Ausgabe mit sr.ReadToEnd()");
            //Console.WriteLine(sr.ReadToEnd());

            Console.WriteLine("Ausgabe mit sr.ReadLine()");
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            Console.WriteLine(sr.ReadLine());
            sr.Close();

            Console.ReadKey();

        }
    }
}
