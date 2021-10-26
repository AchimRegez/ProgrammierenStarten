using System;

namespace Modul13MethodenUeberladen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person hans = new Person("Hans", "Nötig");
            Person sabrina = new Person("Sabrina", "Lutscher");
            hans.Greet();
            sabrina.Greet(hans); // Überladen von Methode
            Console.ReadKey();
        }
    }
}
