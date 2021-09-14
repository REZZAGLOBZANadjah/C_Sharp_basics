using System;
namespace Nadjah
{
    class Person
    {
        public string fullName = " Nadjah ";

       public void PrintInfo(string lastName)
        {
            Console.WriteLine("Hello "+ fullName+""+ lastName);
        }

    }

}
namespace ConsoleAppAccessModifiers
{
    class Student
    {
        public string fullName = " Nadjah ";
        protected int age = 29;
        protected void PrintAge(int age)
        {
            Console.WriteLine("your age is " + age);
        }
        public void PrintInfo(string lastName)
        {
            Console.WriteLine("Hello " + fullName + "" + lastName);
        }
    }
    class Program :Student
    {
        private int myAge = 26;
        private void myPrintAge(int age)
        {
            Console.WriteLine("my age is " + age);
        }
        static void Main(string[] args)
        {
            // public
           /*
            * Nadjah.Person per =new Nadjah.Person();
            Console.WriteLine("Hello " + per.fullName );
            per.PrintInfo("Rezza lobza");
           */
            // protected
            /*
                        // Student std = new Student();
                        Program std = new Program();// program is child class should herit fromStuden class to can access to all methods and fields
                        std.PrintAge(29);
                        Console.WriteLine("age  " + std.age);// protected member age can not acces to this attribut

            */
            // private
            Program std = new Program();
            Console.WriteLine("my age  " + std.myAge);
            std.myPrintAge(29);

        }
    }
}
