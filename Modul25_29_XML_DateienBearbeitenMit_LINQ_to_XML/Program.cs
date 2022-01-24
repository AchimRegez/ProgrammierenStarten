using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;



namespace Modul25_29_XML_DateienBearbeitenMit_LINQ_to_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XDocument customers = XDocument.Load(@"C:\Users\Thanatos\source\repos\ProgrammierenStarten\Modul25_28_XML_DateienMit_LINQ_Abfragen\customers.xml");

            var customersInLondon = from customer in customers.Descendants("Kunde")
                                    where customer.Element("Adresse").Attribute("Ort").Value == "London"
                                    select customer;

            foreach(var customer in customersInLondon)
            {
                customer.Element("Vorname").Value = "NEUER NAME";
            }

            foreach(var customer in customersInLondon)
            {
                customer.SetElementValue("Vorname", "ZWEITER NEUER NAME");
            }

            foreach (var customer in customersInLondon)
            {
                customer.SetElementValue("NeuesElement", "Hallo World"); //Methode SetElementValue erstellt den Eintrag wenn nicht vorhanden !ACHTUNG!: string? darf kein Leerzeichen enthalten -> "NeuesElement"
            }

            //foreach (var customer in customersInLondon)
            //{
            //    customer.SetElementValue("NeuesElement", null); //Methode SetElementValue löscht das Element
            //}

            foreach (var customer in customersInLondon)
            {
                customer.SetAttributeValue("test", 10);
            }

            //foreach (var customer in customersInLondon)
            //{
            //    customer.SetAttributeValue("test", null);
            //}

            foreach(var customer in customersInLondon)
            {
                customer.RemoveAll();
            }


            customers.Save(@"C:\Users\Thanatos\source\repos\ProgrammierenStarten\Modul25_29_XML_DateienBearbeitenMit_LINQ_to_XML\customers.xml");

        }
    }
}
