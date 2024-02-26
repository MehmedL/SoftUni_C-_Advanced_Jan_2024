
int rowsAndCols = int.Parse(Console.ReadLine());

int[,] arr = new int[rowsAndCols, rowsAndCols];
int firstSum = 0,
	secondSum = 0,
	sum = 0;
for (int row = 0; row < rowsAndCols; row++)
{
	int[] value = Console.ReadLine()
		.Split(' ')
		.Select(int.Parse)
		.ToArray();
    for (int col = 0; col < rowsAndCols; col++)
	{
		arr[row,col] = value[col];
	}
}
for (int i = 0; i < rowsAndCols; i++)
{
	firstSum += arr[i,i];
	secondSum += arr[i,rowsAndCols - i - 1];
}
Console.WriteLine(Math.Abs(firstSum - secondSum));