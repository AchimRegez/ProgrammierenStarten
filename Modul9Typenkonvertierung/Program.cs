using System;

namespace Modul09Typenkonvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //Impliziete Konvertierung (Automatisch)
            float float1 = 123.12F;
            double double1 = float1;

            Console.WriteLine(float1);
            Console.WriteLine(double1);



            //Explizite Konvertierung (Manuell)
            double double2 = 123.321321;
            float float2 = (float)double2;

            Console.WriteLine(float2);
            Console.WriteLine(double2);



            //Hilfsklassen zum Konvertieren
            float2 = Convert.ToSingle(double2);
        }
    }
}
