using System;
class Program
{
    static void Main()
    {
        for (int i = 1000; i <= 9999; i++)
        {
            if (i % 133 == 125 && i % 134 == 111)
            {
                Console.Write($"{i} ");
            }
        }
    }
}