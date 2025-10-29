using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральные числа: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("y: ");
        int y = int.Parse(Console.ReadLine());
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        int product = 1;
        int count = 0;
        int firstDigit = 0;
        int lastDigit = number % 10;

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

        bool resultA = sum > k && number % 2 == 0;

        bool resultB = count % 2 == 0 && number <= b;

        bool resultC = firstDigit == x && lastDigit == y;

        bool resultD = product < a && number % b == 0;

        bool resultE = sum > m && number % n == 0;

        Console.WriteLine($"а) {resultA}");
        Console.WriteLine($"б) {resultB}");
        Console.WriteLine($"в) {resultC}");
        Console.WriteLine($"г) {resultD}");
        Console.WriteLine($"д) {resultE}");
    }
}