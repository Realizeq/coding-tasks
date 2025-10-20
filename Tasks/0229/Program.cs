using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите x: ");
        float x = float.Parse(Console.ReadLine());

        float y;

        // а
        if (x >= 0)
        {
            y = x;
        }
        else
        {
            y = -x;
        }
        Console.WriteLine($"а) y = {y}");

        // б
        if (x >= 0)
        {
            y = -x;
        }
        else
        {
            y = x;
        }
        Console.WriteLine($"б) y = {y}");

        // в
        if (x <= -1)
        {
            y = -1;
        }
        else if (x >= 1)
        {
            y = 1;
        }
        else
        {
            y = x;
        }
        Console.WriteLine($"в) y = {y}");
    }
}