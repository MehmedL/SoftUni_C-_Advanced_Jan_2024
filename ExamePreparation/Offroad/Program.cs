
using System;
using System.Collections.Generic;
using System.Linq;

namespace Offroad
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> initalFuel =
            new Stack<int>(Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> aditionalFuel = 
            new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> neededFuel =
            new Queue<int>(Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int level = 1;

            bool didNotReacht = false;

            while(initalFuel.Count > 0)
            {
                int initionalFuel1 = initalFuel.Pop();
                int aditionalFuel1 = aditionalFuel.Dequeue();
                int neededFuel1 = neededFuel.Dequeue();

                int actualFuel = initionalFuel1 - aditionalFuel1;
                if(actualFuel >= neededFuel1)
                {
                    Console.WriteLine($"John has reached: Altitude {level++}");
                }
                else
                {
                    Console.WriteLine($"John did not reach: Altitude {level--}");

                    didNotReacht = true;
                    break;
                }
            }

            if(didNotReacht)
            {
                Console.WriteLine("John failed to reach the top.");
                if (level == 0)
                {
                    //Console.WriteLine("John didn`t reach any altitude.");
                    Console.WriteLine("John didn't reach any altitude.");
                }
                else
                {
                    Console.Write($"Reached altitudes: ");

                    for (int i = 0; i < level; i++)
                    {
                        Console.Write($"Altitude {i + 1}");
                        if (i < level - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
            }

        }
    }
}
