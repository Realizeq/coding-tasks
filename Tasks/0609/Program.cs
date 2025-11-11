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
            Console.Write(square + " ");
            k++;
            square = k * k;
        }
    }
}