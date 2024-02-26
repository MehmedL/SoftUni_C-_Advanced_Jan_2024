using System;
using System.Collections.Generic;
using System.Linq;

namespace StartUp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < lines; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            int[] indexIs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            GenericSwap(list, indexIs[0], indexIs[1]);

            foreach (var i in list)
            {
                Console.WriteLine($"{i.GetType()}: {i}");
            }
        }
        static void GenericSwap<T>(List<T> items, int firstIndex, int secondIndex)
        {
            T tamp = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tamp;
        }
    }
}

