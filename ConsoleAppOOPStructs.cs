using System;

namespace ConsoleAppOOPStructs
{struct Result
    {
        public int num1;
        public int num2;
        public Result(int n1,int n2)
        {
                num1 = n1;
                num2 = n2;
        }
        public void PrintInfo()
        {
            //int sum;
            //sum = num1 + num2;
            //Console.WriteLine("Sum is : ", +sum);
            Console.WriteLine("Sum is : ", +(num1+num2));

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Result res1 = new Result(20,50) ;
            //res.num1 = 10;
            //res.num2 = 20;
            res1.PrintInfo();
            //Console.WriteLine("in main Sum is : "+(res.num1+res.num2));
        }
    }
}
