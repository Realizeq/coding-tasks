using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        bool aDividesB = b % a == 0;

        bool bDividesA = a % b == 0;

        Console.WriteLine($"а) {a} является делителем {b} - {aDividesB}");
        Console.WriteLine($"б) {b} является делителем {a} - {bDividesA}");
    }
}