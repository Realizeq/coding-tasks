using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Введите m: ");
        int m = int.Parse(Console.ReadLine());

        int sum = 0;
        int product = 1;
        int count = 0;
        int firstDigit = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            sum += digit;
            product *= digit;
            count++;
            firstDigit = digit;

            temp /= 10;
        }

        bool resultA = sum < a;

        bool resultB = product > b;

        bool resultC = count == k;

        bool resultD = firstDigit > m;

        Console.WriteLine($"а) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");
        Console.WriteLine($"г) {resultD}");
    }
}