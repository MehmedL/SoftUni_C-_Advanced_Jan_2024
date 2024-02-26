using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> predicate = s => s.Length <= length;

            var result = names.Where(name => predicate(name));
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
