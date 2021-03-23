using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Your name is {name} and age is {age} ");
        }
    }
}
