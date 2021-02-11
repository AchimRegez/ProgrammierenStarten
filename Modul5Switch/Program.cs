using System;

namespace Modul5Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Theorie

            //int zahl = 3;

            //switch (zahl)
            //{
            //    case 1:
            //        // Coder der ausgeführt wird bei einem Wert von 1
            //    break;
            //    case 2:
            //        // Coder der ausgeführt wird bei einem Wert von 2
            //    break;
            //    case 3:
            //        // Coder der ausgeführt wird bei einem Wert von 3
            //    break;
            //    case 4:
            //        // Coder der ausgeführt wird bei einem Wert von 4
            //    break;


            int number = 4;

            switch (number)
            {
                case 1:
                    Console.WriteLine("Der Wert ist 1");
                break;

                case 2:
                    Console.WriteLine("Der Wert ist 2");
                break;

                case 3:
                    Console.WriteLine("Der Wert ist 3");
                break;
            }

            Console.ReadKey();            
        }
    }
}
