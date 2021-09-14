using System;

namespace ConsoleAppOOPInheritance
{ class Animal
    {
        public int age = 12;
        public void Eating()
        {
            Console.WriteLine("Eating......");
        }
    }
    class Dog : Animal // dog class herit attribute from class Animal
    {
        public string name = "Dog";
        public void Walk()
        {
            Console.WriteLine("Walking.......");
        }
    }
    // class cat Multi Level Inheritance from class dog and class animal 
    class Cat :Dog{
        public void Sleep()
        {
            Console.WriteLine("Sleep.......");
        }
    }
    class Program
    {
      
        
        static void Main(string[] args)
        {
            Dog dog = new Dog();// create new object of class Dog
            dog.Eating();
            dog.Walk();//Inherit walk function from class Dog
            Console.WriteLine("Dog information "+dog.age +" "+ dog.name);

            Cat cat = new Cat();
            cat.Eating();
            cat.Walk();
            cat.Sleep();
        }
    }
}
