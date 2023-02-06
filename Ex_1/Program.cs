
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintNto1(n);


void PrintNto1(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.Write($"{n} ");
    PrintNto1(n - 1);
}