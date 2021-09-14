using System;

namespace ConsoleAppAggregation
{
    class Adress
    {
        public string streetName;
        public string city;
        public int streetNo;
        public string email;
        public Adress(string streetName, string city, int streetNo, string email)
        {
            this.streetName = streetName;
            this.city = city;
            this.streetNo = streetNo;
            this.email = email;
        }
    }
    class Student
    {
        public string name;
        public int age;
        public string country;
        public Adress adress;
        /*// we can agregate this field in one class adress and we can use it in other classes  
         * public string streetName;
         public string city;
         public int streetNo;
         public string email;
        **/
        public Student(string name, int age, string country, Adress adress)
        {
            this.name = name;
            this.age = age;
            this.country = country;
            this.adress = adress;
        }
        public void PrintInfo()
        {
            Console.WriteLine(
                "\n name :"+ name+ 
                "\n age :"+ age+
                "\n country :"+ country+
                "\n city :"+ adress.city+
                "\n streetNo : "+ adress.streetNo +
                "\n email :"+adress.email);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Adress addr = new Adress("Muhammed khemisti","Eloued",148,"Rezzaglobza7@gmail.com");
            Student std = new Student("Rezzag lobza Nadjah",29,"ALGERIA", addr);
            std.PrintInfo();
        }
    }
}
