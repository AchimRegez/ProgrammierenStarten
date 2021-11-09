using System;

namespace Modul19TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int age = 0;
                try
                {
                    //Gebe dein ALter ein
                    Console.Write("Gebe dein Alter ein: ");
                    age = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Du musst eine gültige Zahl eingeben!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }                
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Gebe ein normales Alter ein!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                if (age >= 18)
                {
                    Console.WriteLine("Du bist Volljährig!!!");
                }
                else
                {
                    Console.WriteLine("Du bist Minderjährig!!!");
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
