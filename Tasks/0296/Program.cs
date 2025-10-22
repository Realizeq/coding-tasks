using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int product = 1;

        for (int i = 0; i < n; i++)
        {
            int digit = number % 10;
            sum += digit;
            product *= digit;
            number /= 10;
        }

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");
    }
}