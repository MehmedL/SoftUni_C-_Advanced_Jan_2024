int n = int.Parse(Console.ReadLine());

SortedSet<string> result = new SortedSet<string>();

for (int i = 0; i < n; i++)
{
    string[] form = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .ToArray();
    foreach (string s in form)
    {
        result.Add(s);
    }
    
}
Console.WriteLine();
foreach(string s in result)
{
    Console.Write($"{s} ");
}