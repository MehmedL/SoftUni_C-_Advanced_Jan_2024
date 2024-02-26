using System.Data;

List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

Stack<int> stack = new Stack<int>(numbers);

string comand = Console.ReadLine().ToLower();

while (comand != "end")
{
    string[] splitted = comand.Split(' ');
    int first = int.Parse(splitted[1]);
    if (splitted[0] == "add")
    {
        int second = int.Parse(splitted[2]);

        stack.Push(first);
        stack.Push(second);
    }
    else
    {
        if (stack.Count >= first)
        {
            for (int i = 0; i < first; i++)
            {
                stack.Pop();
            }
        }
    }
    comand = Console.ReadLine().ToLower();
}

Console.WriteLine($"Sum: {stack.Sum()}");