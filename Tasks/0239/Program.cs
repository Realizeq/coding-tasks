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

        float product;

        if (a < b && a < c)
        {
            if (b < c)
            {
                product = a * b;
            }
            else
            {
                product = a * c;
            }
        }
        else if (b < a && b < c)
        {
            if (a < c)
            {
                product = b * a;
            }
            else
            {
                product = b * c;
            }
        }
        else
        {
            if (a < b)
            {
                product = c * a;
            }
            else
            {
                product = c * b;
            }
        }

        Console.WriteLine($"Произведение двух наименьших: {product}");
    }
}