using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine().Split(" ")
                                               .Select(double.Parse)
                                               .ToArray();

            Dictionary<double, int> numbers = new Dictionary<double, int>();

            for (int i = 0; i < input.Length; i++)
            {
                double currentNumber = input[i];
                if (!numbers.ContainsKey(input[i]))
                {
                    numbers.Add(currentNumber, 0);
                }
               
                numbers[currentNumber] += 1;
            }

            foreach (var item in numbers.OrderBy(x=>x.Key))
            {

                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
