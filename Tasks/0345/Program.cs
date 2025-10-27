using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("а) ");
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();

        int sumAll = 0;
        int sumEven = 0;
        int countAll = 0;
        int countOdd = 0;
        int countEven = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                sumAll += i;
                countAll++;

                if (i % 2 == 0)
                {
                    sumEven += i;
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
            }
        }

        Console.WriteLine($"б) {sumAll}");
        Console.WriteLine($"в) {sumEven}");
        Console.WriteLine($"г) {countAll}");
        Console.WriteLine($"д) {countOdd}");
        Console.WriteLine($"е) {countEven}");

        Console.Write("Введите d: ");
        int d = int.Parse(Console.ReadLine());
        int countGreaterD = 0;
        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0 && i > d)
            {
                countGreaterD++;
            }
        }
        Console.WriteLine($"ж) {countGreaterD}");
    }
}