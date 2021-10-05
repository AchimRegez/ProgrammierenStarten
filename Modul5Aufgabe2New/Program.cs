using System;

namespace Modul5Aufgabe2New
{
    /*
     Schreibe ein Konsolenprogramm mit welchen man überprüfen kann, ob ein vom Benutzer eingegebenes Jahr ein Schaltjahr ist.
Ein Jahr ist immer dann ein Schaltjahr, wenn die Jahreszahl durch 4 teilbar ist.
Außer die Jahreszahl ist auch durch 100 teilbar.
Ausnahmen bilden Jahreszahlen, die durch 400 teilbar sind, diese sind auch Schaltjahre!
Tipp: Für die Lösung dieser Aufgabe wirst du den Modulo-Operator „%“ benötigen.
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte gib ein Jahr zur Überprüfung des Schaltjahres ein: ");
            double leapyear = Convert.ToDouble(Console.ReadLine());

            if (leapyear % 4 == 0 || leapyear % 100 == 0 || leapyear % 400 == 0)
            {
                Console.WriteLine("Das Jahr {0} ist ein Schaltjahr!", leapyear);
            }
            else
            {
                Console.WriteLine("Das Jahr {0} ist kein Schaltjahr!", leapyear);
            }

            Console.ReadKey();
        }
    }
}
