int[] cowAndRow = Console.ReadLine()
    .Split(", ")
    .Select(int.Parse)
    .ToArray();
int[,] matrix = new int[cowAndRow[0], cowAndRow[1]];

int sum = 0;

for (int i = 0; i < cowAndRow[0]; i++)
{
    int[] rowNumbers = Console.ReadLine()
        .Split(' ')
        .Select(int.Parse)
        .ToArray();
    for (int j = 0; j < cowAndRow[1]; j++)
    {
        matrix[i, j] = rowNumbers[j];
    }
}

for (int c = 0; c < matrix.GetLength(1); c++)
{
      
     for (int r = 0; r < matrix.GetLength(0); r++)
     {
         sum += matrix[r, c];
     }
     Console.WriteLine(sum);
    sum = 0;
}