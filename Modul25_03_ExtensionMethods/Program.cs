using System;

/*Extension Methods
 *Erweiterungsmethoden für bestehende Klassen definieren
 * 
 * 
 * Was ist eine Extension Method?
 * ->Extension Methods (Erweiterungs Methoden) sind Methoden, mit welcher wir eine bereits existierende Klasse um beliebige Funktionalitäten erweitern können
 * -->Dazu brauchen wir keinen Zugriff auf den Code der Klasse
 * -->Extension Methods werden nicht in der zu erweiterbaren Klasse selbst definiert
 * 
 * ->Mit Extension Methods kann man Klassen um Methoden erweitern, ohne dass man die Klassen dabei verändern muss!
 * 
 * -> Extension Methods können eigene Klassen, .NET-Klassen und fremde Klassen erweitern, ohne dass der Code davon verändert oder neu kompiliert werden muss!
 */

namespace Modul25_03_ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1 = "2018";
            int number2 = number1.ToInt() + 2;

            Console.WriteLine(number2);
            Console.ReadKey();
        }
    }

    public static class StringExtensions
    {
        public static int ToInt(this String str)
        {
            return Convert.ToInt32(str);
        }
    }
}
