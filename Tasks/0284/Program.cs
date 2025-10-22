using System;
class Program
{
    static void Main()
    {
        // а)
        int sumA = 0;
        for (int i = 1; i <= 750; i++)
        {
            sumA += i;
        }
        float averageA = (float)sumA / 750;
        Console.WriteLine($"а) {averageA:F2}");

        // б)
        Console.Write("б) ");
        int b = int.Parse(Console.ReadLine());
        int sumB = 0;
        int countB = 0;
        for (int i = 150; i <= b; i++)
        {
            sumB += i;
            countB++;
        }
        float averageB = (float)sumB / countB;
        Console.WriteLine($"{averageB:F2}");

        // в)
        Console.Write("в) ");
        int a = int.Parse(Console.ReadLine());
        int sumC = 0;
        int countC = 0;
        for (int i = a; i <= 200; i++)
        {
            sumC += i;
            countC++;
        }
        float averageC = (float)sumC / countC;
        Console.WriteLine($"{averageC:F2}");

        // г)
        Console.Write("г) ");
        int a2 = int.Parse(Console.ReadLine());
        int b2 = int.Parse(Console.ReadLine());
        int sumD = 0;
        int countD = 0;
        for (int i = a2; i <= b2; i++)
        {
            sumD += i;
            countD++;
        }
        float averageD = (float)sumD / countD;
        Console.WriteLine($"{averageD:F2}");
    }
}