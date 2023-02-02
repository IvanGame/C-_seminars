int[,] arr = GetArray(6, 4, 0, 10);

Console.WriteLine("Массив: ");
PrintArray(arr);

int rowIndex = FindSmallestSumRow(arr);

Console.WriteLine("\nРяд с наименьшей суммой: " + (rowIndex + 1));

int FindSmallestSumRow(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int rowIndex = 0;
    int minSum = int.MaxValue;

    for (int i = 0; i < rows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < columns; j++)
        {
            rowSum += arr[i, j];
        }
        if (rowSum < minSum)
        {
            minSum = rowSum;
            rowIndex = i;
        }
    }
    return rowIndex;
}

void PrintArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}