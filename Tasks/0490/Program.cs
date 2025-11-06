using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("p: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        int count1 = 0;
        int count2 = 0;
        int count3 = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a > p) count1++;
            if (a % 10 == 5) count2++;
            if (a % k == 0) count3++;
        }

        Console.WriteLine($"а) {count1}");
        Console.WriteLine($"б) {count2}");
        Console.WriteLine($"в) {count3}");
    }
}