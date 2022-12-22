Console.WriteLine("Введите координаты первой точки (x, y, z):");
double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки (x, y, z):");
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);
double z2 = double.Parse(Console.ReadLine()!);

double distance = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);
Console.WriteLine("Расстояние между двумя точками: " + distance);