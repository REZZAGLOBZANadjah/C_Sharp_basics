using System;

namespace ConsoleAppSystemExceptionclass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double[] myArray = new double[3];
                myArray[0] = 12;
                myArray[1] = 13;
                myArray[2] = 14;
                myArray[12] = 0;//System.IndexOutOfRangeException: Index was outside the bounds of the array.


            }
            catch (SystemException e)
            {
                Console.WriteLine("----------------\n"+e);
            }

        }

    }
}
