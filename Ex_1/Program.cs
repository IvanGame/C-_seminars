Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

if (number < 100 || number > 999)
{
    Console.WriteLine("Вы ввели не трехзначное число!");
}
else
{
    int secondDigit = (number / 10) % 10;
    Console.WriteLine($"Вторая цифра введенного числа: {secondDigit}");
}