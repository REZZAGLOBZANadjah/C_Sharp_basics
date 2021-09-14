using System;

namespace ThisKeyword
{class Person
    {//atributes ,members
        public string name;
        public int age;
        public string city;
        public string country;

        public Person(string name, int age, string city, string country)
        {
            this.name = name;
            this.age = age; 
            this.city = city; 
            this.country = country;

        }
        public void ShowInfo()
        {
            Console.WriteLine(" name :"+ name + "\n age :"+age+ "\n city :"+ city+ "\n country" + country);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Nadjah",29,"Eloued","ALGERIA");
            p.ShowInfo();
        }
    }
}
