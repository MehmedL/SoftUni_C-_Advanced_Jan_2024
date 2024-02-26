using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._List_Of_Predicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimet = int.Parse(Console.ReadLine());

            int[] dividirs = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>(); 

            for (int i = 1; i <= upperLimet; i++)
            {
                numbers.Add(i);
            }

            Func<int[], int, bool> predicate = (arr, i) =>
            {
                bool isDivisible = true;
                foreach (int n in dividirs)
                {
                    if (i % n != 0)
                    {
                        return false;
                    }
                }

                return isDivisible;
            };

            var resutl = numbers
                .Where(number => predicate(dividirs, number));

            Console.WriteLine(string.Join(' ', resutl));

                


        }
    }
}
