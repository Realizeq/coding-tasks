using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int position = 0;
        int leftmostPosition = 0;
        int temp = number;

        while (temp > 0)
        {
            position++;
            int digit = temp % 10;

            if (digit == 8)
            {
                leftmostPosition = position;
            }

            temp /= 10;
        }

        Console.WriteLine($"{leftmostPosition}");
    }
}