using System;

namespace ConsoleForeachLoop
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] myFavColor = { "red", "blue", "green" ,"white","yellow", "silver","black"};
            // foreach loop 
            foreach (var color in myFavColor)
            {
               /*  if (color == "green")
                { //using break point  to stop the program
                    break; 
                }
                Console.WriteLine("My favorite color is :" + color);
              /*/
                if (color == "yellow")
                {//using continue statement to ignore some values in this ex "blue" and contenue the execution
                    continue;
                }
                Console.WriteLine("My favorite color is :" + color);
              
            }
            {
                
            }

        }
    }
}
