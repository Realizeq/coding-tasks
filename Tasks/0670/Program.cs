using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Трехзначные числа с суммой цифр {n}:");

        for (int i = 100; i <= 999; i++)
        {
            int sotni = i / 100;
            int desyatki = (i / 10) % 10;
            int edinici = i % 10;

            if (sotni + desyatki + edinici == n)
            {
                Console.WriteLine(i);
            }
        }
    }
}