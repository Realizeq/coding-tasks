using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"a{i + 1}: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        int result_a = a[0] + a[n - 1];
        int result_b = a[1] - a[n - 2];

        Console.WriteLine($"а) {result_a}");
        Console.WriteLine($"б) {result_b}");
    }
}