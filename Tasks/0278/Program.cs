using System;
class Program
{
    static void Main()
    {
        for (float x = 2.1f; x <= 2.8f; x += 0.1f)
        {
            Console.WriteLine($"{x:f1}");
        }
    }
}