using System;
namespace ConsoleAppExceptionHandlingCheckedUnchecked
{
	public class SalaryExceptioInvalid : Exception
	{
		public SalaryExceptioInvalid(string msg) : base(msg)
		{
		}
	}

	class Program2
	{
		static void verifySalary(double salary)
        {
			if (salary > 3000)
            {
				Console.WriteLine("from catch  verifySalary \n ----------------------------");

				throw new SalaryExceptioInvalid("\n Salary is too hight ");
            }
        }
		/*static void Main(string[] args)
		{
			try
			{
				verifySalary(600000);
			}
            catch(SalaryExceptioInvalid e) {
				Console.WriteLine("from catch \n ----------------------------");
				Console.WriteLine("from catch :" + e+"-------------------");


			}
		}
		*/
	}
}