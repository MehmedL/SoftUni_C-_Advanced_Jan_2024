using System;

class Program
{
    static void Main()
    {
        // Read dimensions
        string[] dimensions = Console.ReadLine().Split(",");
        int rows = int.Parse(dimensions[0]);
        int cols = int.Parse(dimensions[1]);

        // Read matrix
        char[,] matrix = new char[rows, cols];
        int mouseRow = -1, mouseCol = -1;

        for (int i = 0; i < rows; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = row[j];
                if (row[j] == 'M')
                {
                    mouseRow = i;
                    mouseCol = j;
                }
            }
        }

        // Mouse movement
        while (true)
        {
            string direction = Console.ReadLine();

            if (direction == "danger")
            {
                Console.WriteLine("Mouse will come back later!");
                break;
            }

            mouseRow = MoveMouse(matrix, direction, mouseRow, mouseCol);

            if (mouseRow == -1)
                break;

            if (CountCheese(matrix) == 0)
            {
                Console.WriteLine("Happy mouse! All the cheese is eaten, good night!");
                break;
            }
        }

        // Print final state
        PrintMatrix(matrix);
    }

    static int MoveMouse(char[,] matrix, string direction, int row, int col)
    {
        int newRow = row, newCol = col;

        switch (direction)
        {
            case "up":
                newRow--;
                break;
            case "down":
                newRow++;
                break;
            case "left":
                newCol--;
                break;
            case "right":
                newCol++;
                break;
        }

        if (IsWithinBounds(matrix, newRow, newCol))
        {
            char newPosition = matrix[newRow, newCol];

            if (newPosition == 'C')
            {
                matrix[newRow, newCol] = '*';
            }
            else if (newPosition == 'T')
            {
                Console.WriteLine("Mouse is trapped!");
                return -1;
            }
            else if (newPosition == '@')
            {
                // Hit a wall, do nothing
                return row;
            }

            matrix[row, col] = '*';
            matrix[newRow, newCol] = 'M';

            return newRow;
        }
        else
        {
            Console.WriteLine("No more cheese for tonight!");
            return -1;
        }
    }

    static bool IsWithinBounds(char[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }

    static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static int CountCheese(char[,] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 'C')
                {
                    count++;
                }
            }
        }

        return count;
    }
}
