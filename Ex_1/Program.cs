/* Математический способ 
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine()!);
if (number > 9999 && number < 100000)
{
    int a = number / 10000;
    int b = (number / 1000) % 10;
    int c = (number / 100) % 10;
    int d = (number / 10) % 10;
    int e = number % 10;

    if (a == e && b == d)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}
else
{
    Console.WriteLine("Вы ввели не пятизначное число!");
} */

// Альтернативный способ

Console.WriteLine("Введите пятизначное число:");

string number = Console.ReadLine()!;

if (number.Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
}
else
{
    System.Console.WriteLine("Вы ввели не пятизначное число!");
}