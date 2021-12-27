using System;
using System.Collections.Generic;
using System.Linq;

/*
 *Die Element Operatoren
 *Auf bestimmte Elemente einer Sequenz zugreifen
 *
 *
 *Was sind die Element Operatoren?
 *->Die Element Operatoren sind Methoden, mit welchen man auf ein bestimmtes Objekt einer Sequenz zugreifen kann
 *-->ElementAt
 *-->ElementAtOrDefault
 * -->First
 * -->FirstOrDefault
 * -->Last
 * -->LastOrDefault
 * -->Single
 * -->SingleOrDefault
 * 
 */

namespace Modul25_16_ElementOperatoren
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
            var customerQuery = from customer in customerList
                                select customer.Name;

            Console.WriteLine(customerQuery.ElementAt(3));  //In der Klammer wird der Index übergeben von der Customer Liste -> 0 = Peter Johnson, 1 = Sabrina Johnson, 2 = Samuel Brown, 3 = Janek Pruin


            //Uncomment -> für ArgumentOutOfRangeException
            ////System.ArgumentOutOfRangeException: 'Specified argument was out of the range of valid values. Arg_ParamName_Name
            //Console.WriteLine();
            //Console.WriteLine("System.ArgumentOutOfRangeException: 'Specified argument was out of the range of valid values. Arg_ParamName_Name'");
            //var customerQueryException = from customer in customerList
            //                    select customer.Name;

            //Console.WriteLine(customerQueryException.ElementAt(4));


            //Wenn System.ArgumentOutOfRangeException nicht gewollt ist
            Console.WriteLine();
            Console.WriteLine("System.ArgumentOutOfRangeException -> ElementAtOrDefault");
            var customerQueryExceptionDefault = from customer in customerList
                                         select customer.Name;

            Console.WriteLine(customerQueryExceptionDefault.ElementAtOrDefault(4)); // Liefert einen Standardwert zurück (bei out of range) -> hier einen leeren String


            //First
            Console.WriteLine();
            Console.WriteLine("First");
            var customerQueryFirst = from customer in customerList
                                select customer.Name;

            Console.WriteLine(customerQueryFirst.First());


            //First mit Bedingung
            //FirstOrDefault gibt einen Standartwert bei einer Exception zurück -> siehe First
            Console.WriteLine();
            Console.WriteLine("First mit Bedingung // First with condition");
            var customerQueryFirstWithCondition = from customer in customerList
                                     select customer.Name;

            Console.WriteLine(customerQueryFirstWithCondition.First(name => name.Contains("Sabrina"))); // Der erste Customer mit Name Sabrina wird aufgerufen -> Bedingung


            //First Exception -> !!! COMMENT OUT CUSTOMER LIST FOR EXCPETION !!!
            Console.WriteLine();
            Console.WriteLine("First Exception");
            var customerQueryFirstException = from customer in customerList
                                     select customer.Name;

            Console.WriteLine(customerQueryFirstException.First());


            //Last
            Console.WriteLine();
            Console.WriteLine("Last");
            var customerQueryLast = from customer in customerList
                                     select customer.Name;

            Console.WriteLine(customerQueryLast.Last());


            //Last mit Bedingung
            //LastOrDefault gibt einen Standartwert bei einer Exception zurück -> siehe First
            Console.WriteLine();
            Console.WriteLine("Last mit Bedingung // Last with condition");
            var customerQueryLastWithCondition = from customer in customerList
                                    select customer.Name;

            Console.WriteLine(customerQueryLastWithCondition.Last(name => name.Contains("Brown"))); // Der letzte Customer mit Name Brown wird aufgerufen -> Bedingung


            //Single
            Console.WriteLine();
            Console.WriteLine("Single");
            var customerQuerySingle = from customer in customerList
                                    select customer.Name;

            Console.WriteLine(customerQuerySingle.Single(name => name.Contains("Sabrina")));
            //Console.WriteLine(customerQuerySingle.Single(name => name.Contains("Johnson"))); // schmeisst eine Exception weil zwei Johnson in der Customer Liste sind (comment out)


            Console.WriteLine();
            Console.WriteLine("SingleOrDefault");
            var customerQuerySingleOrDefault = from customer in customerList
                                      select customer.Name;
            //SingleOrDefault gibt einen Standartwert bei einer Exception zurück -> siehe First
            Console.WriteLine(customerQuerySingleOrDefault.SingleOrDefault(name => name.Contains("Ford")));




            //Method-Syntax
            Console.WriteLine();
            Console.WriteLine("Method-Syntax");
            Console.WriteLine("------------");
            Console.WriteLine();
            


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
