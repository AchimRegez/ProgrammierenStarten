using System;
using System.IO;

namespace Modul22FileInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Thanatos\Desktop\Testordner\TestDatei.txt";
            FileInfo file = new FileInfo(path);

            file.Create();

            Console.WriteLine(file.FullName);
            Console.WriteLine(file.DirectoryName);
            Console.WriteLine(file.Name);
            Console.WriteLine(file.Attributes);
            Console.WriteLine(file.CreationTime);
            Console.WriteLine(file.Extension);

            //file.Delete();
            Console.WriteLine(file.Exists);

            Console.ReadKey();
        }
    }
}
