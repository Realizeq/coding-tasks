using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        // а)
        float sumSin = 0.0f;
        float resultA = 0.0f;
        for (int i = 1; i <= n; i++)
        {
            sumSin += (float)Math.Sin(i);
            resultA += 1.0f / sumSin;
        }

        // б)
        float resultB = (float)Math.Sqrt(2);
        for (int i = 2; i <= n; i++)
        {
            resultB = (float)Math.Sqrt(2 + resultB);
        }

        // в)
        float sumCos = 0.0f;
        float sumSin2 = 0.0f;
        float resultC = 0.0f;
        for (int i = 1; i <= n; i++)
        {
            sumCos += (float)Math.Cos(i);
            sumSin2 += (float)Math.Sin(i);
            resultC += sumCos / sumSin2;
        }

        // г)
        float resultD = (float)Math.Sqrt(3 * n);
        for (int i = n - 1; i >= 1; i--)
        {
            resultD = (float)Math.Sqrt(3 * i + resultD);
        }

        Console.WriteLine($"а) {resultA:f2}");
        Console.WriteLine($"б) {resultB:f2}");
        Console.WriteLine($"в) {resultC:f2}");
        Console.WriteLine($"г) {resultD:f2}");
    }
}