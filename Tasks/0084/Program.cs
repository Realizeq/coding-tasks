using System;
class program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        // тут цифру считать
        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;

        // справа налево
        int reverse = d * 1000 + c * 100 + b * 10 + a;
        Console.WriteLine($"а) Число справа налево: {reverse}");

        // перестановка первой и второй, третьей и четвертой
        int swap12_34 = b * 1000 + a * 100 + d * 10 + c;
        Console.WriteLine($"б) Перестановка 1-2 и 3-4 цифр: {swap12_34}");

        // перестановка второй и третьей
        int swap23 = a * 1000 + c * 100 + b * 10 + d;
        Console.WriteLine($"в) Перестановка 2-3 цифр: {swap23}");

        // способ 1: перестановка двух первых и двух последних цифр (с выделением цифр)
        int swapFirstLast1 = c * 1000 + d * 100 + a * 10 + b;
        Console.WriteLine($"Способ 1 (с выделением цифр): {swapFirstLast1}");

        // способ 2: перестановка двух первых и двух последних цифр (без выделения цифр)
        int firstTwo = number / 100;
        int lastTwo = number % 100;
        int swapFirstLast2 = lastTwo * 100 + firstTwo;
        Console.WriteLine($"Способ 2 (без выделения цифр): {swapFirstLast2}");
    }
}