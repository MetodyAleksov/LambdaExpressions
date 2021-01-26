using System;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string, int> parses = n => int.Parse(n);

            int[] numbers = input
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(parses)
                .ToArray();

            Console.WriteLine(numbers.Length);
            Console.WriteLine(numbers.Sum());
        }
    }
}
