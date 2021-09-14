using System;
using Nadjah; //using namespace Nadjah
using Rezzag; //using namespace Rezzag

namespace Nadjah
{
class PersonN
    {
        public void PrintInfo()
        {
            Console.WriteLine("namespace Nadjah!");

        }
    }
}
namespace Rezzag
{
    class PersonR
    {
        public void PrintInfo()
        {
            Console.WriteLine("namespace Rezzag!");

        }
    }
}

namespace ConsoleAppOOPNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // if we use the same name of c2 classes in 2 defent namespaces 
            //Nadjah.Person nper = new Nadjah.Person();
            //Rezzag.Person rper = new Rezzag.Person();
           // if we use using keyword 
            PersonN  nper = new Nadjah.PersonN();
            PersonR rper = new Rezzag.PersonR();
            nper.PrintInfo();
            rper.PrintInfo();
        }
    }
}
