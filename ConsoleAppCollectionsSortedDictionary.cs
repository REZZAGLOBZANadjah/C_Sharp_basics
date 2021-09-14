using System;
using System.Collections.Generic;
namespace ConsoleAppCollectionsSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> names = new SortedDictionary<int, string>();
            names.Add(2,"tadjani");
            names.Add(5, "abir");
            names.Add(3, "tahar");
            names.Add(4, "abbas");
            names.Add(1, "Nadjah");

            foreach (KeyValuePair<int,string> name in names)
            {
                Console.WriteLine("key :"+name.Key+" value :"+name.Value);
            }
        }
    }
}
