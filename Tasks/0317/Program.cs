using System;
class Program
{
    static void Main()
    {
        float result = 20.0f * 20.0f;

        for (int i = 19; i >= 1; i--)
        {
            result = (result - i * i) * (result - i * i);
        }

        Console.WriteLine($"{result:f2}");
    }
}