using System;
using System.Collections.Generic;

namespace Modul15Queues_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Queues sind eine Datenstruktur, welche man mit einer Warteschlange vergleichen kann.
             * 
             * Die Queue-Klasse enthält 3 wichtige Methoden:
             * Enqueue() -> Fügt einen Wert zur Warteschlange hinzu
             * Dequeue() -> Liest und löscht den ersten Wert in der Warteschlange
             * Peek()    -> Liest den ersten Wert ohne ihn zu löschen
             */
            Queue<string> personQueue = new Queue<string>();

            personQueue.Enqueue("Hans Nötig");
            personQueue.Enqueue("Peter Lustig");
            personQueue.Enqueue("Sabrina Valdi");
            personQueue.Enqueue("Alina Baum");
            personQueue.Enqueue("Vanessa Spatz");

            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());
            Console.WriteLine(personQueue.Dequeue());
            
            Console.WriteLine(personQueue.Peek());

            Console.WriteLine(personQueue.Dequeue());

            Console.WriteLine(personQueue.Peek());
            Console.WriteLine(personQueue.Peek());


        }
    }
}
