int count = 0;
Console.Write("Введите числа через пробел: ");
string[] input = Console.ReadLine()!.Split();

Console.WriteLine("Чисел больше 0: " + numberOfCount(input));

int numberOfCount(string[] input)
{
    for (int i = 0; i < input.Length; i++)
    {
        int value = int.Parse(input[i]);
        if (value > 0)
        {
            count++;
        }
    }
    return count;
}