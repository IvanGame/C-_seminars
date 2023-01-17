
int[] getArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 101);
    }
    return array;
}

int oddSum(int[] array)
{
    int sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
            sum += arr[i];
    }
    return sum;
}

Console.WriteLine("Сумма нечётных элементов: " + oddSum(getArray()));