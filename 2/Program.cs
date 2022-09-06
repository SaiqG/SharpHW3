// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Write("Введите координаты первой точки X Y Z через пробел: ");
string xyz = Console.ReadLine()!;
string[] parts = xyz.Split(' ');
int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);
int z = int.Parse(parts[2]);
Console.Write("Введите координаты второй точки X Y Z через пробел: ");
string x1y1z1 = Console.ReadLine()!;
string[] parts1 = x1y1z1.Split(' ');
int x1 = int.Parse(parts1[0]);
int y1 = int.Parse(parts1[1]);
int z1 = int.Parse(parts1[2]);
double dis = Math.Sqrt(Math.Pow(x1 - x, 2) + Math.Pow(y1 - y, 2) + Math.Pow(z1 - z, 2));
Console.Write($"Расстояние между точками равно: {dis:F3}");


