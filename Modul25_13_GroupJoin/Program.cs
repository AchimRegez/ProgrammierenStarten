using System;
using System.Collections.Generic;
using System.Linq;

/*
 *Die GroupJoin-Methode
 *Verknüfte Daten in Gruppen unterteilen
 *
 *
 *Was ist ein GroupJoin
 *->Bei einem GroupJoin werden die verknüpften Daten nicht als einfache verknüpfte Objekte 
 *  in die Ergebnismenge aufgenommen, sondern als Objekte die Gruppen enthalten
 *->Die Gruppen können wie bei der GroupBy-Methode einzeln durchlaufen werden
 *->Die Objekte der Inner-Sequence werden in Gruppen aufgeteilt
 * 
 * ->Die GroupJoin-Methode erwartet dieselben Parameter wie die einfache Join-Methode
 */

namespace Modul25_14_GroupJoin
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
            var ordersByAddress = from address in addressList
                                  join order in orderList
                                  on address.AddressID equals order.AddressID
                                  into addressGroup
                                  select new
                                  {
                                      Orders = addressGroup,
                                      AddressLine = address.AddressLine
                                  };

            foreach (var address in ordersByAddress)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(address.AddressLine);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------");

                foreach (var order in address.Orders)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(order.ProductName);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
            }


            //Method-Syntax
            Console.WriteLine("Method-Syntax");
            Console.WriteLine("------------");
            Console.WriteLine();
            var ordersByAddressMethod = addressList.GroupJoin(orderList, address => address.AddressID, order => order.AddressID,
                                                             (address, addressGroup) => new
                                                             {
                                                                 Orders = addressGroup,
                                                                 AddressLine = address.AddressLine
                                                             });

            foreach (var address in ordersByAddressMethod)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(address.AddressLine);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-----------------");

                foreach (var order in address.Orders)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(order.ProductName);
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine();
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
