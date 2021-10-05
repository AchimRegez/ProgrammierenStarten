using System;

namespace Modul5Aufgabe1New
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
            double bodyweight = 0;
            double bodysize = 0;
            double bmi = 0;

            Console.WriteLine("Bitte gib dein Körpergewicht in Kilogram ein: ");
            bodyweight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Bitte gib deine Körpergrösse in Metern ein: ");
            bodysize = Convert.ToDouble(Console.ReadLine());

            bmi = (bodyweight / (bodysize * bodysize));

            Console.WriteLine("Dein BMI ist: {0}", bmi);

            switch (bmi)
            {
                case (>= 0 and <= 18.4):
                    Console.WriteLine("Du hast Untergewicht");
                    break;

                case (>= 18.5 and <= 24.9):
                    Console.WriteLine("Du hast Normalgewicht");
                    break;

                case (>= 25 and <= 29.9):
                    Console.WriteLine("Du hast Übergewicht");
                    break;

                case (>= 30 and <= 34.9):
                    Console.WriteLine("Du hast Adipositas Grad 1");
                    break;

                case (>= 35 and <= 39.9):
                    Console.WriteLine("Du hast Adipositas Grad 1");
                    break;

                case (>= 40):
                    Console.WriteLine("Du hast Adipositas Grad 3");
                    break;

                default:
                    Console.WriteLine("Ungültiger Wert");
                    break;
            }

            Console.ReadKey();


        }
    }
}
