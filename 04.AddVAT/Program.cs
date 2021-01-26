﻿using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vater = x => (double)(x + (x * 0.2));

            double[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(vater)
                .ToArray();

            foreach (var item in input)
            {
                Console.WriteLine($"{item:f2}");
            }
        }
    }
}
