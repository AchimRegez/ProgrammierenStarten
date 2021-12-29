using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *LINQ to XML
 *Eine kleine Einführung
 *
 *
 *Was ist LINQ to XML?
 *->LINQ to XML ist ein im .NET-Framework integrierter LINQ-Provider
 *->Man kann damit LINQ-Abfragen für XML-Dateien schreiben
 *->Man kann damit auch XML-Dateien editiern
 *
 *LINQ to XML setzt keine Kenntnisse in XPath, XQuery oder DOM voraus, weshalb die Nutzung davon sehr einfach ist
 *
 *
 *
 *Die wichtigsten Klassen von LINQ to XML
 *->Die wichtigsten Funktionen von LINQ to XML befinden sich in nur 6 verschiedenen Klassen:
 *
 *->XDocument => Stellt ein komplettes XML-Dokument dar
 *->XElement => Stellt ein XML-Element dar (kann auch weitere XML-Elemente enthalten)
 *->XAttribute => Stellt ein XML-Attribut dar
 *->XComment => Stelle einen XML-Kommentar dar
 *->XNode => Stelle einen XML-Knoten (Element, Kommentar, Attribut...) dar
 *->XDeclaration => Stellt die XML-Deklaration dar
 *
 */


namespace Modul25_26_WasIst_LINQ_To_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
