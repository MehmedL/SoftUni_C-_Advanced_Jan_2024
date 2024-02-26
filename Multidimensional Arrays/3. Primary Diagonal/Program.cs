int rowsAndCows = int.Parse(Console.ReadLine());

int[,] matrix = new int[rowsAndCows,rowsAndCows];
int sum = 0;
for (int i = 0; i < rowsAndCows; i++)
{
	int[] numbers = Console.ReadLine()
		.Split(' ')
		.Select(int.Parse)
		.ToArray();
	for (int j = 0; j < rowsAndCows; j++)
	{
		matrix[i,j] = numbers[j];
		if(i == j)
		{
			sum += matrix[i, j];
		}
	}
}
Console.WriteLine(sum);