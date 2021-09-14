using System;

namespace ConsoleAppOOPAbstraction
{
    abstract class Person
    {
        public abstract void name(); // abstract function should be in abstruct class
                                     // do not add the body of this abstract function  {}// we declar only the name 
        public abstract void age(); //all declared functions shold implemented in other classes even with no actions {]
    }
    class Student : Person
    {
        public override void name()
        {
            Console.WriteLine("Mariem Student!");

        }
        public override void age()
        {

        }
    }
    class Emplyee : Person
    {
        public override void name()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Mariem Emplyee!");

        }
        public override void age()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person per;
            per = new Student();
            per.name();
            per = new Emplyee();
            per.name();
        }
    }
}
