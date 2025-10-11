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
            y = (float)Math.Sin(x * x);
        }
        else
        {
            y = 1 + 2 * (float)Math.Pow(Math.Sin(x), 2);
        }

        Console.WriteLine($"y = {y}");
    }
}