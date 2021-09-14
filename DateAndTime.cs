using System;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = new DateTime(2021,09,10);
            DateTime myToday = DateTime.Now;

            Console.WriteLine("Date is "+ myDate.ToString("M/d/yyyy"));
            Console.WriteLine("Date is " + myToday.ToString("MMMM d/yyyy"));

        }
    }
}
