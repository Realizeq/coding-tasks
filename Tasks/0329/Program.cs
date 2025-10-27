using System;
class Program
{
    static void Main()
    {
        for (int i = 100; i <= 200; i++)
        {
            if (i % 3 == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}