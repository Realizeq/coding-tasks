using System;
class Program
{
    static void Main()
    {
        for (float x = 4.4f; x <= 6.4f; x += 0.2f)
        {
            Console.WriteLine($"{x:f1}");
        }
    }
}