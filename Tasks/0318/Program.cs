using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите семизначное число: ");
        int number = int.Parse(Console.ReadLine());

        int reversed = 0;
        for (int i = 0; i < 7; i++)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }

        Console.WriteLine($"{reversed}");
    }
}