using System;

namespace ConsoleAppMultidimensional_Arrays
{
    class Program
    {

        static void Main(string[] args)
        {
            int[,] array2D = new int[3, 3];//2 dimension array
            //int[,,] array3D = new int[3, 3,3];//3 dimension array
            array2D[0, 1] = 10;
            array2D[1, 2] = 20;
            array2D[2, 0] = 30;
            Console.WriteLine("array2D ");

            for (int i=0; i < 3;i++)
            {

                for (int j=0;j< 3;j++)
                {
                    Console.Write(array2D[i , j]+",");

                }

                Console.WriteLine( );


            }
            //-----------------------------------------------------------------
            Console.WriteLine("------------------------------------------");

            int[,] array2D2 = { { 1, 2, 3 }, 
                                { 4, 5, 6 },
                                { 7, 8, 9 } };
            Console.WriteLine("array2D2 {");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array2D2[i, j] );
                    if (i<3)
                    {
                        Console.Write(",");
                    }

                }
                Console.WriteLine("},");


            }
            Console.Write("}");
        }
    }
}
