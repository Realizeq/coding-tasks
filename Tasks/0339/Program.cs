using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 4 == 0)
            {
                sum += i;
            }
        }
        Console.WriteLine($"{sum}");
    }
}