using System;
class Program
{
    static void Main()
    {
        for (float x = 2.2f; x <= 4.2f; x += 0.2f)
        {
            Console.WriteLine($"{x:f1}");
        }
    }
}