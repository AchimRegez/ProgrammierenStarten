using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


/*
 *XML im Code generieren speichern und laden
 *
 */


namespace Modul25_27_XML_ImCodeGenerierenSpeichernUndLaden
{
    class Program
    {
        static void Main(string[] args)
        {
            //XML-Dokument generieren
            Console.WriteLine("XML-Dokument generieren");
            XDocument customers = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                                                new XElement("Kunden",
                                                    new XElement("Kunde",
                                                        new XElement("KundenID", 1),
                                                        new XElement("Vorname", "Peter"),
                                                        new XElement("Nachname", "Smith"),
                                                        new XElement("Adresse", new XAttribute("Ort", "London"), new XAttribute("Strasse", "Smith Street 12"))),
                                                    new XElement("Kunde",
                                                        new XElement("KundenID", 2),
                                                        new XElement("Vorname", "Hans"),
                                                        new XElement("Nachname", "Noetig"),
                                                        new XElement("Adresse", new XAttribute("Ort", "Zurigo"), new XAttribute("Strasse", "Langistrasse 12")))));

            customers.Save("customers.xml");
            Console.WriteLine(customers.ToString());



            //XML-Dokument laden
            Console.WriteLine();
            Console.WriteLine("XML-Dokument laden");
            XDocument customerLoad = XDocument.Load("customers.xml");
            Console.WriteLine(customerLoad.ToString());

        }
    }
}
