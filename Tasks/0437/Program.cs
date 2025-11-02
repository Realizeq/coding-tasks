using System;
class Program
{
    static void Main()
    {
        int sum1 = 0;
        int sum2 = 0;

        Console.WriteLine("оценки первого ученика");
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"предмет {i}: ");
            int ocenka = int.Parse(Console.ReadLine());
            sum1 += ocenka;
        }

        Console.WriteLine("оценки второго ученика");
        for (int i = 1; i <= 4; i++)
        {
            Console.Write($"предмет {i}: ");
            int ocenka = int.Parse(Console.ReadLine());
            sum2 += ocenka;
        }

        Console.WriteLine($"сумма оценок первого: {sum1}");
        Console.WriteLine($"сумма оценок второго: {sum2}");
    }
}