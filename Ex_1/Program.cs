int evenCount(int[] array)
{
    int evenCount = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenCount++;
            }
        }
    return evenCount;
}

int[] getArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

Console.WriteLine("Колличество чётных чисел: " + evenCount(getArray()));