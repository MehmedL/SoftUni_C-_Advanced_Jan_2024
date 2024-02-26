using System.Collections;

Stack<int> dishes = new Stack<int> ();
dishes.Push (0);
dishes.Push (25);
dishes.Push(39);


while (dishes.Count > 0)
{
    int topElement = dishes.Pop ();
    Console.WriteLine (topElement);
}
Console.WriteLine (dishes.Pop());