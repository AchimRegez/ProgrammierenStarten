using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul16GenerischeKlassen
{
    class ValueContainer<T>
    {
        public T MyValue { get; set; }

        public ValueContainer(T myValue)
        {
            MyValue = myValue;
        }

        public void ValueOutput()
        {
            Console.WriteLine(MyValue.ToString());
        }
    }
}
