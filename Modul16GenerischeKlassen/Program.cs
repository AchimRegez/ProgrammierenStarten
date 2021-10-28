using System;

namespace Modul16GenerischeKlassen
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueContainer<string> valueContainer1 = new ValueContainer<string>("Hans Nötig");
            valueContainer1.ValueOutput();

            ValueContainer<int> valueContainer2 = new ValueContainer<int>(12);
            valueContainer2.ValueOutput();

            ValueContainer<double> valueContainer3 = new ValueContainer<double>(12.12);
            valueContainer3.ValueOutput();

            Console.ReadKey();
        }
    }
}
