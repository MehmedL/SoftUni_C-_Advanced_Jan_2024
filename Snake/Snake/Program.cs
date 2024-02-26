using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static int gridSize = 10;
    static char[,] grid = new char[gridSize, gridSize];
    static List<Point> snake;
    static Point food;
    static Direction currentDirection;
    static bool isGameOver = false;

    static void Main()
    {
        InitializeGame();

        while (!isGameOver)
        {
            Console.Clear();
            DrawGame();
            GetUserInput();
            UpdateGame();
            Thread.Sleep(100);
        }

        Console.WriteLine("Game Over! Your score: " + (snake.Count - 1));
        Console.ReadLine();
    }

    static void InitializeGame()
    {
        snake = new List<Point> { new Point(5, 5) };
        currentDirection = Direction.Right;
        GenerateFood();
    }

    static void GenerateFood()
    {
        Random random = new Random();
        int x = random.Next(0, gridSize);
        int y = random.Next(0, gridSize);
        food = new Point(x, y);
    }

    static void DrawGame()
    {
        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                if (snake.Any(p => p.X == i && p.Y == j))
                    Console.Write("O ");
                else if (food.X == i && food.Y == j)
                    Console.Write("F ");
                else
                    Console.Write(". ");
            }
            Console.WriteLine();
        }
    }

    static void GetUserInput()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (currentDirection != Direction.Down)
                        currentDirection = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (currentDirection != Direction.Up)
                        currentDirection = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (currentDirection != Direction.Right)
                        currentDirection = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (currentDirection != Direction.Left)
                        currentDirection = Direction.Right;
                    break;
            }
        }
    }

    static void UpdateGame()
    {
        Point head = snake.First();
        Point newHead = new Point(head.X, head.Y);

        switch (currentDirection)
        {
            case Direction.Up:
                newHead.Y = (newHead.Y - 1 + gridSize) % gridSize;
                break;
            case Direction.Down:
                newHead.Y = (newHead.Y + 1) % gridSize;
                break;
            case Direction.Left:
                newHead.X = (newHead.X - 1 + gridSize) % gridSize;
                break;
            case Direction.Right:
                newHead.X = (newHead.X + 1) % gridSize;
                break;
        }

        snake.Insert(0, newHead);

        if (newHead.Equals(food))
        {
            GenerateFood();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1);
        }

        if (snake.Skip(1).Any(p => p.X == newHead.X && p.Y == newHead.Y))
        {
            isGameOver = true;
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}