using System;
using System.Collections.Generic;
namespace ConsoleAppCollectionsQueue
{
    class Program
    {
        static void Main(string[] args)
        {//FIFO First in first out 
            Queue<string> names = new Queue<string>();
            names.Enqueue("omar"); // add new elemnts to Queue
            names.Enqueue("ali");
            names.Enqueue("ahmed");
            names.Enqueue("khadija");
            foreach (var name in names )
            {
                Console.WriteLine("names :"+name);

            }
            Console.WriteLine("----------------------------------" );
            Console.WriteLine("Peek : " + names.Peek());
            Console.WriteLine("Deque : "+names.Dequeue());//delete first elemnt
            Console.WriteLine("----------------------------------");
            foreach (var name in names)
            {
                Console.WriteLine("names :" + name);

            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Peek : " + names.Peek());
            Console.WriteLine("Deque : " + names.Dequeue());
            Console.WriteLine("----------------------------------");
        foreach (var name in names)
            {
                Console.WriteLine("names :" + name);

            }
        }

}
}
