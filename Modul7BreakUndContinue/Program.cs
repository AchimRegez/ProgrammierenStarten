using System;

namespace Modul7BreakUndContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            // break

            // mit break kann man eine Schleife an der Stelle abbrechen, wo sie gerade ist

            Console.WriteLine("break");
            int numberBreak = 0;

            while(numberBreak <= 10)
            {
                Console.WriteLine(numberBreak);

                if (numberBreak == 5)
                {
                    break;
                }

                numberBreak++;
            }

            Console.WriteLine();

            // continue

            // mit continue kann der aktuelle Schleifendurchgang unterbrochen werden, die Schleife wird aber fortgesetzt

            Console.WriteLine("continue");
            int numberContinue = 0;

            while (numberContinue < 10)
            {

                numberContinue++;

                if (numberContinue == 5)
                {
                    continue;
                }

                Console.WriteLine(numberContinue);

            }


        }
    }
}
