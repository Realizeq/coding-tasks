using System;
class Program
{
    static void Main()
    {
        float x;

        Console.Write("Введите x: ");
        x = float.Parse(Console.ReadLine());

        float y;

        if (x == 2)
        {
            y = 2;
        }
        else if (x == 3)
        {
            y = -3;
        }
        else
        {
            y = 0;
        }

        Console.WriteLine($"y = {y}");
    }
}