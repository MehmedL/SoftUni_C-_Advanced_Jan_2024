string[] input = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

Action<string> line = n => Console.WriteLine($"Sir {n}");

Array.ForEach(input, line);