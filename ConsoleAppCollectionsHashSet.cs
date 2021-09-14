using System;
using System.Collections.Generic;

namespace ConsoleAppCollectionsHashSet
{
    class Program
    {
        static void Main(string[] args)
        {// HashSet accept unique  data list values
            var names = new HashSet<string>();
            names.Add("Najah");
            names.Add("Abir");
            names.Add("Tahar");
            names.Add("Najah");//this hashSet will no show in consol .repeated 

            var ages = new HashSet<int>() { 29,26,24,29}; //duplicate value 29

            foreach (var name in names)
            {
                Console.WriteLine("Names in HashSet!"+name);

            }
            foreach (var age in ages)
            {
                Console.WriteLine("Names in HashSet!" + age);

            }

        }
    }
}
