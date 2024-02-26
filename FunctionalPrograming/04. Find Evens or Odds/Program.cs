using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _04._Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int startingNumber = bounds[0];
            int endingNumber = bounds[1];
            string criteria = Console.ReadLine();
            
            List<int> numbers = new List<int>();

            for (int i = startingNumber; i <= endingNumber; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicat = i => true;

            if (criteria.ToLower() == "even")
            {
                predicat = i => i % 2 == 0;
            }
            else if (criteria.ToLower() == "odd")
            {
                predicat = i => i % 2 != 0;
            }

            var filterNumbers = numbers
                .Where(new Func<int,bool>(predicat))
                .ToArray();

            Console.WriteLine(string.Join(' ', filterNumbers));
        }
    }
}
