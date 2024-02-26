using System;
using LinkedList;
namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftuniLinkedList linkedList = new SoftuniLinkedList();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            linkedList.AddFirst(5);
            linkedList.AddFirst(6);
            linkedList.AddFirst(7);
            linkedList.AddFirst(8);

            linkedList.ForEach(n =>
            {
                global::System.Console.WriteLine(n);
            });
            int[] array = linkedList.ToArray();

            Console.WriteLine(string.Join(",", array));




            //linkedList.RemoveFirst();

            //linkedList.RemoveLast();
            //linkedList.RemoveLast();
            //Node node = linkedList.Head;

            //while (node != null)
            //{
            //    Console.WriteLine(node.Value);
            //    node = node.Next;
            //}
        }
    }
}
