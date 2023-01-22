int[] getArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 101);
    }
    return array;
}

int[] sortArray(int[] inputArray)
{
    int temp;
    for (int i = 0; i < inputArray.Length; i++)
    {
        for (int j = i + 1; j < inputArray.Length; j++)
        {
            if (inputArray[i] > inputArray[j])
            {
                temp = inputArray[i];
                inputArray[i] = inputArray[j];
                inputArray[j] = temp;
            }
        }
    }
    return inputArray;
}

int[] inputArray = getArray();

Console.WriteLine("Исходный массив");

foreach (int num in inputArray)
{
    Console.Write(num + " ");
}

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("Массив после обработки");

foreach (int num in sortArray(inputArray))
{
    Console.Write(num + " ");
}

//Более короткое решение
// int[] inputArray1 = { 4, 7, 2, 9, 1, 3 };
// Array.Sort(inputArray1);
// foreach (int num in inputArray1)
// {
//     Console.Write(num + " ");
// }