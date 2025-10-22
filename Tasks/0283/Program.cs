using System;
class Program
{
    static void Main()
    {
        // а)
        int productA = 1;
        for (int i = 7; i <= 14; i++)
        {
            productA *= i;
        }
        Console.WriteLine($"а) Произведение от 7 до 14: {productA}");

        // б)
        Console.Write("б) Введите a (1 <= a <= 15): ");
        int a = int.Parse(Console.ReadLine());
        int productB = 1;
        for (int i = a; i <= 15; i++)
        {
            productB *= i;
        }
        Console.WriteLine($"Произведение от {a} до 15: {productB}");

        // в)
        Console.Write("в) Введите b (1 <= b <= 10): ");
        int b = int.Parse(Console.ReadLine());
        int productC = 1;
        for (int i = 1; i <= b; i++)
        {
            productC *= i;
        }
        Console.WriteLine($"Произведение от 1 до {b}: {productC}");

        // г)
        Console.Write("г) Введите a: ");
        int a2 = int.Parse(Console.ReadLine());
        Console.Write("Введите b (b >= a): ");
        int b2 = int.Parse(Console.ReadLine());
        int productD = 1;
        for (int i = a2; i <= b2; i++)
        {
            productD *= i;
        }
        Console.WriteLine($"Произведение от {a2} до {b2}: {productD}");
    }
}