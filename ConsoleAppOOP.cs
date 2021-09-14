using System;

namespace ConsoleAppOOP
{
   public class Student
    {//class fields or attributes
        public string name; //public is acces modifier
        public int age;
        public double salary;
        public void AddData(string nameUser,int ageUser,double salaryUser) {
            name = nameUser;
            age = ageUser;
            salary = salaryUser;
        }
        public void PrintData()
        {
            Console.WriteLine(name + "  \n" + age +"  \n" +salary);
        }
    }
    class Program
    {// static for class not for the object 
        string name;
        int age;
        double salary;

        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.name = "Rezzag Lobza Nadjah";
            pro.age = 29;
            pro.salary = 300000.99;
            // outside class we need to create object from student class 
            /* Student stu = new Student();
             stu.name = "Rezzag Lobza Friha";
             stu.age = 26;
             stu.salary = 358887.36;
             */
            Student std1 = new Student();
            std1.AddData("Rezzag Lobza Friha", 24, 250000);

            Student std2 = new Student();
            std2.AddData("Rezzag Lobza Tahar", 24,250000);
            
            Console.WriteLine("-------------------------------------");

            std1.PrintData();
            std2.PrintData();
            // Console.WriteLine(pro.name + "  " + pro.age + "  " + pro.salary);
            // Console.WriteLine("-------------------------------------");
            //Console.WriteLine(stu.name + "  " + stu.age + "  " + stu.salary);

        }
    }
}
