int[] numbersPerSet = Console.ReadLine()
    .Split(' ' , StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

HashSet<int> numbers1 = new HashSet<int>();
HashSet<int> numbers2 = new HashSet<int>();

for (int i = 0; i < numbersPerSet[0]; i++)
{
    int n = int.Parse(Console.ReadLine());
    numbers1.Add(n);
}

for (int i = 0;i < numbersPerSet[1];i++)
{
    int n = int.Parse(Console.ReadLine());
    numbers2.Add(n);
}
foreach (int i in numbers1)
{
    if (numbers2.Contains(i))
    {
        Console.Write($"{i} ");
    }
}
