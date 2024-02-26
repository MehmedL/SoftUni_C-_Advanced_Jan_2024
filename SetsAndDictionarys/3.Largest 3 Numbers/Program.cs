int[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

int[] sorted = numbers.OrderDescending().ToArray(); 

