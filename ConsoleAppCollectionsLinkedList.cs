using System;
using System.Collections.Generic;

namespace ConsoleAppCollectionsLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {// LinkedList can add element in the first of list or last befor element or after ....
            var names = new LinkedList<string>();
            names.AddLast("samira");
            names.AddLast("friha");
            names.AddLast("ali");
            names.AddLast("muhammed");
            names.AddFirst("nadjah");

            foreach (var name in names )
            {
                Console.WriteLine(""+name);
            }
            LinkedListNode<string> secondNames = names.Find("friha");
            names.AddBefore(secondNames, "khaled");
            names.AddAfter(secondNames,"hana");
            Console.WriteLine("------------------------------" );
            foreach (var name in names)
            {
                Console.WriteLine("" + name);
            }
        }
    }
}
