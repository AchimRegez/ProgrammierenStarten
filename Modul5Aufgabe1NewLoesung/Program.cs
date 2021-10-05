using System;

namespace Modul5Aufgabe1NewLoesung
{
    /*
 * Schreibe ein Konsolenprogramm das einen BMI-Rechner darstellt. Der BMI (Body-Mass-Index) ist ein Richtwert, mit welchem man das Körpergewicht in Relation zur Körpergröße bewerten kann. Der BMI-Rechner soll zur Laufzeit die benötigten Daten für die Berechnung des BMI-Wertes vom Benutzer abfragen.
Die Formel für die Berechnung des BMI-Wertes lautet: Körpergewicht / Körpergröße²
Das Körpergewicht ist angegeben in Kilogram und die Körpergröße ist angegeben in Metern.
Nachdem der BMI berechnet wurde, soll dieser noch eingeordnet werden. Die BMI-Klassifizierung der Weltgesundheitsorganisation (WHO) sieht folgendermaßen aus:
0 – 18,4 → Untergewicht
18,5 – 24, 9 → Normalgewicht
25 – 29,9 → Übergewicht
30 – 34,9 → Adipositas Grad 1
35 – 39,9 → Adipositas Grad 2
Ab 40 → Adipositas Grad 3
Gebe den BMI und die Klassifizierung in der Konsole aus.
 * 
 * 
 */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe dein Gewicht (kg) an: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gebe deine Körpergrösse (m) an: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double bmi = weight / (height * height);
            string classification = "";

           
            if (bmi < 18.5)
            {
                classification = "Untergewicht";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                classification = "Normalgewicht";

            }
            else if (bmi >= 25 && bmi < 30)
            {
                classification = "Übergewicht";
            }
            else if (bmi >= 30 && bmi < 35)
            {
                classification = "Adipositas 1";
            }
            else if (bmi >= 35 && bmi < 40)
            {
                classification = "Adipositas 2";
            }
            else if (bmi >= 40)
            {
                classification = "Adipositas 3";
            }
            else{
                Console.WriteLine("Ungültiger Wert");
            }

            Console.WriteLine("Dein BMI ist: {0} und du hast: {1}", bmi, classification);
            Console.ReadKey();

        }
    }
}
