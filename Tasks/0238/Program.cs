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

        float sum;

        if (a > b && a > c)
        {
            if (b > c)
            {
                sum = a + b;
            }
            else
            {
                sum = a + c;
            }
        }
        else if (b > a && b > c)
        {
            if (a > c)
            {
                sum = b + a;
            }
            else
            {
                sum = b + c;
            }
        }
        else
        {
            if (a > b)
            {
                sum = c + a;
            }
            else
            {
                sum = c + b;
            }
        }

        Console.WriteLine($"Сумма двух наибольших: {sum}");
    }
}