string word = Console.ReadLine();
Queue<string> queue = new Queue<string>();
while (word.ToLower() != "end")
{
    if(word.ToLower() != "paid")
    {
        queue.Enqueue(word);
    }
    else
    {
        while(queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
    word = Console.ReadLine();
}
Console.WriteLine($"{queue.Count} people remaining.");