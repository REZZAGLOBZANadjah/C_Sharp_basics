using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;
            int sum = num1 + num2;
            Console.WriteLine("num1 = " + num1 +"  \t num2 = " +num2);

            Console.WriteLine("Add ="+sum);
            Console.WriteLine("Sub ="+(num1-num2));
            Console.WriteLine("Mult ="+(num1*num2));
            Console.WriteLine("Div ="+(num1/num2));
            Console.WriteLine("Mod ="+(num1%num2));

        }
    }
}
