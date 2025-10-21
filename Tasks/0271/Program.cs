using System;
class Program
{
    static void Main()
    {
        for (int x = 4; x <= 28; x++)
        {
            float t = x + 3;
            float y = 32 + 4.87f * t - 3;
            Console.WriteLine($"x = {x,-3} y = {y:F2}");
        }
    }
}