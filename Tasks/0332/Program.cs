using System;
class Program
{
    static void Main()
    {
        for (int i = 100; i <= 999; i++)
        {
            if (i % 47 == 43 && i % 43 == 45)
            {
                Console.Write($"{i} ");
            }
        }
    }
}