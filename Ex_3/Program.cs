// Запрашиваем у пользователя число
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

// Проверяем, является ли число чётным
if (num % 2 == 0)
{
    Console.WriteLine("Число чётное");
}
else
{
    Console.WriteLine("Число нечётное");
}