using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Anonyme Methoden und Lambda Ausdrücke
 * 
 * 
 * Was ist eine Anonyme Methode?
 * 
 * Eine Anonyme Methode ist eine Methode ohne Bezeichner
 * -> Mann kann sie nicht über ihren Namen aufrufen (da nicht vorhanden)
 * 
 * Man definiert Anonyme Methoden, wenn man einem Delegate eine Methode zuweisen
 * möchte, die man nicht extra separat definieren will (weil man sie z.B. nur bei diesem Delegate braucht)
 *  
 * 
 */

namespace Modul25_02_AnonymeMethodenUndLambdaAusdruecke
{
    class Program
    {
        //Delegate initialisieren
        delegate void TestDelgate(string str);
        delegate double Calculate(double x, double y);


        static void Main(string[] args)
        {
            TestDelgate del = new TestDelgate(DoSomething);

            del("Hans Nötig");
            

            //Anonymous Method

            TestDelgate delAnonym = delegate (string name)
            {
                Console.WriteLine("Hello {0}", name);
            };

            delAnonym("Fritz Klein!!!");


            //Lambda Expression

            TestDelgate delLambda = (name) => { Console.WriteLine("Hello {0}!!!", name); };

            delLambda("Corry");



            //Weiteres Beispiel Lambda Expression

            Calculate calc = (num1, num2) => { return num1 + num2; };
            //Kurzform (genau das selbe wie oben):
            Calculate calcShort = (num1, num2) => num1 + num2;  

            double result = calc(10, 2);
            Console.WriteLine("Das Ergebnis ist: {0}", result);

            double resultShort = calcShort(12, 12);
            Console.WriteLine("Das Ergebnis ist: {0}", resultShort);

            Console.ReadKey();
        }

        //Mit Methode
        static void DoSomething(string name)
        {
            Console.WriteLine("Hello {0}!!!", name);
        }
    }
}
