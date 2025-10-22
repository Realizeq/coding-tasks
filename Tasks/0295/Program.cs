using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите 9 ти знач число: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            sum += number % 10;
            number /= 10;
        }

        Console.WriteLine($"{sum}");
    }
}