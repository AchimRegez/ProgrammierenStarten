using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


/*
 *Die Skip- und Take-Methoden 
 *Einen bestimmten Teil einer Sequenz zurück geben
 *
 *
 *Was sind die Skip-Methoden?
 *->Mit den Methoden Skip() und SkipWhile() können wir uns Elemente einer Sequenz zurück geben lassen
 *->Der Methode Skip() übergibt man dabei einen Integer-Wert als Parameter, welcher besagt wie viele von den ersten Werten der Sequenz nicht zurückgegeben werden sollen
 *->Der Methode SkipWhile() übergibt man als Parameter eine Bedingung. Es werden so viele Elemente übersprungen bis ein Element die Bedingugn nicht mehr erfüllt. Alle restlichen
 *  Elemente ab diesem Punkt werden zurückgegeben
 *  
 *->Skip bedeutet auf deutsch "Überspringen"
 *->Skip(4) => Überspringe die ersten 4 Elemente
 *->SkipWhile(Bedingung) => Überspringe alle Elemente bis die Bedingung nicht mehr erfüllt wird 
 * 
 * 
 * 
 * 
 * Was sind die Take-Methoden?
 *->Mit den Methoden Take() und TakeWhile() können wir uns ebenfalls Elemente einer Sequenz zurück geben lassen
 *->Der Methode Take() übergibt man dabei einen Integer-Wert als Parameter, welcher besagt wie viele der ersten Elemente zurückgegeben werden
 *->Der Methode TakeWhile() übergibt man als Parameter eine Bedingung. Es werden so viele Elemente zurückgegeben bis ein Element die Bedingung nicht mehr erfüllt
 *
 *->Take bedeutet auf deutsch "Nehmen"
 *->Take(5) => nehme die ersten 5 Elemente
 *->TakeWhile(Bedingung) => Nehme solange die Elemente, bis die Bedingung nicht mehr erfüllt wird
 * 
 */


namespace Modul25_23_SkipUndTakeMethode
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //Skip- & SkipWhile-Methods
            Console.WriteLine("Skip");
            var newNumbersSkip = numbers.Skip(5);

            foreach (int number in newNumbersSkip)            
                Console.WriteLine(number);


            Console.WriteLine();
            Console.WriteLine("SkipWhile");
            var newNumbersSkipWhile = numbers.SkipWhile(number => number < 6);

            foreach (int number in newNumbersSkipWhile)
                Console.WriteLine(number);


            //Take- & TakeWhile-Methods
            Console.WriteLine();
            Console.WriteLine("Take");
            var newNumbersTake = numbers.Take(5);

            foreach (int number in newNumbersTake)
                Console.WriteLine(number);


            Console.WriteLine();
            Console.WriteLine("TakeWhile");
            var newNumbersTakeWhile = numbers.TakeWhile(number => number < 6);

            foreach (int number in newNumbersTakeWhile)
                Console.WriteLine(number);
        }
    }
}
