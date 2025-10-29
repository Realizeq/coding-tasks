using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

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

        bool a = sum > 10;

        bool b = product < 50;

        bool c = count % 2 == 0;

        bool d = number >= 1000 && number <= 9999;

        bool e = firstDigit <= 6;

        bool f = firstDigit == lastDigit;

        string g = firstDigit > lastDigit ? "Первая" : "Последняя";

        Console.WriteLine($"а) {a}");
        Console.WriteLine($"б) {b}");
        Console.WriteLine($"в) {c}");
        Console.WriteLine($"г) {d}");
        Console.WriteLine($"д) {e}");
        Console.WriteLine($"е) {f}");
        Console.WriteLine($"ж) {g}");
    }
}