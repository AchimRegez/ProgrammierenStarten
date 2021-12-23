using System;
using System.Linq;
using System.Collections.Generic;


namespace Modul25_13_Join
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
            orderList.Add(new Order(3, 1, "T-Shirt"));
            orderList.Add(new Order(4, 3, "Computer Game"));
            orderList.Add(new Order(1, 1, "Shoes"));

            //Addresses
            List<Address> addressList = new List<Address>();
            addressList.Add(new Address(1, "Johnson Street 4"));
            addressList.Add(new Address(2, "Brown Street 2"));
            addressList.Add(new Address(3, "Pruin Street 1"));

            //Query-Syntax
            Console.WriteLine("Query-Syntax");
            Console.WriteLine("---------------------------------------------");
            var orderQuery = from order in orderList
                             join customer in customerList
                             on order.CustomerID equals customer.CustomerID
                             join address in addressList
                             on order.AddressID equals address.AddressID
                             select new
                             {
                                 Product = order.ProductName,
                                 CustomerName = customer.Name,
                                 AddressLine = address.AddressLine
                             };

            foreach (var order in orderQuery)
            {
                Console.WriteLine(order.CustomerName + " bought " + order.Product + " - " + order.AddressLine);
            }


            //Methoden-Syntax
            Console.WriteLine();
            Console.WriteLine("Method-Syntax");
            Console.WriteLine("---------------------------------------------");
            var orderQueryMethod = orderList.Join(customerList, order => order.CustomerID, customer => customer.CustomerID,
                                                 (order, customer) => new
                                                 {
                                                     Product = order.ProductName,
                                                     CustomerName = customer.Name
                                                 });

            foreach (var order in orderQueryMethod)
            {
                Console.WriteLine(order.CustomerName + " bought " + order.Product);
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
