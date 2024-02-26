using System.Net.Quic;

List<int> numbers = new List<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
Queue<int> queue = new Queue<int>(numbers);
int mattch = 0;
for (int i = 0; i < numbers.Count; i++)
{
    int number = queue.Dequeue();
    //int mattch = 0 ;
    if (number % 2 == 0)
    {
        if (mattch == 0)
        {
            Console.Write($"{number}");
            mattch++;
        }
        else
        {
            Console.Write($", {number}");
        }
        
    }
    

}