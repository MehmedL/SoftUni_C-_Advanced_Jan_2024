int[] input =
    Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

string[] secondLine = Console.ReadLine().Split();

Queue<int> queue = new();

foreach (var line in secondLine)
{
    int temp = int.Parse(line);
    queue.Enqueue(temp);
}

for (int i = 0; i < input[1]; i++)
{
    queue.Dequeue();
}

if (queue.Contains(input[2]))
{
    Console.WriteLine("true");
}
else if (queue.Any())
{
    Console.WriteLine(queue.Min());
}
else
{
    Console.WriteLine(0);
}