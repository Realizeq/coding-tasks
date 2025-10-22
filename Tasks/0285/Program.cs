using System;
class Program
{
    static void Main()
    {
        // а)
        int sumA = 0;
        for (int i = 25; i <= 40; i++)
        {
            sumA += i * i * i;
        }
        Console.WriteLine($"а) {sumA}");

        // б)
        Console.Write("б) ");
        int a = int.Parse(Console.ReadLine());
        int sumB = 0;
        for (int i = a; i <= 50; i++)
        {
            sumB += i * i;
        }
        Console.WriteLine($"{sumB}");

        // в)
        Console.Write("в) ");
        int n = int.Parse(Console.ReadLine());
        int sumC = 0;
        for (int i = 1; i <= n; i++)
        {
            sumC += i * i;
        }
        Console.WriteLine($"{sumC}");

        // г)
        Console.Write("г) ");
        int a2 = int.Parse(Console.ReadLine());
        int b2 = int.Parse(Console.ReadLine());
        int sumD = 0;
        for (int i = a2; i <= b2; i++)
        {
            sumD += i * i;
        }
        Console.WriteLine($"{sumD}");
    }
}