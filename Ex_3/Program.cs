int[,] array = new int[3, 4];
Random random = new Random();

// Заполнение массива случайными числами
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        array[i, j] = random.Next(1, 10);
    }
}

// Вывод массива
Console.WriteLine("Исходный массив:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

// Нахождение среднего арифметического для каждого столбца
Console.WriteLine("\nСреднее арифметическое для каждого столбца:");
for (int j = 0; j < 4; j++)
{
    int sum = 0;
    for (int i = 0; i < 3; i++)
    {
        sum += array[i, j];
    }
    Console.WriteLine("Столбец {0}: {1}", j + 1, Math.Round((double)sum / 3, 2));
}