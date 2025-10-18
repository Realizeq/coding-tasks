using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите длину стола a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите ширину стола b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите размер c кости: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите размер d кости: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Введите размер e кости: ");
        int e = int.Parse(Console.ReadLine());

        int maxCount = 0;

        int count1 = (a / c) * (b / d);
        int count2 = (a / d) * (b / c);
        int maxCD = Math.Max(count1, count2);
        if (maxCD > maxCount) maxCount = maxCD;

        int count3 = (a / c) * (b / e);
        int count4 = (a / e) * (b / c);
        int maxCE = Math.Max(count3, count4);
        if (maxCE > maxCount) maxCount = maxCE;

        int count5 = (a / d) * (b / e);
        int count6 = (a / e) * (b / d);
        int maxDE = Math.Max(count5, count6);
        if (maxDE > maxCount) maxCount = maxDE;

        Console.WriteLine($"Максимальное количество костей: {maxCount}");
    }
}