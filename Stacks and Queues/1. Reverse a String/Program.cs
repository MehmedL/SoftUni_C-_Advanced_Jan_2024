Stack <char> text = new Stack<char> (Console.ReadLine().ToCharArray());

while (text.Count != 0)
{
    Console.Write(text.Pop());
}
