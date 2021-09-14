using System;

namespace ConditionStateIF
{
    class Program
    {
        static void Main(string[] args)
        {
            //string firstName = "Nadjah";
            Console.WriteLine("Write some thing");
            string firstName = Console.ReadLine();
            // if (firstName=="Nadjah") // comparing the values 
            if (firstName.Equals ("Nadjah",StringComparison.OrdinalIgnoreCase))//comparing the object @adress
            {
                Console.WriteLine("Hellow  Nadjah");

            }
            else if (firstName.Equals("mama", StringComparison.OrdinalIgnoreCase))

            {
                Console.WriteLine("Hellow  Mama");
            }
            else if (firstName.Equals("Abir", StringComparison.OrdinalIgnoreCase))

            {
                Console.WriteLine("Hellow  Abir");
            }
            else
            {
                Console.WriteLine("Not same");

            }
        }
    }
}
