using System;
using System.Collections.Generic;
using System.Linq;

/*
 *Der Select Operator
 *Ergebnisse einer Abfrage zurückgeben
 *
 *
 *Was ist der Select Ooperator
 *->Der Select Operator gibt die Ergebnisse einer Abfrage zurück
 *->Er gibt immer eine Collection vom Typ "IEnumerable" zurück
 *
 *->Die zurückgegebenen Collection kann Werte von folgenden Typen beinhalten
 *-->Einfache Datentypen (int, string...)
 *-->Eigene Klassen
 *-->Anonymer Datentyp der Properties beinhaltet die wir für unsere Abfrage brauchen
 * 
 */

namespace Modul25_15_SelectOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customers
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(1, 1, "Peter Johnson"));
            customerList.Add(new Customer(2, 1, "Sabrina Johnson"));
            customerList.Add(new Customer(3, 2, "Samuel Brown"));
            customerList.Add(new Customer(4, 3, "Janek Pruin"));

            //Orders
            List<Order> orderList = new List<Order>();
            orderList.Add(new Order(2, 1, "Socks"));
            orderList.Add(new Order(3, 2, "T-Shirt"));
            orderList.Add(new Order(4, 3, "Computer Game"));
            orderList.Add(new Order(1, 1, "Shoes"));

            //Addresses
            List<Address> addressList = new List<Address>();
            addressList.Add(new Address(1, "Johnson Street 4"));
            addressList.Add(new Address(2, "Brown Street 2"));
            addressList.Add(new Address(3, "Pruin Street 1"));

            //Query-Syntax
            Console.WriteLine("Query-Syntax");
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine("Query1");
            var customerQuery = from customer in customerList
                                select customer;

            foreach(var customer in customerQuery)
            {
                Console.WriteLine(customer.Name);
            }


            Console.WriteLine();
            Console.WriteLine("Query2");
            var customerQuery1 = from customer in customerList
                                select customer.Name;

            foreach (var customerName in customerQuery1)
            {
                Console.WriteLine(customerName);
            }


            Console.WriteLine();
            Console.WriteLine("Query3");
            var customerQuery2 = from customer in customerList
                                 select new
                                 {
                                     CustomerString = $"{customer.Name} ({customer.CustomerID})"
                                 };

            foreach(var customer in customerQuery2)
            {
                Console.WriteLine(customer.CustomerString);
            }


            //Method-Syntax
            Console.WriteLine();
            Console.WriteLine("Method-Syntax");
            Console.WriteLine("------------");
            Console.WriteLine();
            var customerQueryMethod = customerList.Select(customer => new
            {
                CustomerString = $"{customer.Name} ({customer.CustomerID})"
            });

            foreach (var customer in customerQueryMethod)
            {
                Console.WriteLine(customer.CustomerString);
            }


        }
    }

    class Customer
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string Name { get; set; }

        public Customer(int customerID, int addressID, string name)
        {
            CustomerID = customerID;
            AddressID = addressID;
            Name = name;
        }
    }

    class Order
    {
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public string ProductName { get; set; }

        public Order(int customerID, int addressID, string productName)
        {
            CustomerID = customerID;
            AddressID = addressID;
            ProductName = productName;
        }
    }

    class Address
    {
        public int AddressID { get; set; }
        public string AddressLine { get; set; }

        public Address(int addressID, string addressLine)
        {
            AddressID = addressID;
            AddressLine = addressLine;
        }
    }
}
