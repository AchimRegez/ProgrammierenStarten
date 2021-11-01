using System;
using System.Collections.Generic;

namespace Modul18EventsDefinierenUndAusloesen
{
    class Program
    {
        static void Main(string[] args)
        {
            BetterList<string> names = new BetterList<string>();
            names.Added += OnAdded;

            names.Add("Sabrina");
            names.Add("Hans");
            names.Add("Vanessa");
            names.Add("Peter");

            Console.ReadKey();
        }

        static void OnAdded()
        {
            Console.WriteLine("Ein Objekt wurde zur Liste hinzugefügt...");
        }
    }

    public delegate void AddedEventHandler();
    class BetterList<T> : List<T>
    {
        public new void Add(T item)
        {
            base.Add(item);
            OnAdded();
        }

        public event AddedEventHandler Added;
        private void OnAdded()
        {
            if (Added != null)
                Added();
        }
    }
}
