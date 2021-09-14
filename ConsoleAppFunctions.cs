using System;

namespace ConsoleAppFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            // create object of the class program  name first 
            Program program = new Program();
            // this method folow the new object 
            program.HellowName("Nadjah");
            // WE can call this function without creat object 
            FamilyName("rezzag lobza");

            Console.WriteLine("---------------------");
            string fullName= program.HellowNameR("Abir");
            string secondName = SecondNameR(" Rezzag  ");
            int Myage = age(22);
            Console.WriteLine("Hellow "+ fullName);
            Console.WriteLine("Hellow  " + secondName);
            Console.WriteLine("My age :  " + Myage);



        }

        //functions with no return 
        // function with no parameter and with no return 
        //static mean own to main class Program not for object 
        void HellowName(string name)
        {
            Console.WriteLine("Hello : "+name);

        }
        // function of the main class program 
        static void FamilyName(string Fname)
        {
            Console.WriteLine("hellow !"+ Fname);

        }
        // functions with returns
        string HellowNameR(string name)
        {
            return name;
        }
        //return type is string 
        static string SecondNameR(string Fname)
        {
            return Fname;
        }
        static int age(int age)
        {
            return age;
        }
    }
}
