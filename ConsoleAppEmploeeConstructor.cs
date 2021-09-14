using System;

namespace ConsoleAppEmploeeCon
{
    class Person
    {
        string name;
        int age;
        string city;
        public Person(string n,int a ,string c)
        {
            name =n;
            age =a;
            city =c;
            //Console.WriteLine("Hello from Person constructor!");
        }
        public void PrintInfo()
        {
            Console.WriteLine("Your name is :"+name+" \n age :"+age+" \n city:"+city);
        }
    }

    class Program
    {
        public Program()
        {
            Console.WriteLine("Hello from constructor!");

        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            Program pro1 = new Program();

            Person prsn = new Person("muhammmed",34,"Eloued");
            //Person prsn2 = new Person("ali",13,"batna");
            prsn.PrintInfo();



        }

    }
}
