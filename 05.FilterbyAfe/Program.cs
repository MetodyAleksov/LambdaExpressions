using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FilterbyAfe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                people.Add(arr[0], int.Parse(arr[1]));
            }

            string cond = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            if (cond == "older")
            {
                Printer(format, new Dictionary<string, int>(people.Where(x => x.Value >= age)));
            }
            else if (cond == "younger")
            {
                Printer(format, new Dictionary<string, int>(people.Where(x => x.Value <  age)));
            }


        }
        static void Printer(string format, Dictionary<string, int> people)
        {
            if (format == "name age")
            {
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
            else if (format == "name")
            {
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Key}");
                }
            }
            else if (format == "age")
            {
                foreach (var item in people)
                {
                    Console.WriteLine($"{item.Value}");
                }
            }
        }
    }

}
