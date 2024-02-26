int[] cowAndRow = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
Console.WriteLine(cowAndRow[0]);
Console.WriteLine(cowAndRow[1]);
int[,] matrix = new int[cowAndRow[0] , cowAndRow[1]];

int sum = 0;

for (int i = 0; i < cowAndRow[0]; i++)
{
    int[] rowNumbers = Console.ReadLine()
        .Split(", ")
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < cowAndRow[1]; j++)
    {
        matrix[i,j] = rowNumbers[j];
        sum += matrix[i,j];
    }
}

Console.WriteLine(sum);