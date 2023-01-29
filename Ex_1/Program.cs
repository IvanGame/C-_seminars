int m = 3;
int n = 4;
float[,] array = new float[m, n];
Random random = new Random();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = (float)Math.Round(random.NextDouble(), 2);
    }
}

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}