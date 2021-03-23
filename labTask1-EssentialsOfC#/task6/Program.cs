using System;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter entry 1 ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter entry 2 ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter number for operation based on the following\n1.Addition 2.Subtraction 3.Division 4. Multiplication 5. Increment and 6. Decrement ");
            double oper = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine($"{num1}, {num2} and {oper}");
            switch (oper)
            {   case 1:
                    Console.WriteLine($"{num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"{num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"{num1 / num2}");
                    break;
                case 4:
                    Console.WriteLine($"{num1 * num2}");
                    break;
                case 5:
                    Console.WriteLine($"{num1+1} {num2+1}");
                    break;
                case 6:
                    Console.WriteLine($"{num1 -1} {num2-1}");
                    break;
                default:
                    break;
            } 
        }
    }
}
