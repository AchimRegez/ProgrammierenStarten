using System;
using System.Collections.Generic;

namespace Modul15Stacks_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Stacks haben 3 wichtige Methoden:
             * Push() -> Zum Hinzufügen von Werten auf den Stapel
             * Pop()  -> Gibt den obersten Wert auf dem Stapel zurück und löscht ihn dann
             * Peek() -> Gibt den obersten Wert auf dem Stapel zurück ohne ihn zu löschen
             */
            Stack<int> numberStack = new Stack<int>();

            numberStack.Push(1);
            numberStack.Push(2);
            numberStack.Push(3);
            numberStack.Push(4);

            Console.WriteLine(numberStack.Pop());
            //Console.WriteLine(numberStack.Pop());
            //Console.WriteLine(numberStack.Pop());
            //Console.WriteLine(numberStack.Pop());

            Console.WriteLine(numberStack.Peek());
            Console.WriteLine(numberStack.Peek());

            Console.ReadKey();
        }
    }
}
