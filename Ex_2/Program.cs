
Console.WriteLine("Введите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите значение N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Сумма натуральных чисел между M и N: " + Sum(m, n));

int Sum(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + Sum(m + 1, n);
    }
}
