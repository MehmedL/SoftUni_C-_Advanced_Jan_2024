int food = int.Parse(Console.ReadLine());

int[] orders = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

Queue<int> queue = new Queue<int>(orders);

if (queue.Any())
{
    Console.WriteLine(queue.Max());
}
while (queue.Any())
{ 
    if (food >= queue.Peek())
    {
        food -= queue.Dequeue();
        }
    else
    {
        Console.WriteLine($"Orders left: " + string.Join(' ', queue));
        return;
    }

}
Console.WriteLine("Orders complete");


