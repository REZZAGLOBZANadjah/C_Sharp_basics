using System;

namespace ForLooupConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Hello Nadjah!" + i);

            }
            //this array of family members names
            string[] myFamily = { "mama", "tedjani", "najah", "abir", "tahar","muhammed" };
            for (int i = 0; i< myFamily.Length; i++)
            {
                Console.WriteLine("Family member name!" + i+ "....."+ myFamily[i]);

            }
            /*
      * write your comment lines here
      * 
      * */
        }
    }
}
