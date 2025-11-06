using System;
class Program
{
    static void Main()
    {
        int count5 = 0;
        int count2 = 0;

        Console.Write("количество учеников: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"ученик {i}: ");
            int ocenka = int.Parse(Console.ReadLine());

            if (ocenka == 5) count5++;
            if (ocenka == 2) count2++;
        }

        Console.WriteLine($"пятерок: {count5}");
        Console.WriteLine($"двоек: {count2}");
    }
}