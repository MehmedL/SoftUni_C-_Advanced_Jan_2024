int[] inputForRowsAndCols = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();
int rows = inputForRowsAndCols[0];
int cols = inputForRowsAndCols[1];

string[,] arr = new string[rows, cols];

for (int i = 0; i < rows; i++)
{
    string[] inputLetters = Console.ReadLine()
        .Split(' ')
        .ToArray();
    for (int j = 0; j < cols; j++)
    {
        arr[i, j] = inputLetters[j].ToLower();
    }


}
int sum = 0;
for (int i = 0; i < rows-1; i++)
{
    
    for (int j = 0; j < cols-1; j++)
    {
        string letter = arr[i, j];
        
        if (arr[i, j] == letter && arr[i, j + 1] == letter && arr[i + 1, j] == letter && arr[i + 1, j + 1] == letter)
        {
            sum++;
        }
    }
}

Console.WriteLine(sum);