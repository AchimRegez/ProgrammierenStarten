using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *Die Except Methode
 *Alle Werte die nicht in einer anderen Collection vorkommen zurückgeben lassen
 *
 *
 *Was ist die Except Methode?
 *->Die Except() Methode ruft man auf einer Collection auf und übergibt als Parameter eine andere Collection
 *->Sie gibt eine neue Collection mit allen Werten der ersten Collection zurück, die nicht in der zweiten Collection vorkommen 
 * 
 */


namespace Modul25_20_ExceptMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections            
            string[] names1 =
            {
                "Janek",
                "Alina",
                "Hendrik",
                "Peter"
            };

            string[] names2 =
            {
                "Claudia",
                "Sabrina",
                "Nadine",
                "Alina"
            };

            Console.WriteLine("Collections");
            var names3 = names1.Except(names2);

            foreach (string name in names3)
            {
                Console.WriteLine(name);
            }


            //Klassen
            Console.WriteLine();
            Console.WriteLine("Klassen");
            List<Customer> customerList1 = new List<Customer>();
            customerList1.Add(new Customer(1, "Janek"));
            customerList1.Add(new Customer(2, "Alina"));
            customerList1.Add(new Customer(3, "Hendrik"));


            List<Customer> customerList2 = new List<Customer>();
            customerList2.Add(new Customer(4, "Claus"));
            customerList2.Add(new Customer(2, "Alina"));
            customerList2.Add(new Customer(6, "Anna"));

            var customerList3 = customerList1.Except(customerList2, new CustomerComparer());

            foreach (Customer customer in customerList3)
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
            if (x.CustomerID == y.CustomerID && x.Name == y.Name)
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
