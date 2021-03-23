using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[5];
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine($"Enter entry {i+1} ");
                arr[i] = Convert.ToDouble(Console.ReadLine()); 
            }
            Array.Sort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine($"{item} ");
            }
            
        }
    }
}
