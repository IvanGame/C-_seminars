int RaiseToPower(int baseNum, int exponent)
{
    int result = 1;
    for (int i = 0; i < exponent; i++)
    {
        result *= baseNum;
    }
    return result;
}

int A, B;

Console.Write("Введите A: ");
A = int.Parse(Console.ReadLine());

Console.Write("Введите B: ");
B = int.Parse(Console.ReadLine());

int result = RaiseToPower(A, B);
Console.WriteLine("Результат: " + result);