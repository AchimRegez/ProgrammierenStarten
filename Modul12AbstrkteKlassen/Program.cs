using System;

namespace Modul12AbstrkteKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            MechatronicsEngineer hans = new MechatronicsEngineer("Hans", 6000);
            hans.PrintInformation();
            hans.DoWork();

            Console.WriteLine();

            Electrician reto = new Electrician("Reto", 6500);
            reto.PrintInformation();
            reto.DoWork();

            Workers[] workers = new Workers[2];
            workers[0] = hans;
            workers[1] = reto;

            Console.ReadKey();
        }
    }
}
