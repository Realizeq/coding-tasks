using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите цифру a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите цифру b: ");
        int b = int.Parse(Console.ReadLine());

        int countA = 0;
        int countB = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == a) countA++;
            if (digit == b) countB++;

            temp /= 10;
        }

        bool result = countA < countB;
        Console.WriteLine($"{result}");
    }
}