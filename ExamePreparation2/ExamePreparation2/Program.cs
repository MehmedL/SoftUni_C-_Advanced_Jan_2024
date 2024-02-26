using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamePreparation2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Queue
            int[] toolsArray = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> tools = new Queue<int>(toolsArray);

            //Creat stack
            int[] subsArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> substance = new Stack<int>(subsArray);

            //Create list
            List<int> chalenges = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                int result = tools.Peek() * substance.Peek();
                if (chalenges.Contains(result))
                {
                    tools.Dequeue();
                    substance.Pop();
                    chalenges.Remove(result);
                    if (chalenges.Count == 0)
                    {
                        Console.WriteLine("Harry found an ostracon, which is dated to the 6th century BCE.");
                        break; 
                    }
                }
                else
                {
                    //no chalage resolved
                    int temp = tools.Dequeue();
                    temp++;
                    tools.Enqueue(temp);
                    substance.Push(substance.Pop() - 1);
                    //substance removing if its empty
                    if(substance.Peek() == 0)
                    {
                        substance.Pop();
                    }
                    if (substance.Count == 0 || tools.Count == 0)
                    {
                        if (chalenges.Count > 0)
                        {
                            Console.WriteLine("Harry is lost in the temple. Oblivion awaits him.");
                            break;
                        }
                    }
                    
                }


            }
            if (tools.Any())
            Console.WriteLine($"Tools: {string.Join(", ", tools)}");
            if (substance.Any())
            Console.WriteLine($"Substances: {string.Join(", ", substance)}");
            if (chalenges.Any())
            Console.WriteLine($"Challenges: {string.Join(", ", chalenges)}");
        }
    }
}
