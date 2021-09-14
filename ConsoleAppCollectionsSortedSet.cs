using System;
using System.Collections.Generic;
namespace ConsoleAppCollectionsSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {// show data  ordered
            var names = new SortedSet<string>();
            names.Add("Nadjah");
            names.Add("Abir");
            names.Add("Tahar");
            names.Add("Nadjah");

            var ages = new SortedSet<int>() { 29,26,24,29};

            foreach (var name in names )
            {
                Console.WriteLine("Names in SortedSet !" + name);

            }
            foreach (var age in ages)
            {
                Console.WriteLine("Names in SortedSet !" + age);

            }

        }
    }
}
