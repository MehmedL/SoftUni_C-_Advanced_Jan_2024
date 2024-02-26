using StarUp;

int lines = int.Parse(Console.ReadLine());

Box<int> stringBox = new Box<int>();

for (int i = 0;i < lines;i++)
{
    stringBox.Add(int.Parse(Console.ReadLine()));
}

string compareWith = Console.ReadLine();

Console.WriteLine(box.Count(compareWith));