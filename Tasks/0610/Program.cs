using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int k = 1;
        int square = k * k;
        while (square <= n)
        {
            k++;
            square = k * k;
        }
        Console.WriteLine($"1) первое число больше n: {square}");

        k = (int)Math.Sqrt(n) + 1;
        square = k * k;
        Console.WriteLine($"2) первое число больше n: {square}");
    }
}