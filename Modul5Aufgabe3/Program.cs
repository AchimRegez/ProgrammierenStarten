using System;

/* Programmiere einen BMI-Rechner (BMI = Body Mass Index) in der Konsole. Die Formel für den BMI lautet:
BMI = Körpergewicht / (Körpergröße in m)²
Anhand des BMI’s soll man einer der folgenden Kategorien zugeordnet werden:
Klassifikation              Männlich            Weiblich
Untergewicht                <20                 <19
Normalgewicht               20-25               19-24
Übergewicht                 25-30               24-30
Adipositas                  30-40               30-40
Massive Adipositas          >40                 >40
*/

namespace Modul5Aufgabe3
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            double heigt;
            double bmi;

            Console.WriteLine("Bitte gib dein Körpergewicht in kg ein: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Bitte gib deine Grösse in m ein: ");
            heigt = Convert.ToDouble(Console.ReadLine());

            bmi = (weight / (heigt * heigt));

            Console.WriteLine("Dein BMI ist: {0}", bmi);

            Console.ReadKey();

        }
    }
}
