int[] number = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(n => int.Parse(n))
    .Where(n => n % 2 == 0)
    .OrderBy(n => n)
    .ToArray();

Console.WriteLine(string.Join(", ", number));