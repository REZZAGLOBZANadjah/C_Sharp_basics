using System;
using System.Collections.Generic;
namespace ConsoleAppCollectionsStack
{
    class Program
    {
        static void Main(string[] args)
        {//LIFO last in first out 
            Stack<string> names = new Stack<string>();
            names.Push("Tedjani");
            names.Push("Nadjah");
            names.Push("Abir");
            names.Push("Tahar");
            names.Push("Ali");
            names.Push("Omar");

            foreach (var name in names )
            {
                Console.WriteLine("names :"+name);

            }
            Console.WriteLine("-------------------------" );
            Console.WriteLine(" pop method:" + names.Pop());
            Console.WriteLine("-------------------------");
            foreach (var name in names)
            {
                Console.WriteLine("names :" + name);

            }
            Console.WriteLine("-------------------------");
            Console.WriteLine(" Peek method:" + names.Peek());
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine(" pop method:" + names.Pop());
            Console.WriteLine("-------------------------");
            foreach (var name in names)
            {
                Console.WriteLine("names :" + name);

            }

        }
    }
}
