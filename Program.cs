using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "    Rezzag    Lobza";
            string secondName = "Nadjah";
            //string secondName = firstName+"Nadjah";

            
            //string fullName = "    Rezzag Lobza Nadjah   ";
            string fullName = firstName + secondName;
            Console.WriteLine("your name in lower  is "+ fullName.ToLower());
            Console.WriteLine("your name  with no spaces inthe begining is " + fullName.Trim());
            Console.WriteLine("your firstName is " + firstName);
            Console.WriteLine("your secondName is " + secondName);

            Console.WriteLine("your fullName is " + fullName);



        }
    }
}
