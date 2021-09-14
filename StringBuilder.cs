using System;
using System.Text;

namespace StringBuilderNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Rezzag Lobza";
            string secondName = "Nadjah";
            StringBuilder sb = new StringBuilder();
            sb.Append("Rezzag Lobza")
            .Append(" Nadjah")
            .Append(" Nadjah")
            .Append(" Nadjah")
            .Append(" Nadjah");
            Console.WriteLine(sb.ToString());
        }
    }
}
