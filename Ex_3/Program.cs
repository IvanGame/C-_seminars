
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = i;
}

DisplayArray(array);


void DisplayArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}