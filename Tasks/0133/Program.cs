using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());

        int nextNumber = n + 2 - (n % 2);

        Console.WriteLine($"Следующее четное число: {nextNumber}");
    }
}