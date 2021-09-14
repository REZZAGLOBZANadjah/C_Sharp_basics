using System;

namespace ConsoleAppOOPMethodOverloading
{
    class MathMatic{
        public static int Add(int x,int y)
        {
            return x + y;
        }
        //Method add Overloading has 3 arguments not 2 arguments
        public static int  Add(int x, int y,int z)
        {
            return x + y+z;
        }
        // change data type in  Method add Overloading
        public static double Add(double x, double y, double z)
        {
            return x + y + z;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* // to run this remouve static form Add methods 
             * MathMatic maty = new MathMatic();
             Console.WriteLine(
                 "The results: "+
                 maty.Add(10,20)+"\n"+
                 maty.Add(40,50,60));
            */
            // if the functions is static we do not need to create object 

            Console.WriteLine(
                 "The results: " +
                 MathMatic.Add(10, 20) + "\n" +
                 MathMatic.Add(40, 50, 60)+"\n"+
                 MathMatic.Add(40.5, 50.5, 60.5));
        }
    }
}
