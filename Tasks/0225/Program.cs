using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());

        float y;

        if (x < -1)
        {
            y = -1;
        }
        else if (x > -1)
        {
            y = x;
        }
        else
        {
            y = 1;
        }

        Console.WriteLine($"y = {y}");
    }
}