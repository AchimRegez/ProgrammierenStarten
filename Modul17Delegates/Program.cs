using System;
using System.Collections.Generic;

/*
 * Was sind Delegaten/Delegates?
 * 
 * Ein Delegat ist ein Funktionszeiger
 * 
 * Er stellt einen Typen dar, in welchem man die Referenz zu einer Methode speichern kann
 * 
 * Delegaten ermöglichen also das Speichern von von Methodenreferenzen in einer Variable, über welche man die Methode dann jederzeit aufrufen kann!
 * 
 * 
 * Bei der Definition des Delegaten wird der Rückgabetyp und die Methoden-Signatur angegeben
 * 
 * Um eine Methode in einen Delegaten zu schreiben muss diese mit der Delegaten-Definition kompatibel sein
 * 
 * 
 * Wofür braucht man Delegaten?
 * 
 * Man verwendet Delegaten dann, wenn zur Laufzeit entschieden muss, welche Methode ausgeführt werden soll
 * 
 * Mit Delegaten kann man Methoden definieren, die andere Methoden als Parameter annehmen und intern aufrufen können
 * 
 * Man verwendet Delgaten vor allem bei der Nutzung von Events!
 */

namespace Modul17Delegates
{
    public delegate bool FilterDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>()
            {
                "Horst",
                "Alina",
                "Hendrik",
                "Kai",
                "Jan",
                "Peter"
            };

            List<string> newList = ReturnNewList(names, StartsWithH);

            foreach(string name in newList)
                Console.WriteLine(name);

            List<string> newList1 = ReturnNewList(names, LongerThanFive);

            foreach (string name in newList1)
                Console.WriteLine(name);

            Console.ReadKey();
        }

        static List<string> ReturnNewList(List<string> original, FilterDelegate filterMethod)
        {
            List<string> newList = new List<string>();

            foreach (string str in original)
            {
                if (filterMethod(str) == true)
                    newList.Add(str);
            }

            return newList;
        }

        static bool StartsWithH(string str)
        {
            //Kurzform:
            return (str[0] == 'H' || str[0] == 'h');

            //if (str[0] == 'H' || str[0] == 'h')
            //{
            //    return true;
            //}
        }

        static bool LongerThanFive(string str)
        {
            return (str.Length > 5);
        }
    }
}
