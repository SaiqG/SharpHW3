// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
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


    int iNum = NumChecker();
    if (iNum >= 10000 && iNum < 100000)
    {
        if (iNum % 10 == iNum / 10000 && iNum / 10 % 10 == iNum / 1000 % 10)
        {
            Console.WriteLine($"{iNum} - палиндром");
        }
        else
        {
            Console.WriteLine($"{iNum} - не палиндром");
        }

    }
    else Console.WriteLine($"{iNum} - не пятизначное");

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q') break;
}