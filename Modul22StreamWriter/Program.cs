using System;
using System.IO;

namespace Modul22StreamWriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Thanatos\Desktop\Testordner\TestWriter.txt", true);

            sw.WriteLine("Salü Hans Nötig, geits guet?");

            sw.WriteLine("");
            sw.WriteLine("Salü Hans Nötig, geits guet?");

            sw.Close();
        }
    }
}
