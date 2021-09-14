using System;

namespace ConsoleAppOOPSealedKeyword
{sealed class Person // sealed : this class is protected can herit attributes form this class
    {
        public void walk()
        {
            Console.WriteLine("walk...!");

        }
    }
    class Student: Person //this class cant herit from Person class 
    {
        public void smile()
        {
            Console.WriteLine("smile...!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
