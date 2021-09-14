using System;

namespace ConsoleAppOOPMethodOverriding
{
    class Program
    {
        class Person
        {
            public virtual void eating()//virtual can be changed in other subclasses 
            {
                Console.WriteLine("eating....!");

            }
        }
        class Student : Person
        {
            // override function  eating in runtime   we can save memory
            public override void eating() 
            {
                Console.WriteLine("Student is eating....!");

            }
        }
        static void Main(string[] args)
        {
            Student std = new Student();
            std.eating();
        }
    }
}
