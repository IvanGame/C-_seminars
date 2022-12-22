Console.WriteLine("Введите число:");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine("Число\tКуб");
for (int i = 1; i <= n; i++)
{
    Console.WriteLine("{0}\t{1}", i, i * i * i);
}