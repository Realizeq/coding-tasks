using System;
class Program
{
    static void Main()
    {
        for (float x = 0.1f; x <= 0.9f; x += 0.1f)
        {
            float sqrtValue = (float)Math.Sqrt(x);
            Console.WriteLine($"корень {x:F1} = {sqrtValue:F2}");
        }
    }
}