using System;
using System.Collections.Generic;

namespace ConsoleAppCollectionsSortedList
{
    class Program
    {
        static void Main(string[] args)
        {// SortedList use less memory then sertedDictionnary ,but sertedDictionnary is faster in execution it is used in large amount of data 
            SortedList<string, string> fruits = new SortedList<string, string>();
            fruits.Add("1","citron");
            fruits.Add("5", "watermelon");
            fruits.Add("2", "banana");
            fruits.Add("4", "orange");
            fruits.Add("3", "green apple");

            foreach (KeyValuePair<string,string> fruit in fruits)
            {
                Console.WriteLine("key : "+fruit.Key+"  value :"+fruit.Value);

            }


        }
    }
}
