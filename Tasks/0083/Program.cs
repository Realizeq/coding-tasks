using System;
class program
{
    static void Main()
    {
        // а)
        Console.Write("Введите 4-значное число: ");
        int number4 = int.Parse(Console.ReadLine());

        int sum4 = (number4 / 1000) + (number4 / 100 % 10) + (number4 / 10 % 10) + (number4 % 10);

        Console.WriteLine($"а) Сумма цифр 4-значного числа: {sum4}");

        // б) 
        Console.Write("Введите 5-значное число: ");
        int number5 = int.Parse(Console.ReadLine());

        int sum5 = (number5 / 10000) + (number5 / 1000 % 10) + (number5 / 100 % 10) + (number5 / 10 % 10) + (number5 % 10);

        Console.WriteLine($"б) Сумма цифр 5-значного числа: {sum5}");
    }
}