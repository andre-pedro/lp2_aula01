using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello, World!");

            Cat c1 = new Cat("Randall",Mood.Grumpy,Feed.Starving);
            Cat c2 = new Cat("Meowth",Mood.Hyperactive,Feed.Satisfied);
            Cat c3 = new Cat("Timon");

            Console.WriteLine(c1.GetName() + c2.GetName() + c3.GetName());
            Console.WriteLine(c1.GetName());
            Console.WriteLine(c2.GetName());
            Console.WriteLine(c3.GetName());
        }
    }
}
