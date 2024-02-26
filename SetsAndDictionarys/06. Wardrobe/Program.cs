int n = int.Parse(Console.ReadLine());

var dreses = new Dictionary<string, Dictionary<string,int>>();

for (int i = 0; i < n; i++)
{
    string[] newEntry = Console.ReadLine()
        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
        
    string color = newEntry[0];
    string[] secondEntry = newEntry[1]
        .Split(",", StringSplitOptions.RemoveEmptyEntries);
        
    if(!dreses.ContainsKey(color))
    {
        dreses.Add(color, new Dictionary<string, int>());
    }
    
    foreach (string key in secondEntry)
    {
        if (!dreses[color].ContainsKey(key))
        {
            dreses[color].Add(key, 1);
        }
        else
        {
            dreses[color][key]++;
        }
    }
    
}
string[] searchIteam = Console.ReadLine()
    .Split(' ' , StringSplitOptions.RemoveEmptyEntries)
    .ToArray();

foreach (var color in dreses)
{
    Console.WriteLine($"{color.Key} clothes:");
    foreach (var item in color.Value)
    {
        Console.Write($"* {item.Key} - {item.Value}");
        if (color.Key == searchIteam[0] && item.Key == searchIteam[1] )
        {
            Console.Write(" (found!)");
        }
        Console.WriteLine();
    }
}
