using System;
class Program
{
    static void Main()
    {
        for (int a = 2; a <= 17; a++)
        {
            float t = 3 * a;
            float z = (2 - 430 * t) / (8 + 13);
            Console.WriteLine($"a = {a,-3} z = {z:F2}");
        }
    }
}