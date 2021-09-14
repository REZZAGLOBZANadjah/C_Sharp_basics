using System;

namespace ConsoleAppOOPEncapsulation
{
    class Employee
    {
        public string name { get; set; }
        public int age { get; set; }
        public float salary { get; set; }
        public string departement { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Nadjah";
            emp.age = 29;
            emp.salary = 123456.45f;
            emp.departement = "C# devoloper";

            Console.WriteLine("name : " +emp.name);
            Console.WriteLine("age : " +emp.age);
            Console.WriteLine("salary : " +emp.salary); 
            Console.WriteLine("departement : " +emp.departement);
        }
    }
}
