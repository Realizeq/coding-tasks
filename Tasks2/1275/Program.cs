using System;
class Program
{
    static void Main()
    {
        float x = 55;
        float y = 75;
        float temp;

        if (x > y)
        {
            temp = x;
            x = y;
            y = temp;
        }
        else
        {
            y = y - x;
        }

        Console.WriteLine($"x = {x}");
    }
}