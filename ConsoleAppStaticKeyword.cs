using System;

namespace ConsoleAppStaticKeyword
{
    class Employee
    {
        public string name;
        public int age;
        public static string companyName=" GamaDev";// static value does not change 
        public static int counter=0;
        public Employee(string name,int age)
        {
            this.name = name;
            this.age = age;
            counter++;
        }
        public void PrintInfo()
        {
            Console.WriteLine("name :" +name+"\n "+ age+ "\n company name : "+ companyName);

        }
    }
    // if we add static to class we should change all members to static 
    static class student
    {
        public static string name="ali";//static added befor each membre 
        //public int age;//erreur impossible de déclarer des membre  d'instance de static class
        public static int age=25;
        public static string companyName = " GamaDev";// static value does not change 
        public static int counter = 0;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(" REZZAG LOBZA Nadjah", 29);
            Employee emp1 = new Employee(" REZZAG LOBZA Abir", 26);
            Employee emp2 = new Employee(" REZZAG LOBZA Tahar", 24);
            emp.PrintInfo();
            emp1.PrintInfo();
            emp2.PrintInfo();
            Console.WriteLine("Employees No: " + Employee.counter);
            // print inf of static class
            Console.WriteLine(" static class attributes \n" +
                "name :" + student.name + "\n age " + student.age + "\n company name : " + student.companyName);

        }
    }

}


