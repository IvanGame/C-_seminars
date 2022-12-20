// Запрашиваем у пользователя число N
Console.WriteLine("Введите число N:");
int N = int.Parse(Console.ReadLine()!);

// Создаём счётчик
int count = 1;

// Перебираем и выводим чётные числа
Console.Write("Чётные числа от 1 до " + N + ": ");
while (count <= N)
{
    if (count % 2 == 0)
    {
        System.Console.Write($"{count} ");
    }
    count++;
}