using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            long ageL = 22L;
            Double salary = 1278.87;
            float f = 1000.58f;
            decimal d = 3_000.05m;
            byte nbyte = 255;
            var ageVar = 20L;//le type est variable selon le valeur 
           
            char mychar = 'N';
            char mychar2 = '\u006A';
            char mychar3 = '$';
            
            Console.WriteLine("your age is:" + age + "...." + age.GetType());
            Console.WriteLine("your age long is:" + ageL + "...." + ageL.GetType());
            Console.WriteLine("your salary is:" + salary);
            Console.WriteLine("your f is:" + f);
            Console.WriteLine("your d is:" + d);
            Console.WriteLine("your myage is:" + ageVar + "...." + ageVar.GetType());

            Console.WriteLine("your mychar is:" + mychar + "...." + mychar.GetType());
            Console.WriteLine("your mychar2 is:" + mychar2 + "....." + mychar2.GetType());
            Console.WriteLine("your mychar3 is:" + mychar3 + "....." + mychar3.GetType() + "\n" + char.IsLetterOrDigit(mychar3));

        }
    }
}
