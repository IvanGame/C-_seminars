// Запрашиваем у пользователя три числа
Console.WriteLine("Введите три числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

// Находим максимальное число
int max = num1;
if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

// Выводим результат
Console.WriteLine("Максимальное число: " + max);