string[] songs = Console.ReadLine()
    .Split(", ")
    .ToArray();

Queue<string> queue = new Queue<string>(songs);

while(queue.Any())
{
    string[] s = Console.ReadLine() 
        .Split()
        .ToArray();
    if (s[0].ToLower() == "play")
    {
        queue.Dequeue();
    }
    else if (s[0].ToLower() == "show")
    {
        Console.WriteLine(string.Join(", ",queue));
    }
    else if (s[0].ToLower() == "add")
    {
        string songName = string.Join(" ",s.Skip(1));

        if (queue.Contains(songName))
        {
            Console.WriteLine($"{songName} is already contained!");
        }
        else
        {
            queue.Enqueue(songName);
        }
    }
}
Console.WriteLine("No more songs!") ;

