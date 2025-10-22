using System;
class Program
{
    static void Main()
    {
        for (float x = 3.2f; x <= 3.9f; x += 0.1f)
        {
            Console.WriteLine($"{x:f1}");
        }
    }
}