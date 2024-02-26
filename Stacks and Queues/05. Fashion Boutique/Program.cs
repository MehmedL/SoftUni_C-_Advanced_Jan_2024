int[] cloats = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

Stack<int> stack = new Stack<int>(cloats);

int racksCap = int.Parse(Console.ReadLine());

int racksCount = 1;

int racksCappUsed = racksCap;

while(stack.Any())
{
    if(stack.Peek() <= racksCappUsed)
    {
        racksCappUsed -= stack.Pop();
    }
    else 
    {
        racksCount++;
        racksCappUsed = racksCap;
    }
}

Console.WriteLine(racksCount);

