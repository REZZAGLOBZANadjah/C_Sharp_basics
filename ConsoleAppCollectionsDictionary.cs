using System;
using System.Collections.Generic;
namespace ConsoleAppCollectionsDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> names = new Dictionary<int, string>();
            names.Add(1, "nadjah");
            names.Add(2, "abir");
            names.Add(3, "tahar");
            names.Add(4, "tedjani");
            foreach (KeyValuePair<int,string> name in names)
            {
                Console.WriteLine("Key : "+name.Key+" Value :"+name.Value);

            }

        }
    }
}
