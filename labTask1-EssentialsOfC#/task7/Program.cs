using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter rate of work hours for worker {i+1} ");
                double rate = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Enter number of work hours for worker {i+1} ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                if(num1 > 40)
                {
                    Console.WriteLine($"Wage for worker {i+1} is {40*rate + (num1-40)*rate*1.5}");
                }
                else
                {
                    Console.WriteLine($"Wage for worker {i+1} is {num1 * rate}");
                }
            
            }
        }
    }
}
