using System;
using System.Collections.Generic;

/*Dictionaries sind eine Datenstruktur, welche man mit einem Wörterbuch vergleichen kann.
 * 
 * Die Werte die darin gespeichert werden, besten aus einem Key (Schlüssel) und einem Value (Wert).
 * 
 * Möchte man auf einen Wert zugreifen, braucht man dafür den dazugehörenden Schlüssel
 * 
 * Key und Value können dabei von einem beliebigen Datentyp sein!
 */

namespace Modul15Dictionaries_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> customer = new Dictionary<int, string>();

            customer.Add(1000, "Hans Nötig");
            customer.Add(1001, "Sebastian Blabla");
            customer.Add(1002, "Blubbb Blayyyb");
            customer.Add(1003, "Alina Spatz");

            //Remove Methode werden key value Paare gelöscht
            customer.Remove(1000);
            
            //ContainsKey Methode überprift ob es den key gibt, bevor man darauf zugreift, z.B. um Fehler abzufangen falls 100 eingegeben wird 
            if (customer.ContainsKey(1000))
                Console.WriteLine(customer[1000]);
                Console.WriteLine(customer[1003]);

            foreach(KeyValuePair<int, string> customerInfo in customer)
            {
                Console.WriteLine("Der Schlüssel: {0} gehört zum Kunden: {1}", customerInfo.Key, customerInfo.Value);
            }

            Console.ReadKey();
        }
    }
}
