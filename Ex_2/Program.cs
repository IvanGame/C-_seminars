Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100)
{
    Console.WriteLine("У введенного числа нет третьей цифры!");
}
else if (number > 100000)
{
    Console.WriteLine("Число больше положенного диапазона. Ввкдите число до 100000");
}
else
{
    if(number > 99 && number < 1000)
    {
        int thirdDigit = number % 10;
        Console.WriteLine($"Третья цифра введенного числа: {thirdDigit}");
    }
    else if (number > 999 && number < 10000)
    {
        int thirdDigit = number / 10 % 10;
        Console.WriteLine($"Третья цифра введенного числа: {thirdDigit}");
    }
    else
    {
        int thirdDigit = number / 100 % 10;
        Console.WriteLine($"Третья цифра введенного числа: {thirdDigit}");
    }
}