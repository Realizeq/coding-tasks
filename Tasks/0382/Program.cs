using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int count3 = 0;
        int lastDigit = number % 10;
        int countLast = 0;
        int countEven = 0;
        int sumGreater5 = 0;
        int productGreater7 = 1;
        int count0and5 = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == 3) count3++;

            if (digit == lastDigit) countLast++;

            if (digit % 2 == 0) countEven++;

            if (digit > 5) sumGreater5 += digit;

            if (digit > 7) productGreater7 *= digit;

            if (digit == 0 || digit == 5) count0and5++;

            temp /= 10;
        }

        Console.WriteLine($"а) {count3}");
        Console.WriteLine($"б) {countLast}");
        Console.WriteLine($"в) {countEven}");
        Console.WriteLine($"г) {sumGreater5}");
        Console.WriteLine($"д) {productGreater7}");
        Console.WriteLine($"е) {count0and5}");
    }
}