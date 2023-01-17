int SumOfDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр: " + SumOfDigits(num));