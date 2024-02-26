using System;
using System.Security;

namespace FishingCompetition
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n,n];
            int currentRow = 0;
            int currentCol = 0;
            int caughtFish = 0;
            

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int cow = 0; cow < n; cow++)
                {
                    matrix[row, cow] = line[cow];
                }
            }
            
            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int cow = 0; cow < n; cow++)
                {
                    if (matrix[row, cow] == 'S')
                    {
                        currentRow = row;
                        currentCol = cow;
                        break;
                    }

                }
            }
            string comand;
            while ((comand = Console.ReadLine()).ToLower() != "collect the nets")
            {
                matrix[currentRow, currentCol] = '-';
                Direction direction = (Direction)Enum.Parse(typeof(Direction), comand);
                switch (direction)
                {
                    case Direction.down:
                        currentRow++;
                        if (currentRow >= n)
                        {
                            currentRow = 0;
                        }
                        break;
                        case Direction.up:
                        currentRow--;
                        if (currentRow < 0)
                        {
                            currentRow = n - 1;
                        }
                        break;
                        case Direction.left:
                        currentCol--;
                        if (currentCol < 0)
                        {
                            currentCol = n - 1;
                        }
                        break;
                        case Direction.right:
                        currentCol++;
                        if (currentCol >= n)
                        {
                            currentCol = 0;
                        }
                        break;

                }
                if (matrix[currentRow,currentCol] != '-')
                {
                    if (matrix[currentRow, currentCol] == 'W')
                    {
                        Console.WriteLine($"You fell into a whirlpool! " +
                            $"The ship sank and you lost the fish you caught." +
                            $"Last coordinates of the ship: [{currentRow},{currentCol}]");
                        return;
                    }
                    else
                    {
                        caughtFish += int.Parse(matrix[currentRow, currentCol].ToString());
                    }
                }
                matrix[currentRow, currentCol] = 'S';
            }
            if(caughtFish < 20)
            {
                Console.WriteLine($"You didn't catch enough " +
                    $"fish and didn't reach the quota! You need {20 - caughtFish} tons of fish more.");
            }
            else
            {
                Console.WriteLine("Success! You managed to reach the quota!");
                
            }
            Console.WriteLine($"Amount of fish caught: {caughtFish} tons.");

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
        enum Direction
        {
            down,
            up,
            left,
            right
        }
        
        //public static void ReadMatrix<T>(T[,] matrix, Action<T> print)
        //{
        //    for (int row = 0; row < matrix.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < matrix.GetLength(1); col++)
        //        {
        //            print(matrix[row, col]);
        //            //Console.Write(matrix[row,col]);
        //        }
        //        Console.WriteLine();
        //    }
        //}
    }
}
