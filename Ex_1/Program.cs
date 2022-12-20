// Задача 1
using System;

// Запрашиваем  у пользователя первое число
Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

// Запрашиваем  у пользователя второе число
Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

// Сравниваем числа
if (num1 > num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else
{
    Console.WriteLine("Числа равны");
}