using System;

namespace ConsoleAppOOPPolymorphism
{
class Person //base class
    {
        public string name = "Person";
        public virtual void run()
        {
            Console.WriteLine("running ...!");
        }
    }
    class Student : Person
    {
        public string name = "Najah";
        public override void run()
        {
            Console.WriteLine("Student running ...!");
        }
    }
    class Employee : Person
    {
        public override void run()
        {
            Console.WriteLine("Employee running ...!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Person per;//here we use polymorphisme ()
            per = new Student();
            per.run();
            // Student std = new Student();
            //std.run();
            //polymorphisme  can not applie on class field ()
            Console.WriteLine("Student Name...!" +per.name);

            per = new Employee();
            per.run();

            //Employee emp = new Employee();
            //emp.run();

        }
    }
}
