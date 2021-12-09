using System;

namespace Modul21RandomNextBytesMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle einen Byte-Array
            byte[] numberSequence = new byte[20];

            //Erstelle Random-Objekt
            Random rnd = new Random();

            //Fülle den Array mit zufälligen Werten
            rnd.NextBytes(numberSequence);

            //Gebe jede Zahl aus
            foreach(byte number in numberSequence)
            {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
