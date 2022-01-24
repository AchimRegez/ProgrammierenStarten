using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Modul25_28_XML_DateienMit_LINQ_Abfragen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument customers = XDocument.Load(@"C:\Users\Thanatos\source\repos\ProgrammierenStarten\Modul25_28_XML_DateienMit_LINQ_Abfragen\customers.xml");

            //foreach(var element in customers.Descendants("Kunde"))
            //{
            //    Console.WriteLine(element.Name);
            //}

            var firstNameQuery = from customer in customers.Descendants("Kunde")
                                 select customer.Element("Vorname").Value;

            foreach(string name in firstNameQuery)
            {
                Console.WriteLine(name);
            }


            var customersInLondon = from customer in customers.Descendants("Kunde")
                                    where customer.Element("Adresse").Attribute("Ort").Value == "London"
                                    select customer;

            Console.WriteLine();
            Console.WriteLine("Alle Kunden aus London: ");
            foreach (var customer in customersInLondon)
            {
                Console.WriteLine(customer.Element("Vorname").Value + " " + customer.Element("Nachname").Value + " " + customer.Element("Adresse").Attribute("Strasse") + " " + customer.Element("Adresse").Attribute("Ort"));
            }
        }
    }
}
