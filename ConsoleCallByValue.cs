using System;

namespace ConsoleFuncCallByValue
{
    class Program
    {
        // properties of class program  (Global Variable)
        static int myAge = 29;

        //Functions call by value 
       static  void MyData(int num)
        {
            num -= num;
            Console.WriteLine("inside function Minus : = "+num);
        }
        // Functions call by reference 
        static void MyDataRef(ref int num)
        {
            num += num;
            Console.WriteLine("inside function Sum : = " + num);

        }
        // function with out parameter
        static void MyResultOut(out int num)
        {
            int num2 = 10;// local  Variable in this function
            num = num2;
            num *= num; //num*num
            Console.WriteLine("inside function multiplication : = " + num);
        }
        //

        static void Main(string[] args)
        {
            int orginalNum = 20;
            Console.WriteLine("outside function MyData  :" + orginalNum);
            MyData(orginalNum);
            Console.WriteLine("outside function MyData :" + orginalNum);
            
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("outside function MyDataRef  :" + orginalNum);
            MyDataRef(ref orginalNum);
            Console.WriteLine("outside function MyDataRef :" + orginalNum);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("outside function MyResultOut  :" + orginalNum);
            MyResultOut(out orginalNum);
            Console.WriteLine("outside function MyResultOut  :" + orginalNum);
           
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("My age "+myAge);
        }
    }
}
