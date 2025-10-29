using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральнче числа: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        bool hasA = false;
        bool hasB = false;
        int countA = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == a)
            {
                hasA = true;
                countA++;
            }

            if (digit == b) hasB = true;

            temp /= 10;
        }

        Console.WriteLine($"а) {hasA}");

        bool noB = !hasB;
        Console.WriteLine($"б) {noB}");

        bool moreThanK = countA > k;
        Console.WriteLine($"в) {moreThanK}");

        bool hasAandB = hasA && hasB;
        Console.WriteLine($"г) {hasAandB}");
    }
}