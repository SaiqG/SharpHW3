// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
while (true)
{
    try
    {
        Console.Write("Введите координаты первой точки X Y Z через пробел: ");

        string xyz = Console.ReadLine()!;
        string[] parts = xyz.Split(' ');

        Console.Write("Введите координаты второй точки X Y Z через пробел: ");

        xyz = Console.ReadLine()!;
        string[] parts1 = xyz.Split(' ');

        int[] dots = new int[6];
        for (int i = 0; i < 3; i++)
        {
            dots[i] = int.Parse(parts[i]);
            dots[i + 3] = int.Parse(parts1[i]);
        }
        double dis = Math.Sqrt(Math.Pow(dots[0] - dots[3], 2) + Math.Pow(dots[1] - dots[4], 2) + Math.Pow(dots[2] - dots[5], 2));

        Console.Write($"Расстояние между точками равно: {dis:F3}");
        Console.WriteLine();
    }
    catch (FormatException)
    {
        Console.WriteLine("Упс! Что-то пошло не так, попробуйте ввести корректные данные.");
    }

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q') break;
}

