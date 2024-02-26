using System.Collections;

List<string> simbols = new List<string>(Console.ReadLine().Split().ToList());

Stack<string> operations = new Stack<string>(simbols);
int number = int.Parse(operations.Pop());
while(operations.Count != 0)
{
    string oper = operations.Pop();
    if(oper == '-')
    Console.WriteLine(operations.Pop());
}