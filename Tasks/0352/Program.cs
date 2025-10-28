using System;
class Program
{
    static void Main()
    {
        int number = 191;
        while (number % 17 != 0)
        {
            number++;
        }
        Console.WriteLine($"{number}");
    }
}