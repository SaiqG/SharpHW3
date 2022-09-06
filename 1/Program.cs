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


    int Num = NumChecker();
    if (Num >= 10000 && Num < 100000)
    {
        if (Num % 10 == Num / 10000 && Num / 10 % 10 == Num / 1000 % 10)
        {
            Console.WriteLine($"{Num} - палиндром");
        }
        else { Console.WriteLine($"{Num} - не палиндром"); }

    }
    else Console.WriteLine($"{Num} - не пятизначное");

    //Зацикливание программы
    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q') break;
}