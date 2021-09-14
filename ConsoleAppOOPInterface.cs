using System;

namespace ConsoleAppOOPInterface
{
   // Interface multi inheritance
   interface Person
    {
        void fullName();
    }
    interface Person2
    {
        void age();
    }
    class Student: Person,Person2 // herite from 2 interfaces 
    {
       public void fullName()
        {
            Console.WriteLine("Student full Name!");
        }
        public void age()
        {
            Console.WriteLine("Student age!");
        }
    }
    class Employee : Person
    {
        public void fullName()
        {
            Console.WriteLine("Employee full Name!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person per;
            Student std = new Student();//shold define student object to access to class person and person2 methods 
             std.fullName();
             std.age();

            per = new Employee();
            per.fullName();

        }
    }
}
