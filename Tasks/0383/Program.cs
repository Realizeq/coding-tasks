using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите a (0 ≤ a ≤ 8): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Введите y: ");
        int y = int.Parse(Console.ReadLine());

        int countA = 0;
        int sumGreaterA = 0;
        int sumEven = 0;
        int countXandY = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == a) countA++;

            if (digit > a) sumGreaterA += digit;

            if (digit % 2 == 0) sumEven += digit;

            if (digit == x || digit == y) countXandY++;

            temp /= 10;
        }

        Console.WriteLine($"а) {countA}");
        Console.WriteLine($"б) {sumGreaterA}");
        Console.WriteLine($"в) {sumEven}");
        Console.WriteLine($"г) {countXandY}");
    }
}