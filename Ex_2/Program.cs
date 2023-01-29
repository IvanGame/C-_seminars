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

Console.WriteLine("Введите число для поиска:");
int searchNum = int.Parse(Console.ReadLine()!);
bool found = false;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (array[i, j] == searchNum)
        {
            found = true;
            break;
        }
    }
}

if (found)
    Console.WriteLine("Число найдено");
else
    Console.WriteLine("Такого числа в массиве нет");

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