using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *Sequenzen Konvertieren
 *Die As-, To- und Casting-Operatoren
 *
 */


namespace Modul25_24_SequenzenKonvertieren
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customerArray =
            {
                new Customer(1, "Janek"),
                new Customer(2, "Hendrik"),
                new Customer(3, "Alina"),
                new Customer(4, "Anna"),
            };

            var customerEnumerable = customerArray.AsEnumerable();

            var customerQueryable = customerArray.AsQueryable();

            var customerEnumerableCast = customerArray.Cast<Customer>();

            var customerList = customerArray.ToList();
            customerList.Add(new Customer(1, "Peter"));

            var customerArray2 = customerList.ToArray();
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
}
