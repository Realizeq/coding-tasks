using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        float c = float.Parse(Console.ReadLine());

        float max, min;

        if (a > b && a > c)
        {
            max = a;
            if (b > c)
            {
                min = c;
            }
            else
            {
                min = b;
            }
        }
        else if (b > a && b > c)
        {
            max = b;
            if (a > c)
            {
                min = c;
            }
            else
            {
                min = a;
            }
        }
        else
        {
            max = c;
            if (a > b)
            {
                min = b;
            }
            else
            {
                min = a;
            }
        }

        Console.WriteLine($"Максимальное: {max}");
        Console.WriteLine($"Минимальное: {min}");
    }
}