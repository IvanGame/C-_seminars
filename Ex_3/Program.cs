int[] getArray()
{
    int[] array = new int[10];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 11);
    }
    return array;
}

int[] arrayProd(int[] array)
{
    int[] result = new int[array.Length / 2];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}
int[] array = getArray();
var str = string.Join(" ", array);
Console.WriteLine(str);

var str2 = string.Join(" ", arrayProd(array));
Console.WriteLine($"Новый массив с произведением пар чисел = {str2}");