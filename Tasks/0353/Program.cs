using System;
class Program
{
    static void Main()
    {
        int number = 5000;
        while (number % 139 != 0)
        {
            number--;
        }
        Console.WriteLine($"{number}");
    }
}