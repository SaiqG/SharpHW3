// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write("Введите координаты первой точки X Y Z через пробел: ");

string xyz = Console.ReadLine()!;
string[] parts = xyz.Split(' ');
int[] dotA = new int[3];
for (int i = 0; i < 3; i++)
{
    dotA[i] = int.Parse(parts[i]);
}

Console.Write("Введите координаты второй точки X Y Z через пробел: ");
string x1y1z1 = Console.ReadLine()!;
string[] parts1 = x1y1z1.Split(' ');
int[] dotB = new int[3];
for (int i = 0; i < 3; i++)
{
    dotB[i] = int.Parse(parts1[i]);
}

double dis = Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2));

Console.Write($"Расстояние между точками равно: {dis:F3}");


