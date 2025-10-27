using System;
class Program
{
    static void Main()
    {
        for (int i = 10; i <= 99; i++)
        {
            if (i % 2 != 0 && (i % 10 == 3 || i % 10 == 7))
            {
                Console.Write($"{i} ");
            }
        }
    }
}