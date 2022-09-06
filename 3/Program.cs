//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

while (true) // Зацикливание программы
{
    int NumChecker() //метод проверки на ввод числа
    {
        while (true)
        {
            Console.WriteLine("Введите число для подолжения, или *q* чтоб выйти");
            string num = Console.ReadLine()!;

            if (num == "q")
            {
                Console.WriteLine($"Вы не ввели число");
                System.Environment.Exit(0); //завершение программы на любом этапе
                return -1;
            }
            else if (int.TryParse(num, out int isItNum))
                return isItNum;
        }
    }


    int nums = NumChecker();
    Console.WriteLine("");

    double[] arrey = new double[nums + 1];

    for (int step = 0; step <= nums; step++)
    {
        arrey[step] = Math.Pow(step, 3);
        Console.Write($"{arrey[step]}, ");
    }

    //Зацикливание программы
    Console.WriteLine();
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.WriteLine();
    if (quite.KeyChar == 'q') break;
}