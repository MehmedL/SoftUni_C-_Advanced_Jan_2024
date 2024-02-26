int n = int.Parse(Console.ReadLine());

var eventNumbers = new Dictionary<int, bool>();

for(int i = 0;i < n;i++)
{
    int number = int.Parse(Console.ReadLine());

    if(!eventNumbers.ContainsKey(number))
    {
        eventNumbers.Add(number, false);
    }
    else
    {
        eventNumbers[number] = !eventNumbers[number];
    }

}
foreach(var b in eventNumbers.Keys)
{
    if (eventNumbers[b])
    {
        Console.WriteLine(b);
    }
}