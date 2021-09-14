using System;
using System.Collections.Generic;

namespace Collections_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string>();
            names.Add("Nadjah");
            names.Add("FRIHA");
            names.Add("abir");
            names.Add("rezzag");

            var ages = new List<int>() {29,26,26,10};
             foreach (var name in names)
            {
                Console.WriteLine("name: "+name);

            }
            foreach (var age in ages)
            {
                Console.WriteLine("name: " + age);

            }

        }
    }
}
