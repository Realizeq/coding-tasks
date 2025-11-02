using System;
class Program
{
    static void Main()
    {
        Console.Write("количество учеников: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"оценка ученика {i}: ");
            double ocenka = double.Parse(Console.ReadLine());
            sum += ocenka;
        }

        double srednee = sum / n;
        Console.WriteLine($"средняя оценка: {srednee}");
    }
}