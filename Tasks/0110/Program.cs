using System;
class Program
{
    static void Main()
    {
        float x;

        Console.Write("Введите x: ");
        x = float.Parse(Console.ReadLine());

        float y;

        if (x > 0)
        {
            y = (float)Math.Pow(Math.Sin(x), 2);
        }
        else
        {
            y = 1 - 2 * (float)Math.Sin(x * x);
        }

        Console.WriteLine($"y = {y:f2}");
    }
}