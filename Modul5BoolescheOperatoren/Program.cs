using System;

namespace Modul5BoolescheOperatoren
{
    class Program
    {
        /*
         * Vergleichs Operatoren
         * Operator     Zweck               Beispiel
         * <            kleiner als         (2 < 4)
         * >            grösser als         (3 > 1)
         * <=           kleiner-gleich      (3 <= 3)
         * >=           grösser-gleich      (2 >= 1)
         * ==           gleich              (2 == 2)
         * !=           ungleich            (4 != 8)
         * 
         * Logische Operatoren
         * Operator     Zweck               Beispiel
         * &&           UND / AND           (true && false)
         * ||           ODER / OR           (true || false)
         * !            NICHT / NOT         !(true && false)
         */

        static void Main(string[] args)
        {
            bool mobil = true;
            bool qualifiziert = true;
            bool testBestanden = false;
            bool schüchtern = false;



            if (mobil && (qualifiziert || testBestanden) && !schüchtern)
            {
                Console.WriteLine("Du wurdest eingestellt!");
            }
            else
            {
                Console.WriteLine("Du wurdest abgelehnt!");
            }

            Console.ReadKey();
        }
    }
}
