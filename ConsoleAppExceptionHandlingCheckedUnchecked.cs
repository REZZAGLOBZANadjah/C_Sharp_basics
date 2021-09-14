using System;

namespace ConsoleAppExceptionHandlingCheckedUnchecked
{
    //public class SalaryExceptionInvalid
    class Program
    {
        static void Main(string[] args)
        {
            //  checked and  unchecked for arthmetic operations  if values is oveload 

            checked
               // unchecked
            {
                int num = int.MaxValue;
                int sum = num + 100;//Arithmetic operation resulted in an overflow.
                Console.WriteLine("sum!" + sum);
            }
            

        }
    }
}
