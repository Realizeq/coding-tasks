using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int lastDigit = number % 10;

        bool endsWithEven = lastDigit % 2 == 0;

        bool endsWithOdd = lastDigit % 2 == 1;

        Console.WriteLine($"а) Заканчивается четной цифрой - {endsWithEven}");
        Console.WriteLine($"б) Заканчивается нечетной цифрой - {endsWithOdd}");
    }
}