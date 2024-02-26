using System;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> predicat = i => i % divisor != 0;

            var result = input 
                .Where(number => predicat(number))
                .ToArray();

            Console.WriteLine(string.Join(' ',result.Reverse()));

        }
    }
}
