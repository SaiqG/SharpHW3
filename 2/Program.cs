// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
while (true)
{
    try
    {
        Console.Write("Введите координаты первой точки X Y Z через пробел, запятую или / : ");

        string xyz = Console.ReadLine()!;
        string[] parts = xyz.Split(' ', ',', '/');
        Console.Write("Введите координаты второй точки X Y Z через пробел, запятую или / : ");

        xyz = Console.ReadLine()!;
        string[] parts1 = xyz.Split(' ', ',', '/');

        if (parts.Length == parts1.Length && parts.Length == 3)
        {
            double sum = 0;
            for (int i = 0; i < parts.Length; i++)
            {
                sum = Math.Pow(double.Parse(parts[i]) - double.Parse(parts1[i]), 2) + sum;
            }

            double dis = Math.Sqrt(sum);

            Console.Write($"Расстояние между точками равно: {dis:F3}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Некорректные координаты точек.");
            Console.WriteLine("Введите 3 координаты для первой точки и 3 координаты для второй точки.");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("Упс! Что-то пошло не так, попробуйте ввести корректные данные.");
    }

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}

