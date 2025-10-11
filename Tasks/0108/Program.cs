using System;
class Program
{
    static void Main()
    {
        int a, b;

        Console.Write("Введите число a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        b = int.Parse(Console.ReadLine());

        int result = (1 - Math.Abs((a % b) * (b % a))) * (1 - Math.Abs((a % b) * (b % a)));

        Console.WriteLine($"{result}");
    }
}