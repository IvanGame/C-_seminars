// Задача 1
using System;

Console.WriteLine("Введите первое число:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int num2 = int.Parse(Console.ReadLine());

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