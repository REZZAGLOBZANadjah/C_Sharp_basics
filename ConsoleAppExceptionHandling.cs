using System;

namespace ConsoleAppExceptionHandling
{
    // user User Defined Exceptions
    public class SalaryExceptioInvalid : Exception
    {
        public SalaryExceptioInvalid(string msg) : base(msg)
        {
        }
    }

    class Program
    {

        static void verifySalary(double salary)
        {
            if (salary > 3000)
            {
                Console.WriteLine("from catch  verifySalary \n ----------------------------");

                throw new SalaryExceptioInvalid("\n Salary is too hight ");
            }
        }
        static void Main(string[] args)
        {//using try catch to handeling errurs to can contenue pgm execution 
            try
            {// 
                int num1 = 10;
                //int num2=10; 
                  int num2=0;
                int sum = num1 / num2;
                Console.WriteLine("Sum !" + sum);

            }
            catch(Exception e)
            {// print erreur
                Console.WriteLine("can not divide by zero !");

                Console.WriteLine("catch err !" + e);

            }
            finally
            {
                Console.WriteLine("finaly  can run !");

            }
            Console.WriteLine("----------------hellow najah-----------------");

            //----------------------------------------

            //User Defined Exceptions 
            try
            {
                verifySalary(200000);
            }
            catch (SalaryExceptioInvalid e)
            {
                Console.WriteLine("from catch \n ----------------------------");
                Console.WriteLine("from catch :" + e + "-------------------");


            }










        }
    }
}
