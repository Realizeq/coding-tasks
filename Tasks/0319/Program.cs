using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        int square = 0;
        for (int i = 1; i <= 2 * n - 1; i += 2)
        {
            square += i;
        }

        Console.WriteLine($"{n}^2 = {square}");
    }
}