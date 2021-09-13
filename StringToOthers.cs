using System;

namespace StringToOthers
{
    class Program
    {
        static void Main(string[] args)
        {
            string age = "29";
            string salary = "960000,45";
            //string salary = "960000.45";

            int myAge = int.Parse(age);
            double mySalary;
            if (double.TryParse(salary, out mySalary))
            {
                Console.WriteLine("mySalary" + mySalary + mySalary.GetType());
            }
            else
            {
                Console.WriteLine("Con not converted" );

            }

            Console.WriteLine("age"+age + age.GetType());
            Console.WriteLine("myage" + myAge+ myAge.GetType());
            Console.WriteLine("--------------------");
            Console.WriteLine("salary" + salary + salary.GetType());


        }
    }
}
