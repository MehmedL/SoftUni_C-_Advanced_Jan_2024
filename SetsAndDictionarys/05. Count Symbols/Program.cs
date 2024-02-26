char[] symbol = Console.ReadLine().ToCharArray();

SortedDictionary<char,int> charCount =  new SortedDictionary<char,int>();

foreach (char c in symbol)
{
    if(charCount.ContainsKey(c) )
    {
        charCount[c]++;
    }
    else
    {
        charCount.Add(c, 1);   
    }
}
foreach (char c in charCount.Keys)
{

    Console.WriteLine($"{c}: {charCount[c]} time/s");
}