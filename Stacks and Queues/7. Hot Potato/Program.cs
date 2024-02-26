List<string> words = Console.ReadLine().Split().ToList();
Queue<string> childrens = new Queue<string>(words);
int steps = int.Parse(Console.ReadLine());

int start = 1;
while (childrens.Count != 1 )
{
    string children = childrens.Dequeue();
    if (start == steps)
    {
        Console.WriteLine($"Removed {children}");
        start = 0;
    }
    else
    {
        childrens.Enqueue(children);
    }
    start++;
}
Console.WriteLine($"Last is {childrens.Peek()}");
