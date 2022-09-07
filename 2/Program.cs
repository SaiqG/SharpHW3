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

        double sum = 0;
        for (int i = 0; i < 3; i++)
        {
            sum = Math.Pow(int.Parse(parts[i]) - int.Parse(parts1[i]), 2) + sum;
        }

        double dis = Math.Sqrt(sum);
        
        Console.Write($"Расстояние между точками равно: {dis:F3}");
        Console.WriteLine();
    }
    catch (Exception)
    {
        Console.WriteLine("Упс! Что-то пошло не так, попробуйте ввести корректные данные.");
    }

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q') break;
}

