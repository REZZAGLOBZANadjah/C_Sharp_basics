using System;

namespace ConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {//declar new array of 5 elements 
            int[] myArray = new int[5];
            myArray[0] = 30;
            myArray[1] = 40;
            myArray[2] = 50;
            myArray[3] = 60;
            myArray[4] = 70;
            //myArray[5] = 1000; System.IndexOutOfRangeException : 'Index was outside the bounds of the array.'
            //print Araay elements using for loop
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine("myArray["+i +"]= "+myArray[i]);
            }
            Console.WriteLine("-----------------------------------");
            //other way to decalar array
            int[] myArray2 = new int[5] { 80, 90, 100, 110, 120 };
            for (int i = 0; i < myArray2.Length; i++)
            {
                Console.WriteLine("myArray2[" + i + "]= " + myArray2[i]);
            }
            Console.WriteLine("-----------------------------------");

            //----------------------------------------------------------
            int[] numbers = { 10, 20, 30, 40, 50, 60 };
            Console.Write("numbers={");
            foreach (var i in numbers)
            {
                Console.Write(i+",");
            }
            Console.WriteLine("}");

            //
            string[] names = {"ourida ","najah", "abir","aycha","layan"};
           /* 
            * foreach (var name in names)
            {
                Console.WriteLine(name);
            }
      
            */
            Console.WriteLine(" names Length = " + names.Length);
            Mynames(names);
        }
        static void Mynames(string [] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
