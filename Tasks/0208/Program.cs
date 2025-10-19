using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        float max1 = a;
        if (b > max1)
        {
            max1 = b;
        }
        Console.WriteLine($"а) Наибольшее число: {max1}");

        float max2 = a;
        if (b > a) max2 = b;
        Console.WriteLine($"б) Наибольшее число: {max2}");
    }
}