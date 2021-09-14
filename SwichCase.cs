using System;

namespace SwichCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorit color");
            //string myColor = "blue";
            string myColor = Console.ReadLine();
            switch(myColor)
            {
                case "red":
                    Console.WriteLine("red");
                    break;
                case "blue":
                    Console.WriteLine("blue");
                    break;
                case "white":
                    Console.WriteLine("white");
                    break;
                case "black":
                    Console.WriteLine("black");
                    break;
                default:
                    Console.WriteLine("No color");
                    break;
            }
        }
    }
}
