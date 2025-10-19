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
        float min1 = a;

        if (b > max1)
        {
            max1 = b;
        }
        if (b < min1)
        {
            min1 = b;
        }
        Console.WriteLine($"а) Наибольшее: {max1}, Наименьшее: {min1}");

        float max2 = a;
        float min2 = a;

        if (b > a)
        {
            max2 = b;
            min2 = a;
        }
        if (b < a)
        {
            max2 = a;
            min2 = b;
        }
        Console.WriteLine($"б) Наибольшее: {max2}, Наименьшее: {min2}");
    }
}