Console.WriteLine("Введите цифру, обозначающую день недели (1-7): ");
int dayOfWeek = int.Parse(Console.ReadLine());

if (dayOfWeek < 1 || dayOfWeek > 7)
{
    Console.WriteLine("Неверное число!");
}
else
{
    if (dayOfWeek == 6 || dayOfWeek == 7)
    {
        Console.WriteLine("Это выходной день!");
    }
    else
    {
        Console.WriteLine("Это рабочий день!");
    }
}