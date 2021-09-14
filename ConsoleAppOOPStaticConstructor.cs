using System;

namespace ConsoleAppOOPStaticConstructor
{

    class Employee
    {
        public string name;
        public int age;
        public static string companyName;// static value does not change 
        public static int counter = 0;
        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
            counter++;
        }
        // Constructor to change static value  of companyName in Epmloyee class
        static Employee()
        {
            companyName = "OORCOOD";
        }
        public void PrintInfo()
        {
            Console.WriteLine("name :" + name + "\n " + age + "\n company name : " + companyName);

        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("najah",29);
            emp.PrintInfo();
        }
    }
}
