using System;
class Program
{
    static void Main()
    {
        // а)
        int sumA = 0;
        for (int i = 200; i <= 600; i++)
        {
            sumA += i;
        }
        Console.WriteLine($"а) Сумма от 200 до 600: {sumA}");

        // б)
        Console.Write("б) Введите a (a <= 400): ");
        int a = int.Parse(Console.ReadLine());
        int sumB = 0;
        for (int i = a; i <= 400; i++)
        {
            sumB += i;
        }
        Console.WriteLine($"Сумма от {a} до 400: {sumB}");

        // в)
        Console.Write("в) Введите b (b >= -15): ");
        int b = int.Parse(Console.ReadLine());
        int sumC = 0;
        for (int i = -15; i <= b; i++)
        {
            sumC += i;
        }
        Console.WriteLine($"Сумма от -15 до {b}: {sumC}");

        // г)
        Console.Write("г) Введите a: ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите b (b >= a): ");
        int b2 = int.Parse(Console.ReadLine());
        int sumD = 0;
        for (int i = a2; i <= b2; i++)
        {
            sumD += i;
        }
        Console.WriteLine($"Сумма от {a2} до {b2}: {sumD}");
    }
}