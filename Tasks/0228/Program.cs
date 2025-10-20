using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите y: ");
        float y = float.Parse(Console.ReadLine());

        float f;

        if (y > 2)
        {
            f = 2;
        }
        else if (y > 0)
        {
            f = 0;
        }
        else
        {
            f = -3 * y;
        }

        Console.WriteLine($"f = {f}");
    }
}