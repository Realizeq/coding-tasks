using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        float a = float.Parse(Console.ReadLine());

        int z;

        if (a > 0)
        {
            z = 1;
        }
        else if (a == 0)
        {
            z = 0;
        }
        else
        {
            z = -1;
        }

        Console.WriteLine($"z = {z}");
    }
}