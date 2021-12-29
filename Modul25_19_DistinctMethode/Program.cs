using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Diagnostics.CodeAnalysis;


/*
 *Die Distinct Methode
 *Alle einzigartigen Werte einer Collection herausfinden
 *
 *
 *Was ist die Distinct Methode?
 *->Die Distinct() Methode ruft man auf einer Collection auf, um sich eine neue Collection zurückgeben zu lassen, die alle einzigartigen Werte der originalen Collection enthält
 *->In der zurückgegebenen Collection kommt jeder Wert also nur ein einziges mal vor, auch wenn die ursprüngliche Collection doppelte Werte beinhaltet*
 * 
 * 
 * Objekte von eigenen Klassen vergleichen
 * ->Die Distinct() Methode vergleicht von Haus aus keine Objekte von komplexen Datentypen
 * ->Damit man Objekte von eigenen Klassen vergleichen kann, muss man eine Comparer-Klasse erstellen, die das Interface "IEqualityComparer" implementiert
 * 
 */


namespace Modul25_19_DistinctMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections
            string[] names =
            {
                "Alina",
                "Janek",
                "Hendrik",
                "Alina"
            };

            int[] numbers = { 1, 2, 3, 1, 2, 4, 5 };

            Console.WriteLine("Vergleichen von Collections - Array");
            var distinctNames = names.Distinct();

            foreach (string name in distinctNames)
            {
                Console.WriteLine(name);
            }


            Console.WriteLine();
            Console.WriteLine("Vergleichen von Collections - Array");
            var distincNumbers = numbers.Distinct();

            foreach (int number in distincNumbers)
            {
                Console.WriteLine(number);
            }


            //Objekte von eigenen Klassen vergleichen -> ohne Klasse CustomerComparer --> Alina immer noch zweimal vorhanden
            Console.WriteLine();
            Console.WriteLine("Objekte von eigenen Klassen vergleichen -> ohne Klasse CustomerComparer --> Alina immer noch zweimal vorhanden");
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(1, "Janek"));
            customerList.Add(new Customer(2, "Alina"));
            customerList.Add(new Customer(2, "Alina"));
            customerList.Add(new Customer(3, "Hendrik"));

            var distinctCustomers = customerList.Distinct();

            foreach (Customer customer in distinctCustomers)
            {
                Console.WriteLine($"{customer.Name} - ({customer.CustomerID})");
            }


            //Objekte von eigenen Klassen vergleichen -> mit Klasse CustomerComparer
            Console.WriteLine();
            Console.WriteLine("Objekte von Klassen vergleichen mit der Klasse CustomerComparer:");
            var distinctCustomersComparer = customerList.Distinct(new CustomerComparer());

            foreach (Customer customer in distinctCustomersComparer)
            {
                Console.WriteLine($"{customer.Name} - ({customer.CustomerID})");
            }

        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }


        public Customer(int customerID, string name)
        {
            CustomerID = customerID;    
            Name = name;
        }
    }

    class CustomerComparer : IEqualityComparer<Customer>
    {
        public bool Equals(Customer x, Customer y)
        {
            if(x.CustomerID == y.CustomerID && x.Name == y.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Customer obj)
        {
            return obj.CustomerID.GetHashCode();
        }
    }
}
