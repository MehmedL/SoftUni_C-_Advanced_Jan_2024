using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Windows.Input;

namespace _05._Applied_Arithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int> function = x => x;
            Action<int[]> print = numbers => Console.WriteLine(string.Join(' ', numbers));

            string command;

            while ((command = Console.ReadLine()).ToLower() != "end")
            {
                if (command.ToLower() == "add")
                {
                    function = x => x + 1;
                    
                }
                else if (command.ToLower() == "multiply")
                {
                    function = x => x * 2;
                }
                else if (command.ToLower() == "subtract")
                {
                    function = x => x - 1;
                }
                else if (command.ToLower() == "print")
                {
                    print(numbers);
                    continue;
                }
                
                numbers = numbers.Select(x => function(x)).ToArray();
            }

            


        }
    }
}
