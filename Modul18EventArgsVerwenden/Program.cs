using System;
using System.Collections.Generic;

namespace Modul18EventArgsVerwenden
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

        static void OnAdded(object sender, AddedEventArgs args)
        {
            Console.WriteLine("Das Objekt {0} wurde zur Liste hinzugefügt...", args.AddedItem.ToString());
        }
    }

    delegate void AddedEventHandler(object sender, AddedEventArgs args);
    class BetterList<T> : List<T>
    {
        public new void Add(T item)
        {
            base.Add(item);
            OnAdded(item);
        }

        public event AddedEventHandler Added;
        private void OnAdded(T item)
        {
            if (Added != null)
            {
                Added(this, new AddedEventArgs(item));
            }
        }
    }

    class AddedEventArgs : EventArgs
    {
        public object AddedItem { get; set; }

        public AddedEventArgs(object addedItem)
        {
            AddedItem = addedItem;
        }
    }
}
