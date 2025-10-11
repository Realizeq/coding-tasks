using System;
class Program
{
    static void Main()
    {
        float x;

        Console.Write("Введите x: ");
        x = float.Parse(Console.ReadLine());

        float k;

        if (Math.Sin(x) >= 0)
        {
            k = x * x;
        }
        else
        {
            k = Math.Abs(x);
        }

        float f;

        if (x < k)
        {
            f = Math.Abs(x);
        }
        else
        {
            f = k * x;
        }

        Console.WriteLine($"f(x) = {f}");
    }
}