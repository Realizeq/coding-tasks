using System;
class Program
{
    static void Main()
    {
        int[] domino = { 12, 23, 34, 45, 56, 61, 13, 35, 52, 26, 64, 41, 15, 54, 46, 63, 32, 21, 14, 43, 36, 65 };

        Console.WriteLine("Массив костей домино:");
        for (int i = 0; i < domino.Length; i++)
        {
            Console.WriteLine($"{domino[i]}");
        }

        Console.WriteLine("а) Проверка по последней цифре:");
        bool pravilnoA = true;
        for (int i = 0; i < domino.Length - 1; i++)
        {
            int pravyiKonec = domino[i] % 10;
            int levyiKonec = domino[i + 1] / 10;
            if (pravyiKonec != levyiKonec)
            {
                pravilnoA = false;
                break;
            }
        }

        if (pravilnoA)
        {
            Console.WriteLine("Правильно выложено по последней цифре");
        }
        else
        {
            Console.WriteLine("Неправильно выложено по последней цифре");
        }

        Console.WriteLine("б) Проверка по любой цифре:");
        bool pravilnoB = true;
        for (int i = 0; i < domino.Length - 1; i++)
        {
            int cifra1 = domino[i] / 10;
            int cifra2 = domino[i] % 10;
            int cifra3 = domino[i + 1] / 10;
            int cifra4 = domino[i + 1] % 10;

            if (cifra2 != cifra3 && cifra1 != cifra3 && cifra2 != cifra4 && cifra1 != cifra4)
            {
                pravilnoB = false;
                break;
            }
        }

        if (pravilnoB)
        {
            Console.WriteLine("Правильно выложено по любой цифре");
        }
        else
        {
            Console.WriteLine("Неправильно выложено по любой цифре");
        }
    }
}